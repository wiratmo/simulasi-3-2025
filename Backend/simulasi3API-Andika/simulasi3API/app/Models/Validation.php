<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Validation extends Model
{
    protected $fillable = [
        'society_id',
        'validator_id',
        'status',
        'job',
        'job_description',
        'income',
        'reason_accepted',
        'validator_notes',
    ];

    protected $hidden = [
        'created_at',
        'updated_at',
    ];
}
