package com.example.lks3.ui.auth

import android.content.Intent
import android.os.Bundle
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.lks3.MainActivity
import com.example.lks3.R
import com.example.lks3.api.ApiClient
import com.example.lks3.api.ApiResponse
import com.example.lks3.databinding.ActivityLoginBinding
import com.example.lks3.databinding.ActivityRegisterBinding
import com.example.lks3.model.LoginRequest
import com.example.lks3.model.RegisterRequest
import com.example.lks3.model.User
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response

class RegisterActivity : AppCompatActivity() {
    private val binding by lazy { ActivityRegisterBinding.inflate(layoutInflater) }
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(binding.root)
        binding.tvLogin.setOnClickListener {
            startActivity(Intent(this@RegisterActivity, LoginActivity::class.java))
        }
        binding.btnRegister.setOnClickListener {
            val fullName = binding.etFullname.text.toString()
            val email = binding.etFullname.text.toString()
            val phoneNumber = binding.etFullname.text.toString()
            val password = binding.etPassword.text.toString()
            val conPass = binding.etFullname.text.toString()
            val r = RegisterRequest(fullName, email, phoneNumber, password, conPass)
            ApiClient.api.register(r).enqueue(object: Callback<ApiResponse<Any>>{
                override fun onResponse(
                    call: Call<ApiResponse<Any>?>,
                    response: Response<ApiResponse<Any>?>
                ) {
                    if (response.isSuccessful) {
                        Toast.makeText(applicationContext, response.body()?.message, Toast.LENGTH_SHORT).show()
                        startActivity(Intent(this@RegisterActivity, LoginActivity::class.java))
                    }
                    else {
                        Toast.makeText(applicationContext, response.body()?.message, Toast.LENGTH_SHORT).show()
                    }
                }

                override fun onFailure(
                    call: Call<ApiResponse<Any>?>,
                    t: Throwable
                ) {
                    Toast.makeText(applicationContext, t.toString(), Toast.LENGTH_SHORT).show()
                }

            })
        }
    }
}