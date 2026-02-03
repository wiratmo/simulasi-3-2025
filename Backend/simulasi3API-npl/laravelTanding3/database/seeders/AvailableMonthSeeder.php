<?php

namespace Database\Seeders;

use App\Models\AvailableMonth;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;

class AvailableMonthSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        AvailableMonth::insert([
            [
                'installment_id' => 4,
                'month' => 6,
                'description' => 'au',
            ],
            [
                'installment_id' => 5,
                'month' => 6,
                'description' => 'au',
            ],
            [
                'installment_id' => 6,
                'month' => 6,
                'description' => 'au',
            ],
        ]);
    }
}
