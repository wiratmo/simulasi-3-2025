<?php

namespace App\Http\Controllers;

use App\Models\Installment;
use App\Models\InstallmentApplySociety;
use App\Models\Validation;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

class AppllicationsController extends Controller
{
    public function post(Request $request)
    {
        $request->validate([
            'installment_id' => 'required',
            'months' => 'required',
            'notes' => 'required',
        ]);

        $society = Auth::user();
        $validation = Validation::where('society_id', $society->id)->where('status', 'pending');
        if($validation->exists()){
            return response()->json([
                'message' => 'Your data validator must be accepted by validator before'
            ], 401);
        }

        $apply = InstallmentApplySociety::where('installment_id', $request->installment_id);

        if ($apply->where('society_id', $society->id)->exists()) {
            return response()->json([
                'message' => 'Application for a instalment can only be once'
            ], 401);
        }

        InstallmentApplySociety::create([
            'installment_id' => $request->installment_id,
            'available_month_id' => $request->months,
            'notes' => $request->notes,
            'date' => now(),
            'society_id' => $society->id,
        ]);

        return response()->json([
            'message' => 'Applying for Instalment successful'
        ], 200);
    }

    public function getAll(){
        return response()->json([
            'instalments' => Installment::with('applications')->get()
        ], 200);
    }
}
