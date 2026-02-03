<?php

namespace Database\Seeders;

use App\Models\Regional;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;

class RegionalSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        Regional::insert([
            [
                'province' => 'DKI Jakarta',
                'district' => 'Central Jakarta'
            ],
            [
                'province' => 'DKI Jakarta',
                'district' => 'South Jakarta'
            ],
            [
                'province' => 'West Java',
                'district' => 'Bandung'
            ],
        ]);
    }
}
