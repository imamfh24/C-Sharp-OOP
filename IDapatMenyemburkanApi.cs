using System;
namespace BelajarOOP
{
    /*
    interface berfungsi sebagai pola/kontrak(kumpulan method/fungsi/property) yang harus dibuat oleh class yang mengimplementasikannya
    */
    public interface IDapatMenyemburkanApi
    {
        // Untuk membuat fungsi pada interface cukup seperti dibawah ini, jika ada parameter tambahkan parameter
         void menyemburkanApi();
    }
}