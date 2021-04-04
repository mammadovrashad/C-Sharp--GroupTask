using System;

namespace _3.Bal_Ortalamasinin_Hesablanmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            /*
            * 3.Bal Ortalamasinin Hesablanmasi
            *
            * istifadeciden ad ve soyadini ,
            *  4 eded imtahan neticesini daxil etmesini isteyirik.
            *
             *
             * ortalama 45-den kicikdirse : qeyri-kafi Kece bilmediz
             * ortalama 45-e beraber ve ya 70-den  kicikdirse :  Meqbul
             * ortalama 70-e beraber ve ya 90-dan  kicikdirse :  Yaxsi
             * ortalama 90 ile  100 arasinda (100-de daxil) :  Ela
             *
             * qeyd : ortalama 100-den boyuk ola bilmez.
             *
            * netice asagidaki kimi olmalidir.
            *
            * Ad ve Soyad : Parviz Aliyev
            *
            * Netice : 50
            * Netice : 40
            * Netice : 30
            * Netice : 20
            *
            * Ortalama : 35
            * Semestr Yekunu : qeyri-kafi Kece bilmediz
            */
            #endregion

            #region 3.Bal Ortalamasinin Hesablanmasi

            Console.WriteLine("Ad ve Soyadinizi daxil edin :");
            string fullName = Console.ReadLine();
            short netice1 = short.Parse(Console.ReadLine());
            short netice2 = short.Parse(Console.ReadLine());
            short netice3 = short.Parse(Console.ReadLine());
            short netice4 = short.Parse(Console.ReadLine());
            int ortalama = (netice1 + netice2 + netice3 + netice4) / 4;
            if (ortalama < 45)
            {
                Console.WriteLine("qeyri-kafi Kece bilmediz");
            }
            else if(ortalama == 45 || ortalama < 70)
            {
                Console.WriteLine("Meqbul");
            }
            else if (ortalama == 70 || ortalama < 90)
            {
                Console.WriteLine("Yaxsi");
            }
            else if (ortalama >90 && ortalama <=100)
            {
                Console.WriteLine("Ela");
            }
            else
            {
                Console.WriteLine("ortalama 100-den boyuk ola bilmez.");
            }
            #endregion
        }
    }
}
