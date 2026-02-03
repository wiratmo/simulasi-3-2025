<?php

namespace Database\Seeders;

use App\Models\Available_month;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;

class MonthSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        Available_month::insert([
            [
                'month' => 1,
                'installment_id' => 2,
                'nominal' => 3000,
                'description' => 'blabal',
            ],
            [
                'month' => 2,
                'installment_id' => 2,
                'nominal' => 4000,
                'description' => 'blabal',
            ],
        ]);
    }
}
