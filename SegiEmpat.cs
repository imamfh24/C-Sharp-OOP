using System;

// Class ini untuk belajar property

namespace BelajarOOP
{
    public class SegiEmpat
    {
        /*
        Property merupakan sebuah variabel, akan tetapi property memiliki fungsi getter dan setter sehingga property berbeda dengan variabel biasa
        Untuk mendeklarasikan property awalnya dibuat terlebih dahulu sebuah variabel dengan garis bawah diawal, berikut syntaxnya
        
        private tipedata _namavariabel;

        Setelah membuat syntax tersebut baru kita buat menjadi property dengan syntax berikut

        public double NamaVariabel{
            get {
                return logika
            }
            set{
                logika
            }
        }

        Property ini mirip dengan variabel di kotlin
        
        */

        //Inisialisasi Variabel untuk tempat menyimpan data getter dan setter
        private double _panjang;
        private double _lebar;

        //Membuat Property
        public double Panjang{
            get{
                return _panjang;
            }
            set{
                _panjang = value > 0 ? value : 1;
            }
        }

        public double Lebar{
            get{
                return _lebar;
            }
            set{
                _lebar = value > 0 ? value : 1;
            }
        }

        //Method

        public double hitungLuasPersegiPanjang(){
            return Panjang * Lebar;
        }

        public double hitungKelilingPersegiPanjang(){
            return 2 * (Panjang + Lebar);
        }

    }
}