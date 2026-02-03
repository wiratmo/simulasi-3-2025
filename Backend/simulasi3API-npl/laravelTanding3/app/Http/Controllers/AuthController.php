<?php

namespace App\Http\Controllers;

use App\Models\Society;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Hash;

class AuthController extends Controller
{
    public function login(Request $request)
    {
        $request->validate([
            'id_card_number' => 'required',
            'password' => 'required',
        ]);

        $society = Society::where('id_card_number', $request->id_card_number);

        if (!$society->exists()) {
            return response()->json([
                'message' => 'id card or password incorrect'
            ], 401);
        }

        if (!Hash::check($request->password, $society->first()->password)) {
            return response()->json([
                'message' => 'id card or password incorrect'
            ], 401);
        }

        $token = $society->first()->createToken('token', ['society'])->plainTextToken;
        $data = $society->with('regional')->first();
        return response()->json([
            'name' => $data->name,
            'born_date' => $data->born_date,
            'gender' => $data->gender,
            'address' => $data->address,
            'token' => $token,
            'regional' => $data->regional
        ], 200);
    }

    public function logout(Request $request){
        $request->user()->currentAccessToken()->delete();

        return response()->json([
            'message' => 'logout success'
        ], 200);
    }
}
