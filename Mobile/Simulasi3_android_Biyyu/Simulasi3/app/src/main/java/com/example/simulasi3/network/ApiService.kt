package com.example.simulasi3.network

import com.example.simulasi3.models.ApiResponse
import com.example.simulasi3.models.LoginRequest
import com.example.simulasi3.models.RegisterRequest
import com.example.simulasi3.models.User
import retrofit2.http.Body
import retrofit2.http.GET
import retrofit2.Call
import retrofit2.http.POST

interface ApiService {
    @POST("api/auth")
    fun login(@Body body: LoginRequest): Call<ApiResponse<User>>

    @POST("api/register")
    fun register(@Body body: RegisterRequest): Call<ApiResponse<Any>>
}