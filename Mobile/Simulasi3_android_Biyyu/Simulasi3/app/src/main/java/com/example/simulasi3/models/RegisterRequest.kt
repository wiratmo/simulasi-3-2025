package com.example.simulasi3.models

data class RegisterRequest(
    val fullname: String,
    val email: String,
    val phoneNumber: String,
    val password: String,
    val confirmPassword: String
)
