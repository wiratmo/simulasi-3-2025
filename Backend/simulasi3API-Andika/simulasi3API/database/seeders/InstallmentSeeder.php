<?php

namespace Database\Seeders;

use App\Models\Installment;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;

class InstallmentSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        Installment::insert([
            [
                'brand_id' => 1,
                'price' => 200000,
                'description' => 'description',
                'cars' => 'toyota corolla',
            ]
        ]);
    }
}
