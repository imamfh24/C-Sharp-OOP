using System;

namespace BelajarOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Berikut ini cara memanggil sebuah class / membuat variabel untuk menyimpan class (NamaClass namaVariabel)
            Sapi sapi;

            // Cara membuat objek sapi dari class yang telah diinisialisasi, ambil nama variabel nya (namaVariabel = new NamaClass();)
            sapi = new Sapi(); // Dengan ini objek sapi telah dibuat dengan nama sapi

            //Mengakses field dan method serta setter dan getter pada class sapi ketika objek telah dibuat

            /*Mengakses field tidak bisa dilakukan karena hak akses dibuat private, untuk dapat diakses maka perlu dibuat public / static
            
            cara mengakses field yaitu
            sapi.namaField

            Field ini perlu disimpan pada sebuah variabel apabila ingin mengambil datanya, misal

            String sapi = sapi.namaField;

            */

            /*  Mengakses method
            Untuk mengakses sebuah method, syntax nya adalah
            namaObjek.namaMethod();
            Jika sebuah method memiliki parameter, maka method perlu diisi dengan parameter yang terkait, maka penulisan syntax nya
            namaObjek.namaMethod(tipedata param1, tipedata param2, ...);
            */

            sapi.eat();
            sapi.walk();
            sapi.sleep();

            /* Getter dan Setter
            
            Untuk menggunakan getter dan setter, sama seperti mengakses method.
            Untuk setter syntaxnya adalah
            namaObjek.setNamaField(param);
            namaObjek.getNamaField();
            */

            //Setter
            sapi.setName("Cowboy");
            // Getter
            Console.WriteLine("Use Getter " + sapi.getName());

            //Akses semua getter
            System.Console.WriteLine("My cow " + sapi.getName() + " is " + sapi.getAge() + " years old and it have " + sapi.getLegs() + " legs");


            // --- Menggunakan Property ---
            
            // Buat objek segiempat
            SegiEmpat segiEmpat = new SegiEmpat();

            // Menginisialisasi nilai property dengan cara
            segiEmpat.Panjang = 10;
            segiEmpat.Lebar = 5;

            //Hasil hitung segiempat
            Console.WriteLine("Luas = " + segiEmpat.hitungLuasPersegiPanjang() + "\nKeliling = " + segiEmpat.hitungKelilingPersegiPanjang());
        }
    }
}
