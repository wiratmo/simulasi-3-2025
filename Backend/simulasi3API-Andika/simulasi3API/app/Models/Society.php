<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;
use Laravel\Sanctum\HasApiTokens;

class Society extends Model
{
    use HasApiTokens;
    protected $fillable = [
        'id_card_number',
        'password',
        'name',
        'born_date',
        'gender',
        'address',
        'regional_id',
        'login_tokens',
    ];

    protected $hidden = [
        'created_at',
        'updated_at',
    ];

    public function regional() {
        return $this->belongsTo(Regional::class, 'regional_id', 'id');
    }
}
