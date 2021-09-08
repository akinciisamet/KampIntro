using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici kursu";
            string kurs2 = "Kamp hazırlık kursu";
            string kurs3 = "java";
            string kurs4 = "pyhton";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);


            //array
            string[]kurslar=new string[] { "Yazılım geliştirici kursu" , "Kamp hazırlık kursu", "java","phyton","C++"};

                            
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu -- footer");
        }
    }
}
