<?php

namespace App\Http\Controllers;

use App\Models\Installment_apply_society;
use App\Models\Installment_apply_status;
use App\Models\Validation;
use Carbon\Carbon;
use Exception;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Validator as FacadesValidator;
use Illuminate\Support\Facades\Validator;

class ApplyController extends Controller
{
    public function post(Request $request)
    {
        try {
            $user = $request->user();

            $validator = Validator::make($request->all(), [
                'installment_id' => 'required|exists:installments,id',
                'months' => 'required|exists:available_months,id',
            ]);

            if ($validator->fails()) {
                return response()->json([
                    'message' => 'invalid field',
                    'error' => $validator->errors(),
                ], 422);
            }

            $hasValidation = Validation::where('society_id', $user->id)
                ->where('status', 'accepted')->orderBy('id', 'desc')->limit(1);

            if (!$hasValidation->exists()) {
                return response()->json([
                    'message' => 'Your data validator must be accepted by validator before'
                ], 401);
            }

            $hasApply = Installment_apply_society::where('society_id', $user->id)
                ->where('installment_id', $request->installment_id);

            if ($hasApply->exists()) {
                return response()->json([
                    'message' => 'Application for a instalment can only be once'
                ], 401);
            }

            $create = Installment_apply_society::create([
                'notes' => $request->notes,
                'installment_id' => $request->installment_id,
                'available_month_id' => $request->months,
                'date' => Carbon::now(),
                'society_id' => $user->id,
            ]);
            Installment_apply_status::create([
                'installment_apply_societiy_id' => $create->id,
                'installment_id' => $request->installment_id,
                'available_month_id' => $request->months,
                'society_id' => $user->id,
                'date' => Carbon::now(),
            ]);

            return response()->json([
                'message' => 'Applying for Instalment successful'
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

            $application = Installment_apply_status::with('installment.brand', 'apply_society', 'available_month')
                ->where('society_id', $user->id)->get();

            $data = $application->map(function ($a) {
                return [
                    'id' => $a->installment->id,
                    'car' => $a->installment->cars,
                    'brand' => $a->installment->brand->brand,
                    'price' => $a->installment->price,
                    'description' => $a->installment->description,
                    "application" => [
                        'month' => $a->available_month->month,
                        'nominal' => $a->available_month->nominal,
                        'apply_status' => $a->status,
                        'note' => $a->apply_society->notes,
                    ]
                ];
            });

            return response()->json([
                'instalments' => $data
            ], 200);
        } catch (Exception $e) {
            return response()->json([
                'message' => $e->getMessage()
            ], 400);
        }
    }
}
