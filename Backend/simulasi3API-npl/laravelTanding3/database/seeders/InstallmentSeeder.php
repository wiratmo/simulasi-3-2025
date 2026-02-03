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
                'brand_id' => '5',
                'cars' => 'VELOZ',
                'description' => 'KONDISI 3 bulan pakai, dijual karena bozen',
                'price' => '27000000',
            ],
            [
                'brand_id' => '12',
                'cars' => 'GT3 RS',
                'description' => 'KONDISI 1 bulan pakai, dijual karena pengen bmw',
                'price' => '50000000',
            ],
            [
                'brand_id' => '9',
                'cars' => 'rx 7',
                'description' => 'KONDISI 2 tahun pakai, dijual karena boroz oli',
                'price' => '700000000',
            ]
        ]);
    }
}
