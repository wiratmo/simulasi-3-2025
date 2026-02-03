package com.example.simulasi2.models

data class LoginResponse(
    val message: String,
    val data: user
)

data class user(
    val id: Int,
    val profilePicture: String,
    val fullname: String,
    val email: String,
    val phoneNumber: String,
    val role: String
)
