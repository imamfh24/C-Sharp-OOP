using System;
/*
Dibagian ini akan mempelajari tentang
• Inheritance (Pewarisan)
• Polymorphism (Banyak Bentuk)
• Constructor (Konstruktor)
• Keyword New, Virtual, Override
*/
namespace BelajarOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster[] monsters = new Monster[3];
            monsters[0] = new MonsterGurita();
            monsters[1] = new MonsterKalelawar();
            monsters[2] = new MonsterKerbau();

            for (int i = 0; i < monsters.Length; i++)
            {
                if(monsters[i] is MonsterKerbau)(monsters[i] as MonsterKerbau).Berjalan(); else monsters[i].Menyerang();
            }
        }
    }
}