<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Installment_apply_society extends Model
{
    protected $fillable = [
        'notes', 
        'available_month_id', 
        'date', 
        'society_id', 
        'installment_id', 
    ];

    protected $hidden = [
        'created_at',
        'updated_at',
    ];

    public function month() {
        return $this->belongsTo(Available_month::class, 'available_month_id', 'id');
    }
}
