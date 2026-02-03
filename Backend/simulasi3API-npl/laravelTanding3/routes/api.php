<?php

use App\Http\Controllers\AppllicationsController;
use App\Http\Controllers\AuthController;
use App\Http\Controllers\InstallmentController;
use App\Http\Controllers\ValidationController;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

Route::prefix('v1')->group(function () {
    Route::prefix('auth')->group(function() {
        Route::post('login', [AuthController::class, 'login']);
        Route::post('logout', [AuthController::class, 'logout'])->middleware('auth:sanctum');
    });
    Route::middleware('auth:sanctum')->group(function () {
        Route::prefix('validation')->group(function () {
            Route::post('/', [ValidationController::class, 'post']);
            Route::get('/', [ValidationController::class, 'get']);
        });
        Route::prefix('installments_cars')->group(function () {
            Route::get('/', [InstallmentController::class, 'getAll']);
            Route::get('/{id}', [InstallmentController::class, 'getById']);
        });
        Route::prefix('applications')->group(function () {
            Route::post('/', [AppllicationsController::class, 'post']);
            Route::get('/', [AppllicationsController::class, 'getAll']);
        });
    });
});