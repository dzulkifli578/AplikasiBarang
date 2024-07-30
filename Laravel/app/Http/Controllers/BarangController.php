<?php

namespace App\Http\Controllers;

use App\Models\Barang;
use Illuminate\Http\Request;

class BarangController extends Controller
{
    public function TambahBarang()
    {
        $validator = validator(request()->all(), [
            "nama" => "required",
            "harga" => "required",
            "status" => "required"
        ]);
        if ($validator->fails()) {
            return response()->json([
                "error" => $validator->errors()
            ]);
        }

        $barang = Barang::create(request()->all());
        if ($barang) {
            return response()->json([
                "pesan" => "Berhasil menambahkan data barang"
            ]);
        } else {
            return response()->json([
                "error" => "Gagal menambahkan data barang"
            ]);
        }
    }

    public function LihatBarang()
    {
        $barang = Barang::all();
        if ($barang) {
            return response()->json([
                "data" => $barang
            ]);
        } else {
            return response()->json([
                "error" => "Data barang tidak ditemukan"
            ]);
        }
    }

    public function EditBarang()
    {
        $validator = validator(request()->all([
            "id" => "required",
            "nama" => "required",
            "harga" => "required",
            "status" => "required"
        ]));
        if ($validator->fails()) {
            return response()->json([
                "error" => $validator->errors()
            ]);
        }

        $barang = Barang::where("id", request()->id)->update([
            "nama" => request()->nama,
            "harga" => request()->harga,
            "status" => request()->status
        ]);
        if ($barang) {
            return response()->json([
                "pesan" => "Berhasil mengedit data barang"
            ]);
        } else {
            return response()->json([
                "error" => "Gagal mengedit data barang"
            ]);
        }
    }

    public function HapusBarang()
    {
        $validator = validator(request()->all([
            "id" => "required",
        ]));
        if ($validator->fails()) {
            return response()->json([
                "error" => $validator->errors()
            ]);
        }

        $barang = Barang::where("id", request("id"))->delete();
        if ($barang) {
            return response()->json([
                "pesan" => "Berhasil menghapus data barang"
            ]);
        } else {
            return response()->json([
                "error" => "Gagal menghapus data barang"
            ]);
        }
    }

}
