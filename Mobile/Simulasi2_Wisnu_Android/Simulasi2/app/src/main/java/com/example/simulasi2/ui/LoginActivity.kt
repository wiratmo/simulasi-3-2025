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
import com.example.simulasi2.databinding.ActivityLoginBinding
import com.example.simulasi2.models.LoginRequest
import com.example.simulasi2.models.LoginResponse
import com.example.simulasi2.models.user
import com.example.simulasi2.network.ApiClient
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response

class LoginActivity : AppCompatActivity() {
    private lateinit var binding: ActivityLoginBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()

        binding = ActivityLoginBinding.inflate(layoutInflater)
        setContentView(binding.root)

        binding.btnLLogin.setOnClickListener {
            val email = binding.etLEmail.text.toString()
            val password = binding.etLPassword.text.toString()

            if (email.isNotEmpty() && password.isNotEmpty()) {
                login(email, password)
            } else {
                toast("Email dan password harus diisi")
            }
        }

        binding.tvRegister.setOnClickListener {
            startActivity(Intent(this, RegisterActivity::class.java))
        }
    }

    private fun login(email: String, password: String) {
        val request = LoginRequest(email, password)
        ApiClient.api.login(request).enqueue(object : Callback<LoginResponse> {
            override fun onResponse(
                call: Call<LoginResponse?>,
                response: Response<LoginResponse?>
            ) {
                if (response.isSuccessful) {
                    val user = response.body()!!.data
                    if (user.role == "JobSeeker") {
                        saveUser(user)
                        toast("Berhasil login")
                        startActivity(Intent(this@LoginActivity, MainActivity::class.java))
                        finish()
                    } else {
                        toast("Hanya JobSeeker yang bisa login")
                    }
                } else {
                    toast("email atau password salah")
                }
            }

            override fun onFailure(call: Call<LoginResponse?>, t: Throwable) {
                toast("Terjadi Kesalahan")
                Log.e("EROR", t.message.toString())
            }
        })
    }

    private fun saveUser(u: user) {
        val pref = getSharedPreferences("AUTH", MODE_PRIVATE)

        pref.edit().apply {
            putInt("id", u.id)
            putString("profilePicture", u.profilePicture)
            putString("fullname", u.fullname)
            putString("email", u.phoneNumber)
            putString("role", u.role)
            apply()
        }
    }

    private fun toast(msg: String) {
        Toast.makeText(this, msg, Toast.LENGTH_SHORT).show()
    }
}