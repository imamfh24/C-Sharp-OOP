using System;
namespace BelajarOOP
{
    // Class ini merupakan subclass dari sebuah abstract class
    public class AyamImoet : Monster
    {
        public override void Bobo(){
            Console.WriteLine("Ayam imoet lagi bobo");
        }

        public void makanCacing100Tahun(){
            Console.WriteLine("Nyam..Cacing");
        }
    }
}