using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
             //type safety-- tip güvenliği.
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun > dolarBugun) 
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarlrı butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.ReadLine();
        }
    }
}
