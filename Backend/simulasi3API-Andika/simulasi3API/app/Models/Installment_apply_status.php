<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Installment_apply_status extends Model
{
    protected $fillable = [
        'date', 
        'status', 
        'society_id', 
        'installment_id', 
        'available_month_id', 
        'installment_apply_societiy_id', 
    ];

    protected $hidden = [
        'created_at',
        'updated_at',
    ];

    public function installment() {
        return $this->belongsTo(Installment::class, 'installment_id', 'id');
    }
    public function available_month() {
        return $this->belongsTo(Available_month::class, 'available_month_id', 'id');
    }

    public function apply_society() {
        return $this->belongsTo(Installment_apply_society::class, 'installment_apply_societiy_id', 'id');
    }
    public function society() {
        return $this->belongsTo(Society::class, 'society_id', 'id');
    }
}
