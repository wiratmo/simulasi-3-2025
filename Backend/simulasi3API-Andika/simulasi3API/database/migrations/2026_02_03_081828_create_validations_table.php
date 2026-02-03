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
        Schema::create('validations', function (Blueprint $table) {
            $table->id();
            $table->foreignId('society_id')->constrained('societies')->cascadeOnDelete();
            $table->foreignId('validator_id')->nullable()->constrained('validators')->cascadeOnDelete();
            $table->enum('status', ['pending', 'declined', 'accepted'])->default('pending');
            $table->string('job', 255)->nullable();
            $table->text('job_description')->nullable();
            $table->integer('income');
            $table->text('reason_accepted')->nullable();
            $table->text('validator_notes')->nullable();
            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('validations');
    }
};
