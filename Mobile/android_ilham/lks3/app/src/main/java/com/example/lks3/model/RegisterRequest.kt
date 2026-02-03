package com.example.lks3.model

data class RegisterRequest(
    val fullname: String,
    val email: String,
    val phoneNumber: String,
    val password: String,
    val confirmPassword: String,
)
