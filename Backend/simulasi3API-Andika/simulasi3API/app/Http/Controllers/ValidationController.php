<?php

namespace App\Http\Controllers;

use App\Models\Validation;
use Dotenv\Parser\Value;
use Exception;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Validator;

class ValidationController extends Controller
{
    public function post(Request $request)
    {
        try {
            $user = $request->user();

            $validator = Validator::make($request->all(), [
                'job' => 'required',
                'job_description' => 'required',
                'income' => 'required',
                'reason_accepted' => 'required',
            ]);

            if ($validator->fails()) {
                return response()->json([
                    'message' => 'invalid field',
                    'error' => $validator->errors(),
                ], 422);
            }

            $hasValidation = Validation::where('society_id', $user->id)->where('status', 'pending');

            if ($hasValidation->exists()) {
                return response()->json([
                    'message' => 'you can only have one validation'
                ], 401);
            }

            $create = Validation::create([
                'society_id' => $user->id,
                'job' => $request->job,
                'job_description' => $request->job_description,
                'income' => $request->income,
                'reason_accepted' => $request->reason_accepted,
            ]);

            return response()->json([
                'message' => 'Request data validation sent successful'
            ], 200);
        } catch (Exception $e) {
            return response()->json([
                'message' => $e->getMessage()
            ], 400);
        }
    }
    public function get(Request $request)
    {
        try {
            $user = $request->user();

            $validation = Validation::where('society_id', $user->id)->orderBy('id', 'desc')->limit(1)->first();

            return response()->json([
                'validation' => $validation
            ], 200);
        } catch (Exception $e) {
            return response()->json([
                'message' => $e->getMessage()
            ], 400);
        }
    }
}
