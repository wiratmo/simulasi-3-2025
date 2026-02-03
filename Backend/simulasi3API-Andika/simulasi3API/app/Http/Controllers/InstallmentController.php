<?php

namespace App\Http\Controllers;

use App\Models\Available_month;
use App\Models\Installment;
use Exception;
use Illuminate\Http\Request;

class InstallmentController extends Controller
{
    public function get(Request $request)
    {
        try {
            $user = $request->user();

            $installment = Installment::with('brand', 'available_months')
            ->whereHas('available_months')
            ->orderBy('price', 'asc')
            ->get();

            return response()->json([
                'cars' => $installment
            ], 200);
        } catch (Exception $e) {
            return response()->json([
                'message' => $e->getMessage()
            ], 400);
        }
    }
    public function getDetail(Request $request, $id)
    {
        try {
            $installment = Installment::with('brand', 'available_months')->where('id', $id)->first();

            if (!$installment) {
                return response()->json([
                    'message' => 'installment not found'
                ], 404);
            }

            return response()->json([
                'installment' => $installment
            ], 200);
        } catch (Exception $e) {
            return response()->json([
                'message' => $e->getMessage()
            ], 400);
        }
    }
}
