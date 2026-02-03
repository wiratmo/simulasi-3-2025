<?php

namespace App\Http\Controllers;

use App\Models\Installment;
use Illuminate\Http\Request;

class InstallmentController extends Controller
{
    public function getAll(){
        return response()->json([
            'cars' => Installment::with('availableMonth')->get()
        ], 200);
    }

    public function getById($id){
        return response()->json([
            'installment' => Installment::where('id', $id)->with('availableMonth')->get()
        ], 200);
    }
}
