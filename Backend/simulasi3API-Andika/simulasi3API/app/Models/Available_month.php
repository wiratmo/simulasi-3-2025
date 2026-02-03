<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Available_month extends Model
{
    protected $fillable = [
        'installment_id',
        'description',
        'month',
        'nominal',
    ];

    protected $hidden = [
        'created_at',
        'updated_at',
    ];
}
