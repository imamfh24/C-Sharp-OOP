using System;
namespace BelajarOOP
{
    /*
    Class ini merupakan subclass dari ayamimoet, dan mengimpelemtasikan interface IDapatMenyemburkanApi
    Jika menggunakan interface, maka method yang ada didalam interface tersebut semuanya harus diimplementasikan
    */
    public class AyamApi : AyamImoet, IDapatMenyemburkanApi
    {
        public override void Bobo() {
            Console.WriteLine("Ayam api sedang tidor...");
        }

        public void menyemburkanApi(){
            Console.WriteLine("Katon...Gookyu No Jutsu");
        }
    }
}