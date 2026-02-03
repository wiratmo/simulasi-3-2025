<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Notifications\Notifiable;
use Laravel\Sanctum\HasApiTokens;

class AvailableMonth extends Model
{
    use HasApiTokens, HasFactory, Notifiable;

    protected $hidden = [
        'created_at',
        'updated_at',
        'id',
        'installment_id',
    ];    
}
