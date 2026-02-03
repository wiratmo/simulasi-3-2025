<?php

namespace Database\Seeders;

use App\Models\Society;
use Illuminate\Database\Console\Seeds\WithoutModelEvents;
use Illuminate\Database\Seeder;

class SocietySeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        Society::insert([
            [
                'name' => 'Omar Gunawan',
                'id_card_number' => '20210001',
                'born_date' => '1990-04-18',
                'gender' => 'male',
                'address' => 'Jln. Baranang Siang No. 479, DKI Jakarta',
                'regional_id' => 1,
                'password' => bcrypt('121212'),
            ],
            [
                'name' => 'Nilam Sinaga',
                'id_card_number' => '20210002',
                'born_date' => '1998-09-11',
                'gender' => 'male',
                'address' => 'Gg. Sukajadi No. 26, DKI Jakarta',
                'regional_id' => 1,
                'password' => bcrypt('121212'),
            ],
        ]);
    }
}
