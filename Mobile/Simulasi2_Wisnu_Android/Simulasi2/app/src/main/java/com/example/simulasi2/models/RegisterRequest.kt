package com.example.simulasi2.models

data class RegisterRequest(
    val fullname: String,
    val email: String,
    val phoneNUmber: String,
    val password: String,
    val confirmPassword: String
)
