using System;

namespace Bal_Ortalamasinin_Hesablanmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
                 * 1. Istifadeciden gelen 3 ferqli imtahan neticelerinin
                 * ortalamasinin 45-den  boyuk ve ya beraber olmasini
                 * yoxlayin.
                 *
                 * qeyd : if else istifade etmeyin burada
                 * 
                 * netice asagidaki kimi olmalidir.
                 *
                 *
                 * Netice : 30
                 * Netice : 50
                 * Netice : 40
                 *
                 *
                 * "Ortalama 45-e beraber ve ya boyukdurmu?" : "40"(Ortalamadir) : Beli ve ya Xeyr
                 */
            #endregion

            #region Bal ortalamasinin  hesablanmasi

            short netice1 = short.Parse(Console.ReadLine());
            short netice2 = short.Parse(Console.ReadLine());
            short netice3 = short.Parse(Console.ReadLine());
            string result = (netice1 + netice2 + netice3) / 3 is 45 ? "beraberdir" : "beraber deyil";
            Console.WriteLine(result);
            Console.ReadLine();

            #endregion
        }
    }
}
