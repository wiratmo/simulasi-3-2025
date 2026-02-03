package com.example.simulasi2.network

import com.example.simulasi2.models.JobResponse
import com.example.simulasi2.models.LoginRequest
import com.example.simulasi2.models.LoginResponse
import com.example.simulasi2.models.RegisterRequest
import com.example.simulasi2.models.RegisterResponse
import retrofit2.Call
import retrofit2.http.Body
import retrofit2.http.GET
import retrofit2.http.POST

interface ApiService {
    @POST("auth")
    fun login(@Body request: LoginRequest): Call<LoginResponse>

    @POST("register")
    fun register(@Body request: RegisterRequest): Call<RegisterResponse>

    @GET("jobs")
    fun getJobs(): Call<JobResponse>
}