<?php

use App\Http\Controllers\BarangController;
use Illuminate\Support\Facades\Route;

Route::get('/', function () {
    return view('welcome');
});

Route::post("tambahbarang", [BarangController::class, "TambahBarang"]);
Route::get("lihatbarang", [BarangController::class, "LihatBarang"]);
Route::put("editbarang", [BarangController::class, "EditBarang"]);
Route::delete("hapusbarang", [BarangController::class, "HapusBarang"]);