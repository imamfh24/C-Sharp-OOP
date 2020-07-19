using System;
/*
Monster darat merupakan sebuah subclass dari class Monster, dan merupakan Superclass untuk class MonsterKerbau
*/
namespace BelajarOOP
{
    /*
    Diclass ini yang merupakan subclass atau class turunan yang mewarisi class monster atau superclass.
    Untuk dapat mewarisi superclass, maka hal yang perlu dilakukan subclass adalah memberikan syntax berikut ini

    class NamaClass : NamaSuperClass

    Memberikan : untuk menandakan bahwa NamaClass merupakan turunan dari NamaSuperClass (Contoh real nya seperti nama anak bin nama ayah)

    */
    public class MonsterDarat : Monster
    {
        public void Berjalan(){
            Console.WriteLine("Monster Darat Berjalan");
        }
        
        public override void Menyerang() {
            
        }
    }
}