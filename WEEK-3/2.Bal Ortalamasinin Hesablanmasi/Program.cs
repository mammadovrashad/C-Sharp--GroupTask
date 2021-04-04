using System;

namespace _2.Bal_Ortalamasinin_Hesablanmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
           * 2.Bal Ortalamasinin Hesablanmasi
           *
           * istifadeciden ad ve soyadini ,
           *  4 eded imtahan neticesini daxil etmesini isteyirik.
           *
           * netice asagidaki kimi olmalidir
           *
           * Ad ve Soyad : Parviz Aliyev
           *
           * Netice : 50
           * Netice : 40
           * Netice : 30
           * Netice : 20
           *
           * Ortalama : 35
           */
            #endregion

            #region 2.Bal Ortalamasinin Hesablanmasi
            Console.WriteLine("Ad ve Soyadinizi daxil edin :");
            string fullName = Console.ReadLine();
            short netice1 = short.Parse(Console.ReadLine());
            short netice2 = short.Parse(Console.ReadLine());
            short netice3 = short.Parse(Console.ReadLine());
            short netice4 = short.Parse(Console.ReadLine());
            Console.WriteLine(fullName +  "  ortalama bal :"+ (netice1 + netice2 + netice3 + netice4));
            #endregion
        }
    }
}
