<?php

namespace App\Http\Controllers;

use App\Models\Society;
use App\Models\User;
use Exception;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Facades\Validator;
use PhpParser\Node\Stmt\TryCatch;

class AuthController extends Controller
{
    public function login(Request $request) {
        try {
            $validator = Validator::make($request->all(), [
                'id_card_number' => 'required',
                'password' => 'required',
            ]);

            if($validator->fails()) {
                return response()->json([
                    'message' => 'invalid field',
                    'error' => $validator->errors(),
                ], 422);
            }

            $user = Society::with('regional')->where('id_card_number', $request->id_card_number)->first();

            if(!$user || ! Hash::check($request->password, $user->password)) {
                return response()->json([
                    'message' => 'ID Card Number or Password incorrect'
                ], 401);
            }

            $token = $user->createToken('society_token', ['society'])->plainTextToken;

            return response()->json([
                'name' => $user->name,
                'born_date' => $user->born_date,
                'address' => $user->address,
                'token' => $token,
                'regional' => $user->regional
            ], 200);
        } catch (Exception $e) {
            return response()->json([
                'message' => $e->getMessage()
            ], 400);
        }
    }
    public function logout(Request $request) {
        try {
            $user = $request->user();

            $user->currentAccessToken()->delete();

            return response()->json([
                'message' => 'logout success'
            ], 200);
        } catch (Exception $e) {
            return response()->json([
                'message' => $e->getMessage()
            ], 400);
        }
    }
}
