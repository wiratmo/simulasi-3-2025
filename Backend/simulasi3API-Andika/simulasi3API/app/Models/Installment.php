<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Installment extends Model
{
    protected $fillable = [
        'brand_id',
        'cars',
        'description',
        'price',
    ];

    protected $hidden = [
        'created_at',
        'updated_at',
    ];

    public function brand() {
        return $this->belongsTo(Brand::class, 'brand_id', 'id');
    }
    public function available_months() {
        return $this->hasMany(Available_month::class, 'installment_id', 'id');
    }
}
