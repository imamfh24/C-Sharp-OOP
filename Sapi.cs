using System;

// Class sapi untuk belajar Class dan Objek (Field, getter dan setter, method, untuk property lihat class Segi Empat)

namespace BelajarOOP
{
    /*Class dan Objek

    Class merupakan tempat menyediakan sebuah wadah blueprint / rancangan / sketsa  dari sebuah objek. Sebuah class dapat dipanggil di class lain

    Objek merupakan realisasi dari class. Istilahnya class yang telah dibuat dapat direalisasikan atau digunakan

    */
    public class Sapi
    {
        //Field (merupakan kumpulan variabel yang dimiliki oleh class ini) / attribut atau hal-hal yang dimiliki oleh objek class ini
        private string name = "Cow";
        private int legs = 4, age = 0;

        /* Getter dan setter
        
        Getter merupakan sebuah method atau fungsi yang memberikan nilai kembalian(data) pada sebuah field(variabel), untuk penulisan syntax pada sebuah get didalam C# yaitu

        public tipedata getNamaField(){
            return namaField;
        }

        Setter merupakan sebuah method atau fungsi yang memperbarui nilai pada sebuah field, untuk penulisan syntax pada sebuah set didalam C# yaitu

        public void setNamaField(tipedata namaField){
            this.field = field;
        }

        */

        //Getter

        public string getName(){
            return name;
        }

        public int getLegs(){
            return legs;
        }

        public int getAge(){
            return age;
        }

        //Setter
        public void setName(string name){
            this.name = name;
        }

        public void setLegs(int legs){
            this.legs = legs;
        }

        public void setAge(int age){
            this.age = age;
        }

        /* Method
        
        Method(fungsi) merupakan sebuah kumpulan fungsi logika pada sebuah class, istilahnya apa saja yang bisa dilakukan oleh class ini 
        method dapat diakses setelah class ini dijadikan objek
        Membuat sebuah method ada dua cara,

        1. Cara dengan tanpa mengembalikan nilai, syntax nya adalah
        public void namaMethod(parameter1, parameter2 ...){
            Logika
        }

        2. Cara dengan mengembalikan nilai, syntax nya adalah

        public tipedata namaMethod(parameter1, parameter2...){
            return logika
        }

        */

        public void eat(){
            Console.WriteLine(getName() + " is eat right now");
        }

        public void walk(){
            Console.WriteLine(getName() + " is walking");
        }

        public void sleep(){
            Console.WriteLine(getName() + " is sleep right now, shhhh");
        }

    }
}