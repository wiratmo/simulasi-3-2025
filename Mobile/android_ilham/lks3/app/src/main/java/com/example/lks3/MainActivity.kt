package com.example.lks3

import android.content.Intent
import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.padding
import androidx.compose.material3.Scaffold
import androidx.compose.material3.Text
import androidx.compose.runtime.Composable
import androidx.compose.ui.Modifier
import androidx.compose.ui.tooling.preview.Preview
import com.bumptech.glide.Glide
import com.example.lks3.databinding.ActivityLoginBinding
import com.example.lks3.databinding.ActivityMainBinding
import com.example.lks3.ui.auth.LoginActivity
import com.example.lks3.ui.theme.Lks3Theme

class MainActivity : AppCompatActivity() {
    private val binding by lazy { ActivityMainBinding.inflate(layoutInflater) }
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(binding.root)
        val prefs = getSharedPreferences("session", MODE_PRIVATE)
        binding.tvFullname.text = prefs.getString("fullname", "")
        binding.tvEmail.text = prefs.getString("email", "")
        binding.tvPhoneNumber.text = prefs.getString("phone_number", "")
        binding.tvRole.text = prefs.getString("role", "")
        val photo = prefs.getString("profile_picture", "")
        val photoUrl = "http://10.0.2.2:5000/images/$photo"
        Glide.with(this).load(photoUrl).placeholder(R.drawable.ic_launcher_background).error(R.drawable.ic_launcher_background).into(binding.imgProfile)
        binding.btnLogout.setOnClickListener {
            prefs.edit().clear().apply()
            startActivity(Intent(this@MainActivity, LoginActivity::class.java))
            finish()
        }
    }
}