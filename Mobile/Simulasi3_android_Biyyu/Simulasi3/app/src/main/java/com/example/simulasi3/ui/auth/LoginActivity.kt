package com.example.simulasi3.ui.auth

import android.content.Intent
import android.os.Bundle
import android.widget.Toast
import androidx.activity.ComponentActivity
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.simulasi3.R
import com.example.simulasi3.databinding.ActivityLoginBinding
import com.example.simulasi3.models.ApiResponse
import com.example.simulasi3.models.LoginRequest
import com.example.simulasi3.models.User
import com.example.simulasi3.network.ApiClient
import com.example.simulasi3.network.ApiService
import com.example.simulasi3.ui.main.MainActivity
import okhttp3.Callback
import retrofit2.Call
import retrofit2.Response

class LoginActivity : ComponentActivity() {

    private lateinit var binding: ActivityLoginBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()

        binding = ActivityLoginBinding.inflate(layoutInflater)
        setContentView(binding.root)

        val api = ApiClient.retrofit.create(ApiService::class.java)

        binding.tvRegister.setOnClickListener {
            startActivity(Intent(this, RegisterActivity::class.java))
        }

        binding.btnLogin.setOnClickListener {
            val email = binding.etEmail.text.toString().trim()
            val password = binding.etPassword.text.toString().trim()

            when {
                email.isEmpty() || password.isEmpty() -> {
                    toast("Email dan password wajib diisi!")
                }

                else -> {
                    api.login(LoginRequest(email, password))
                        .enqueue(object: retrofit2.Callback<ApiResponse<User>> {
                            override fun onResponse (
                                call: Call<ApiResponse<User>>,
                                response: Response<ApiResponse<User>>
                            ) {
                                if(response.isSuccessful) {
                                            toast("Login Berhasil")
                                            startActivity(
                                                Intent(
                                                    this@LoginActivity,
                                                    MainActivity::class.java
                                                )
                                            )
                                            finish()
                                } else {
                                    toast("Username atau password salah")
                                }
                            }

                            override fun onFailure(call: Call<ApiResponse<User>>, t: Throwable) {
                                toast("Error ${t.message}")
                            }
                        })
                }

            }

        }

    }
    private fun toast(msg: String) {
        Toast.makeText(this, msg, Toast.LENGTH_SHORT).show()
    }

}