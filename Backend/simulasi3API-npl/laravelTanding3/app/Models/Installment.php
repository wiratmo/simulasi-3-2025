<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Notifications\Notifiable;
use Laravel\Sanctum\HasApiTokens;

class Installment extends Model
{
    use HasApiTokens, HasFactory, Notifiable;

    protected $fillable = [
        'brand_id',
        'cars',
        'description',
        'price',
        ''
    ];

    protected $hidden = [
        'created_at',
        'updated_at',
    ];

    public function availableMonth()
    {
        return $this->belongsTo(AvailableMonth::class, 'id', 'installment_id');
    }

    public function applications()
    {
        return $this->hasMany(InstallmentApplySociety::class, 'installment_id', 'id');
    }
}
