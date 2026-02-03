<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Notifications\Notifiable;
use Laravel\Sanctum\HasApiTokens;

class Validation extends Model
{
    use HasFactory, Notifiable, HasApiTokens;

    protected $fillable = [
        'job',
        'job_description',
        'income',
        'reason_accepted',
        'society_id',
        'status',
        'validator_id',
        'validator_notes'
    ];
}
