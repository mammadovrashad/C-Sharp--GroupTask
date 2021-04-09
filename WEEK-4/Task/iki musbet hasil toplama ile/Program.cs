using System;

namespace iki_musbet_hasil_toplama_ile
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 7.
            /*
             * istifadeci terefinden daxil edilen iki musbet ededin hasilini vurma emeliyyati ile
             * deyil toplama emeliyyati ile ekrana cap edin.
             */
            #endregion
            #region
            Console.WriteLine("eded1-i daxil edin :");
            double eded1 = double.Parse(Console.ReadLine());

            Console.WriteLine("eded2-ni daxil edin :");
            double eded2 = double.Parse(Console.ReadLine());
            double s=0;
            if (eded2 > 0 && eded1 > 0)
            {
                for (int i = 0; i < eded2; i++)
                {
                    s = s + eded1;
                }
                    
            }
            else
            {
                Console.WriteLine("eded menfi ve ya 0 ola bilmez");
            }
            Console.WriteLine(s);

        }
        #endregion
    }
}
