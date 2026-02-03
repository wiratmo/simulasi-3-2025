<?php

use App\Http\Controllers\ApplyController;
use App\Http\Controllers\AuthController;
use App\Http\Controllers\InstallmentController;
use App\Http\Controllers\ValidationController;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

Route::get('/user', function (Request $request) {
    return $request->user();
})->middleware('auth:sanctum');

Route::prefix('v1')->group(function () {
    Route::prefix('auth')->group(function () {
        Route::post('login', [AuthController::class, 'login']);
        Route::post('logout', [AuthController::class, 'logout'])->middleware('auth:sanctum');
    });

    Route::middleware('auth:sanctum')->group(function () {
        Route::prefix('validations')->group(function () {
            Route::post('', [ValidationController::class, 'post']);
            Route::get('', [ValidationController::class, 'get']);
        });
        Route::prefix('instalment_cars')->group(function () {
            Route::get('', [InstallmentController::class, 'get']);
            Route::get('{id}', [InstallmentController::class, 'getDetail']);
        });
        Route::prefix('applications')->group(function () {
            Route::post('', [ApplyController::class, 'post']);
            Route::get('', [ApplyController::class, 'get']);
        });
    });
});
