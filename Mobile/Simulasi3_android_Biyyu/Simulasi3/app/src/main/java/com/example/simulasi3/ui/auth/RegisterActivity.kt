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
import com.example.simulasi3.databinding.ActivityRegisterBinding
import com.example.simulasi3.models.ApiResponse
import com.example.simulasi3.models.RegisterRequest
import com.example.simulasi3.network.ApiClient
import com.example.simulasi3.network.ApiService
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response

class RegisterActivity : ComponentActivity() {
    private lateinit var binding: ActivityRegisterBinding
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()

        binding = ActivityRegisterBinding.inflate(layoutInflater)
        setContentView(binding.root)

        binding.btnRegister.setOnClickListener{
            val fullname = binding.etFullName.text.toString().trim()
            val email = binding.etEmail.text.toString().trim()
            val phoneNumber = binding.etPhoneNumber.text.toString().trim()
            val password = binding.etPassword.text.toString().trim()
            val confirmPassword = binding.etConfirmPassword.text.toString().trim()

            when{
                fullname.isEmpty() || password.isEmpty() || email.isEmpty() || confirmPassword.isEmpty() || phoneNumber.isEmpty() -> {
                    toast("Semua field harus diisi!")
                }

                password != confirmPassword -> {
                    toast("Password harus sama!")
                }

                password.length < 6 ->{
                    toast("Password harus lebih dari 6 karakter")
                }
                else -> {
                    val api = ApiClient.retrofit.create(ApiService::class.java)

                    val body = RegisterRequest(
                        fullname = fullname,
                        email = email,
                        phoneNumber = phoneNumber,
                        password = password,
                        confirmPassword = confirmPassword
                    )

                    api.register(body).enqueue(object: Callback<ApiResponse<Any>> {
                        override fun onResponse (
                            call: Call<ApiResponse<Any>>,
                            response: Response<ApiResponse<Any>>
                        ) {
                            if(response.isSuccessful) {
                                toast("Berhasil mendaftar")

                                startActivity(Intent(this@RegisterActivity, LoginActivity::class.java))
                                finish()
                            } else {
                                toast("Sign Up Gagal")
                            }
                        }

                        override fun onFailure(call: Call<ApiResponse<Any>>, t: Throwable) {
                            toast("Error ${t.message}")
                        }
                    })
                }
            }
        }

        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.etEmail)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }
    }
    private fun toast(msg: String){
        Toast.makeText(this, msg, Toast.LENGTH_SHORT).show()
    }
}