using System;

class Program
{
    static void Main()
    {
        // Konstanta biaya administrasi tetap
        const int BIAYA_ADMIN = 2000;
        const int hargaPerHalaman = 500;

        // Input data dari pengguna
        Console.Write("Masukkan nama pelanggan: ");
        string namaPelanggan = Console.ReadLine();

        Console.Write("Masukkan nama dokumen: ");
        string namaDokumen = Console.ReadLine();

        Console.Write("Masukkan jumlah halaman: ");
        int jumlahHalaman = Convert.ToInt32(Console.ReadLine());

          // Proses perhitungan
        int subtotal = jumlahHalaman * hargaPerHalaman;
        int totalBayar = subtotal + BIAYA_ADMIN;

        // Output rincian pencetakan
        Console.WriteLine("\n=== RINCIAN PENCETAKAN ===");
        Console.WriteLine($"Nama pelanggan = {namaPelanggan}");
        Console.WriteLine($"Nama dokumen = {namaDokumen}");
        Console.WriteLine($"Jumlah halaman = {jumlahHalaman}");
        Console.WriteLine($"Harga per halaman = {hargaPerHalaman}");
        Console.WriteLine($"Subtotal = {subtotal}");
        Console.WriteLine($"Biaya administrasi = {BIAYA_ADMIN}");
        Console.WriteLine($"Total bayar = {totalBayar}");
    }
}