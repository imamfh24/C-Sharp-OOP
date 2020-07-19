using System;

/* Class monster ini digunakan sebagai Superclass.
Superclass merupakan classparent
*/

namespace BelajarOOP
{
    public class Monster
    {
        private int _nyawa;

        public int Nyawa {
            get {
                return _nyawa;
            }
            set{
                _nyawa = value;
            }
        }

        /*
        Virtual dibawah ini merupakan tanda bahwa method ini dapat dilakukan pewarisan/override oleh kelas lain.
        Untuk itu di class lain perlu menuliskan method dibawah ini dengan sama, akan tetapi di subclass perlu ditulis override. Berikut syntaxnya

        - Untuk Virtual
        public virtual namaMethod(){

        }

        - Untuk Override
        public override void namaMethod(){
            
        }
        */
        public virtual void Menyerang(){
            Console.WriteLine("Monster Menyerang");
        }

        public void melarikanDiri(){
            Console.WriteLine("Monster melarikan diri");
        }
    }
}