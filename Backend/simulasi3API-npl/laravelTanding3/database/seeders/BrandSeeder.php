<?php

namespace Database\Seeders;

use App\Models\Brand;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;

class BrandSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        Brand::insert([
            ['brand' => 'BMW'],
            ['brand' => 'VOLKSWAGON'],
            ['brand' => 'MERCEDES-BENZ'],
            ['brand' => 'AUDI'],
            ['brand' => 'TOYOTA'],
            ['brand' => 'FERARI'],
            ['brand' => 'SUBARU'],
            ['brand' => 'DAIHATSU'],
            ['brand' => 'MAZDA'],
            ['brand' => 'LAMBORGINI'],
            ['brand' => 'KTM'],
            ['brand' => 'PORCHE'],
            ['brand' => 'CITROEN'],
            ['brand' => 'BUGGATI'],
            ['brand' => 'NISSAN'],
            ['brand' => 'ROLL-ROYSE'],
            ['brand' => 'BYD'],
        ]);
    }
}
