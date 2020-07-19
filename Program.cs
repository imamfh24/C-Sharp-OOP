using System;
using System.Collections.Generic;
/*
Dibagian ini akan mempelajari tentang
• Abstract Class
• Interface
*/

/*
Abstract class dapat:
1. Menjadikan sebuah class sebagai pola/kontrak yang harus dipenuhi oleh class-class turunannya.
2. Mencegah adanya pembuatan objek dari sebuah class pola tersebut.
3. Membiarkan method/property yang masih belum diketahui implementasinya untuk tetap kosong(tanpa kode program) sekaligus mengharuskan setiap class turunan memberikan implementasinya(dengan cara menimpanya/override)
*/

/*
Hal mengenai interface
1. Sebuah class dapat meng-implement lebih dari 1 buah interface, tetapi hanya dapat menjadi turunan dari sebuah class saja
2. Interface tidak memiliki field. Hanya memiliki prototype method
3. Interface tidak memiliki access identifier (semuanya otomatis public)
4. Penamaan interface sama dengan class (Huruf pertama pada tiap katanya menggunakan huruf kapital). Nama interface didahului dengan huruf I yang menandakan bahwa ia bukan sebuah class melainkan sebuah interface
*/

/*
Hal yang perlu diingat
1. Virtual method/property boleh ditimpa atau dioverride oleh subclass
2. Abstract method/property harus ditimpa oleh class anak/child
3. method/property pada interface harus dibuat atau diimplementasikan didalam class yang mengimplementasikan interface tersebut
*/

/*
Perbedaan Abstract dan Interface
1. Abstract class: dapat berisi field, property, dan method
Interface: hanya berisi prototipe method/property saja.

2. Abstrac class: access identifier dari tiap member dapat beragam (public, private, protected)
Interface: tidak memiliki acess identifier atau default nya adalah public (otomatis public)

3. Abstract class: class anak atau subclass harus menimpa abstrac method/property yang terdapat pada abstract class
Interface: class anak atau subclass harus membuat method/property yang terdapat pada interface

4. Abstract class: sebuah class hanya dapat menjadi turunan dari 1 buah abstract class saja
Interface: sebuah class dapat meng-implementasikan lebih dari 1 interface
*/
namespace BelajarOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class monster tidak dapat dibuat objek nya karena class tersebut merupakan class abstract
            // Monster monster = new Monster();

            // Monster monster = new NagaPerkasa();
            // AyamImoet ayamImoet = new AyamImoet();

            // monster.Bobo();
            // ayamImoet.Bobo();

            // Membuat list yang merupakan collection
            List<Monster> monsters = new List<Monster>();

            // Menambahkan anggota list
            monsters.Add(new NagaPerkasa());
            monsters.Add(new AyamImoet());
            monsters.Add(new AyamApi());

            foreach (var monster1 in monsters) // Melakukan perulangan untuk setiap anggota list
            {
                // Memeriksa apakah termasuk objek yang dapat menyemburkan api
                if(monster1 is IDapatMenyemburkanApi) (monster1 as IDapatMenyemburkanApi).menyemburkanApi();
            }
            
        }
    }
}