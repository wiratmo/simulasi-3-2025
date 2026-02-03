<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Notifications\Notifiable;
use Laravel\Sanctum\HasApiTokens;

class InstallmentApplySociety extends Model
{
    use HasApiTokens, HasFactory, Notifiable;

    protected $fillable = [
        'notes',
        'available_month_id',
        'date',
        'society_id',
        'installment_id',
    ];
}
