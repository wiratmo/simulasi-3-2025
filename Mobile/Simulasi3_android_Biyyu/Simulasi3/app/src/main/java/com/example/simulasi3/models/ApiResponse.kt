package com.example.simulasi3.models

data class ApiResponse<T>(
    val message: String,
    val data: T
)
