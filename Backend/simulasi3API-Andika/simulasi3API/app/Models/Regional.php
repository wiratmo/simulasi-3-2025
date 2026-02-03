<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Regional extends Model
{
    protected $fillable = [
        'province',
        'district',
    ];

    protected $hidden = [
        'created_at',
        'updated_at',
    ];
}
