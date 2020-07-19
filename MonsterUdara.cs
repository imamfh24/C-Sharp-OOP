using System;
/*
Monster udara merupakan sebuah subclass dari class Monster, dan merupakan Superclass untuk class MonsterKalelawar
*/
namespace BelajarOOP
{
    /*
    Diclass ini yang merupakan subclass atau class turunan yang mewarisi class monster atau superclass.
    Untuk dapat mewarisi superclass, maka hal yang perlu dilakukan subclass adalah memberikan syntax berikut ini

    class NamaClass : NamaSuperClass

    Memberikan : untuk menandakan bahwa NamaClass merupakan turunan dari NamaSuperClass (Contoh real nya seperti nama anak bin nama ayah)

    */
    public class MonsterUdara : Monster
    {
        public void Terbang(){
            Console.WriteLine("Monster Terbang");
        }
    }
}