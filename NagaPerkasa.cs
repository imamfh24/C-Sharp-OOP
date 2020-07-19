using System;

namespace BelajarOOP
{
    // Class ini merupakan subclass dari sebuah abstract class
    public class NagaPerkasa : Monster, IDapatMenyemburkanApi
    {
        // Method dibawah ini harus dibuat karena kelas ini mengimplementasi superclass yang mana superclass adalah class abstract
        public override void Bobo(){
            Console.WriteLine("Naga sedang tidoor");
        }

        public void menyemburkanApi(){
            Console.WriteLine("Katon..Gokakyu No Jutsu");
        }

        public void Terbang(){
            Console.WriteLine("Terbang dulu guys...");
        }
    }
}