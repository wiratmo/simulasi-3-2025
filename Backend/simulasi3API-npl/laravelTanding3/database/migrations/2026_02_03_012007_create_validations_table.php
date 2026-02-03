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

            $table->unsignedBigInteger('society_id');
            $table->unsignedBigInteger('validator_id');

            $table->enum('status', ['accepted', 'declined', 'pending']);
            $table->string('job');
            $table->string('job_description');
            $table->integer('income');
            $table->text('reason_accepted');
            $table->text('validator_notes');
            $table->timestamps();

            $table->foreign('society_id')->references('id')->on('societies')->onDelete('cascade');
            $table->foreign('validator_id')->references('id')->on('validators')->onDelete('cascade');
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
