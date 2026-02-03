package com.example.simulasi3.models

data class User(
    val Id: Int,
    val fullname: String,
    val email: String,
    val phoneNumber: String,
    val password: String,
    val confirmPassword: String
)
