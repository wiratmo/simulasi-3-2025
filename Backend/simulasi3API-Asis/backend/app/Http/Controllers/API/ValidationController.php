<?php

namespace App\Http\Controllers\API;

use App\Http\Controllers\Controller;
use App\Models\Validation;
use Illuminate\Http\Request;

class ValidationController extends Controller
{
    public function createValidation(Request $request) {
        try {
            $request->validate([
                "job" => "required|string",
                "job_description" => "required|string",
                "income" => "required|string",
                "reason_accepted" => "required|string"
            ]);


            $user = $request->user();

            $validation = Validation::where("id", $user->id)->first();

            if($validation) {
                return response()->json([
                    "message" => "Sorry you can only insert for once"
                ], 403);
            }

            Validation::create([
                "society_id" => $user->id,
                "job" => $request->job,
                "job_description" => $request->job_description,
                "income" => $request->income,
                "reason_accepted" => $request->reason_accepted
            ]);

            return response()->json([
                "message" => "Request data validation sent"
            ], 200);
        } catch (\Throwable $th) {
            return response()->json([
                "message" => "server error",
                "errors" => $th->getMessage()
            ], 500);
        }
    }


    public function getValidation(Request $request) {
        try {
            $validations = Validation::all();

            return response()->json([
                "validation" => $validations->map(function($validation) {
                    return [
                        "id" => $validation->id,
                        "status" => $validation->status,
                        "job" => $validation->job,
                        "job_description" => $validation->job_description,
                        "income" => $validation->income,
                        "reason_accepted" => $validation->reason_accepted,
                        "validator_notes" => $validation->validator_notes,
                        "validator" => $validation->validators_id,
                    ];
                })
            ], 200);
        } catch (\Throwable $th) {
            return response()->json([
                "message" => "server error",
                "errors" => $th->getMessage()
            ], 500);
        }
    }
}
