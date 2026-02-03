package com.example.simulasi2.models

data class JobResponse(
    val message: String,
    val data: List<jobs>
)

data class jobs(
    val id: Int,
    val name: String,
    val company: company,
    val locationType: String,
    val locationRegion: String,
    val yearOfExperience: String,
    val quota: Int

)

data class company(
    val name: String
)
