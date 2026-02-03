package com.example.lks3.api

import com.example.lks3.model.LoginRequest
import com.example.lks3.model.RegisterRequest
import com.example.lks3.model.User
import retrofit2.Call
import retrofit2.http.Body
import retrofit2.http.POST

interface ApiService {
    @POST("api/auth")
    fun login(@Body body: LoginRequest): Call<ApiResponse<User>>

    @POST("api/register")
    fun register(@Body body: RegisterRequest): Call<ApiResponse<Any>>
}