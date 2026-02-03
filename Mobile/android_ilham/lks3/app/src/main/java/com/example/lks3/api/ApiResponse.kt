package com.example.lks3.api

import android.os.Message

data class ApiResponse<T>(
    val message: String,
    val data: T,
)
