package com.example.simulasi2.ui

import android.os.Bundle
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.fragment.app.Fragment
import androidx.navigation.findNavController
import com.example.simulasi2.R
import com.example.simulasi2.databinding.ActivityMainBinding
import com.example.simulasi2.ui.fragments.ExplorerFragment
import com.example.simulasi2.ui.fragments.MyJobFragment
import com.example.simulasi2.ui.fragments.ProfileFragment

class MainActivity : AppCompatActivity() {
    private lateinit var binding: ActivityMainBinding

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()

        binding = ActivityMainBinding.inflate(layoutInflater)
        setContentView(binding.root)

        loadFragment(ExplorerFragment())

        binding.bottomNavigationView.setOnItemSelectedListener {
            when(it.itemId) {
                R.id.navExplorerFragment -> loadFragment(ExplorerFragment())
                R.id.navMyJobFragment -> loadFragment(MyJobFragment())
                R.id.navProfileFragment ->loadFragment(ProfileFragment())
            }
            true
        }
    }

    private fun loadFragment(fragment: Fragment) {
        supportFragmentManager.beginTransaction()
            .replace(R.id.frameLayout, fragment)
            .commit()
    }
}