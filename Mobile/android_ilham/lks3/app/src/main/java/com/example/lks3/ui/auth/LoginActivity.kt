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
import com.example.lks3.api.ApiService
import com.example.lks3.databinding.ActivityLoginBinding
import com.example.lks3.model.LoginRequest
import com.example.lks3.model.User
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response

class LoginActivity : AppCompatActivity() {
    private val binding by lazy { ActivityLoginBinding.inflate(layoutInflater) }
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(binding.root)
        binding.tvRegister.setOnClickListener {
            startActivity(Intent(this@LoginActivity, RegisterActivity::class.java))
        }
        binding.btnLogin.setOnClickListener {
            val username = binding.etUsername.text.toString()
            val password = binding.etPassword.text.toString()
            val l = LoginRequest(username, password)
            ApiClient.api.login(l).enqueue(object: Callback<ApiResponse<User>>{
                override fun onResponse(
                    call: Call<ApiResponse<User>?>,
                    response: Response<ApiResponse<User>?>
                ) {
                    if (response.isSuccessful) {
                        val body = response.body()
                        val user = body?.data
                        val prefs = getSharedPreferences("session", MODE_PRIVATE)
                        prefs.edit().apply {
                            putInt("id", user!!.id)
                            putString("profile_picture", user.profilePicture)
                            putString("fullname", user.fullname)
                            putString("email", user.email)
                            putString("phone_number", user.phoneNumber)
                            putString("role", user.role)
                            apply()
                        }
                        Toast.makeText(applicationContext, "Success", Toast.LENGTH_SHORT).show()
                        startActivity(Intent(this@LoginActivity, MainActivity::class.java))
                    }
                    else {
                        Toast.makeText(applicationContext, "Ada yang salah", Toast.LENGTH_SHORT).show()
                    }
                }

                override fun onFailure(
                    call: Call<ApiResponse<User>?>,
                    t: Throwable
                ) {
                    Toast.makeText(applicationContext, t.toString(), Toast.LENGTH_SHORT).show()
                }

            })
        }
    }
}