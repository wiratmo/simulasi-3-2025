package com.example.simulasi2.ui

import android.content.Context
import android.view.LayoutInflater
import android.view.ViewGroup
import android.widget.LinearLayout
import androidx.recyclerview.widget.LinearLayoutManager
import androidx.recyclerview.widget.RecyclerView
import com.example.simulasi2.databinding.ItemJobExploreBinding
import com.example.simulasi2.models.jobs

class JobAdapter(
    private val context: Context, private val list: MutableList<jobs>
): RecyclerView.Adapter<JobAdapter.ViewHolder>() {
    inner class ViewHolder(val binding: ItemJobExploreBinding): RecyclerView.ViewHolder(binding.root)

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): ViewHolder {
        val binding = ItemJobExploreBinding.inflate(
            LayoutInflater.from(parent.context),
            parent,
            false
        )
        return ViewHolder(binding)
    }

    override fun getItemCount() = list.size

    override fun onBindViewHolder(holder: ViewHolder, position: Int) {
        val job = list[position]

        holder.binding.apply {
            tvIJName.text = job.name
            tvILCompany.text = job.company.name
            tvIJLoaction.text = "${job.locationType} (${job.locationType})"
            tvIJExp.text = "Min. ${job.yearOfExperience} years of experience"
        }
    }

    fun update(newList: List<jobs>) {
        list.clear()
        list.addAll(newList)
        notifyDataSetChanged()
    }
}