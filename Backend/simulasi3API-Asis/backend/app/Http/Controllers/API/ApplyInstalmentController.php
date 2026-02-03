<?php

namespace App\Http\Controllers\API;

use App\Http\Controllers\Controller;
use App\Models\Installment;
use App\Models\InstallmentApplySociety;
use App\Models\InstallmentApplyStatus;
use App\Models\Validation;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Validator;

class ApplyInstalmentController extends Controller
{
    public function createApply(Request $request) {
        try {
            $user = $request->user();

            $validation = Validation::where("society_id", $user->id)->first();

            if($validation->status !== "accepted") {
                return response()->json([
                    "message" => "Your data validator must be accepted"
                ], 401);
            }

            $application = InstallmentApplySociety::where("society_id", $user->id)->first();

            if($application) {
                return response()->json([
                    "message" => "Application for a instalment can only be once"
                ], 401);
            }

            $validator = Validator::make($request->all(), [
                "installment_id" => "required|exists:installments,id",
                "months" => "required|exists:available_months,id",
                "notes" => "required|string"
            ]);

            if($validator->fails()) {
                return response()->json([
                    "message" => "Invalid field",
                    "errors" => $validator->errors()
                ], 401);
            }

            $installment = InstallmentApplySociety::create([
                "notes" => $request->notes,
                "available_month_id" => $request->months,
                "date" => now(),
                "society_id" => $user->id,
                "installment_id" => $request->installment_id
            ]);

            InstallmentApplyStatus::create([
                "date" => now(),
                "society_id" => $user->id,
                "installment_id" => $request->installment_id,
                "available_month_id" => $request->months,
                "installment_apply_society_id" => $installment->id,
                "status" => "pending",
            ]);

            return response()->json([
                "message" => "Apply for instalment successful"
            ], 200);
        } catch (\Throwable $th) {
            return response()->json([
                "message" => "server error",
                "errors" => $th->getMessage()
            ], 500);
        }
    }

    public function getAllSocietyInstalment(Request $request) {
        try {
            $application = InstallmentApplyStatus::with(["installment", "AvailableMonth", "InstallmentApplySociety"]);

            return response()->json([
                "installments" => $application->map(function($a) {
                    return [
                        "id" => $a->installment->id,
                        "car" => $a->installment->cars,
                        "description" => $a->installment->descrition,
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
