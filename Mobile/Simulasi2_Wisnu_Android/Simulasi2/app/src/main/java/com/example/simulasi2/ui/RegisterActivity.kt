package com.example.simulasi2.ui

import android.content.Intent
import android.os.Bundle
import android.util.Log
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat
import com.example.simulasi2.R
import com.example.simulasi2.databinding.ActivityRegisterBinding
import com.example.simulasi2.models.LoginRequest
import com.example.simulasi2.models.LoginResponse
import com.example.simulasi2.models.RegisterRequest
import com.example.simulasi2.models.RegisterResponse
import com.example.simulasi2.network.ApiClient
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response

class RegisterActivity : AppCompatActivity() {
    private lateinit var binding: ActivityRegisterBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()

        binding = ActivityRegisterBinding.inflate(layoutInflater)
        setContentView(binding.root)

        binding.btnRegister.setOnClickListener {
            val fullname = binding.etRFullName.text.toString()
            val email = binding.etREmail.text.toString()
            val phoneNumber = binding.etRPhoneNumber.text.toString()
            val password = binding.etRPassword.text.toString()
            val confirmPassword = binding.etRConfirmPassword.text.toString()

            if (fullname.isNotEmpty() && email.isNotEmpty() && phoneNumber.isNotEmpty() && password.isNotEmpty() && confirmPassword.isNotEmpty()) {
                if (confirmPassword == password) {
                    val request = RegisterRequest(fullname, email, phoneNumber, password, confirmPassword)
                    register(request)
                } else {
                    toast("Confirm password anda salah $password and $confirmPassword")
                }
            } else {
                toast("Semua field harus diisi")
            }
        }

        binding.tvLogin.setOnClickListener {
            startActivity(Intent(this, LoginActivity::class.java))
        }
    }

    private fun register(request: RegisterRequest) {
        ApiClient.api.register(request).enqueue(object : Callback<RegisterResponse> {
            override fun onResponse(
                call: Call<RegisterResponse?>,
                response: Response<RegisterResponse?>
            ) {
                if (response.isSuccessful) {
                    toast("Berhasil registrasi")
                    startActivity(Intent(this@RegisterActivity, LoginActivity::class.java))
                    finish()
                } else {
                    toast("format salah")
                }
            }

            override fun onFailure(call: Call<RegisterResponse?>, t: Throwable) {
                toast("Terjadi Kesalahan")
                Log.e("EROR", t.message.toString())
            }
        })
    }

    private fun toast(msg: String) {
        Toast.makeText(this, msg, Toast.LENGTH_SHORT).show()
    }
}