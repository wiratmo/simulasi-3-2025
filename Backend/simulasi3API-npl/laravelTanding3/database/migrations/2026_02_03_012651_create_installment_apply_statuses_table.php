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
            $table->date('date');

            $table->unsignedBigInteger('society_id');
            $table->unsignedBigInteger('installment_id');
            $table->unsignedBigInteger('available_month_id');
            $table->unsignedBigInteger('installment_apply_society_id');

            $table->enum('status', ['pending', 'accepted', 'rejected']);
            $table->timestamps();

            $table->foreign('society_id')->references('id')->on('societies')->onDelete('cascade');
            $table->foreign('installment_id')->references('id')->on('installments')->onDelete('cascade');
            $table->foreign('available_month_id')->references('id')->on('available_months')->onDelete('cascade');
            $table->foreign('installment_apply_society_id')->references('id')->on('installment_apply_societies')->onDelete('cascade');
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
