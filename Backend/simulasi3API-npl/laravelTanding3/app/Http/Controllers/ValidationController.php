<?php

namespace App\Http\Controllers;

use App\Models\Validation;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;

class ValidationController extends Controller
{
    public function post(Request $request){
        $request->validate([
            'job' => 'required',
            'job_description' => 'required',
            'income' => 'required',
            'reason_accepted' => 'required',
        ]);

        $society = Auth::user();

        if(Validation::where('society_id', $society->id)->where('status', 'pending')->exists()){
            return response()->json([
                'message' => 'sabar boz, yang dulu belum di acc'
            ], 403);
        }

        Validation::create([
            'society_id' => $society->id,
            'status' => 'pending',
            'job' => $request->job,
            'job_description' => $request->job_description,
            'income' => $request->income,
            'reason_accepted' => $request->reason_accepted,
        ]);

        return response()->json([
            'message' => 'Request data validation sent successful'
        ], 200);
    }

    public function get(    ){
        return response()->json([
            'validation' => Validation::orderBy('id', 'desc')->first()
        ], 200);
    }
}
