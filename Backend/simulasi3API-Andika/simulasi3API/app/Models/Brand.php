<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Brand extends Model
{
    protected $fillable = [
        'brand'
    ];

    protected $hidden = [
        'created_at',
        'updated_at',
    ];
}
