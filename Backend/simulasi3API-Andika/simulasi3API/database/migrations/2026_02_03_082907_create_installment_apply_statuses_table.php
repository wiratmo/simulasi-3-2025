<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('installment_apply_statuses', function (Blueprint $table) {
            $table->id();
            $table->foreignId('available_month_id')->constrained('available_months')->cascadeOnDelete();
            $table->foreignId('society_id')->constrained('societies')->cascadeOnDelete();
            $table->foreignId('installment_id')->constrained('installments')->cascadeOnDelete();
            $table->foreignId('installment_apply_societiy_id')->constrained('installment_apply_societies')->cascadeOnDelete();
            $table->date('date');
            $table->enum('status', ['pending', 'accepted', 'rejected']);
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('installment_apply_statuses');
    }
};
