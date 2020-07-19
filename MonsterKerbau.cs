namespace BelajarOOP
/*
Class ini merupakan subclass dari class parent MonsterKerbau
*/
{
    /*
    Diclass ini yang merupakan subclass atau class turunan yang mewarisi class monster atau superclass.
    Untuk dapat mewarisi superclass, maka hal yang perlu dilakukan subclass adalah memberikan syntax berikut ini

    class NamaClass : NamaSuperClass

    Memberikan : untuk menandakan bahwa NamaClass merupakan turunan dari NamaSuperClass (Contoh real nya seperti nama anak bin nama ayah)

    */
    public class MonsterKerbau : MonsterDarat
    {
        /* Dibawah ini merupakan constructor, constructor merupakan method yang dijalankan/inisialisasi pertama ketika sebuah objek dibuat. Untuk Syntaxnya
        public NamaClass(param1, param2 ....){

        }
        */
        public MonsterKerbau(){
            Nyawa = 100;
        }

        /*
        Kata kunci override pada method dibawah ini menandakan bahwa fungsi/method ini merupakan method turunan dari superclass.
        Method yang di override harus memiliki nama dan parameter yang sama dengan Superclass
        */
        public override void Menyerang(){

        }

        /*
        Kata kunci new di method ini merupakan tanda bahwa method ini merupakan method yang sama dengan Superclass, tetapi tidak ditimpa
        New sama dengan istilah overloading, yang mana merupakan fungsi dan parameter yang berbeda dengan superclass tetapi menggunakan nama yang sama
        */
        public new void melarikanDiri(){

        }
    }
}