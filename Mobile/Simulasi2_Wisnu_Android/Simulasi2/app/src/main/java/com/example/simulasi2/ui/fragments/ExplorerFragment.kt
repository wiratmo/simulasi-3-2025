package com.example.simulasi2.ui.fragments

import android.os.Bundle
import androidx.fragment.app.Fragment
import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import android.widget.Toast
import androidx.recyclerview.widget.LinearLayoutManager
import com.example.simulasi2.R
import com.example.simulasi2.databinding.FragmentExplorerBinding
import com.example.simulasi2.models.JobResponse
import com.example.simulasi2.models.jobs
import com.example.simulasi2.network.ApiClient
import com.example.simulasi2.ui.JobAdapter
import retrofit2.Call
import retrofit2.Callback
import retrofit2.Response

// TODO: Rename parameter arguments, choose names that match
// the fragment initialization parameters, e.g. ARG_ITEM_NUMBER
private const val ARG_PARAM1 = "param1"
private const val ARG_PARAM2 = "param2"

/**
 * A simple [Fragment] subclass.
 * Use the [ExplorerFragment.newInstance] factory method to
 * create an instance of this fragment.
 */
class ExplorerFragment : Fragment() {

    private var _binding: FragmentExplorerBinding? = null
    private val binding get() = _binding!!
    private lateinit var adapter: JobAdapter
    private lateinit var allJob: MutableList<jobs>

    override fun onCreateView(
        inflater: LayoutInflater, container: ViewGroup?,
        savedInstanceState: Bundle?
    ): View {
        _binding = FragmentExplorerBinding.inflate(inflater, container, false)
        return binding.root
    }

    override fun onViewCreated(view: View, savedInstanceState: Bundle?) {
        super.onViewCreated(view, savedInstanceState)

        adapter = JobAdapter(requireContext(), mutableListOf())

        binding.rvJob.layoutManager = LinearLayoutManager(requireContext())
        binding.rvJob.adapter =  adapter

        loadData()
    }

    private fun loadData() {
        ApiClient.api.getJobs().enqueue(object : Callback<JobResponse> {
            override fun onResponse(call: Call<JobResponse?>, response: Response<JobResponse?>) {
                if (response.isSuccessful) {
                    allJob = response.body()!!.data.toMutableList()
                    adapter.update(allJob)
                }
            }

            override fun onFailure(call: Call<JobResponse?>, t: Throwable) {
                TODO("Not yet implemented")
            }
        })
    }

    private fun toast(msg: String) {
        Toast.makeText(requireContext(), msg, Toast.LENGTH_SHORT).show()
    }
}