using System;

namespace menfi_musbet_ternery
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            * Daxil edilen ededin menfi ve ya musbet oldugunu yoxlayin ona uygun geriye deyer qaytarin.
            *
            * qeyd: if ve ternary istifade edin ayri ayri
            */
            #endregion
            #region
            while (true)
            {
                Console.WriteLine("Eded daxil edin. :");
                var number = Console.ReadLine();
                if (number.StartsWith("-"))
                    Console.WriteLine("menfi eded-dir.");
                else if (number == "0")
                    Console.WriteLine("eded 0 ola bilmez !");
                else
                    Console.WriteLine("Menfi deyil");

            }

            #endregion

        }
    }
}
