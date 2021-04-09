using System;

namespace pul_el_cirki
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            * istifadeci bankomatdan cixarmaq istediyi meblegi daxil edir(sonsuz sayda, emeliyyati dayandirmagida nezere alin).
            * daxil edilen meblege uygun console-a eskinaslari sayi ile cap edirik.
            *
            * eskinaslar : 200, 100, 50, 20, 10, 5, 1
            *
            * meselen daxil edilen pul miqdari 45 dir:
            * 2 eded 20 azn
            * 1 eded 5 azn
            *
            */
            #endregion
            int[] Array = { 200, 100, 50, 20, 10, 5, 1 };
            while (true)
            {
                Console.WriteLine("Cixarmaq istdeyiniz meblegi daxil edin :");
                int miqdar = int.Parse(Console.ReadLine());
                if (miqdar > 0)
                {
                    for(int i=0; i < Array.Length; i++)
                    {
                        if (miqdar > Array[i])
                        {
                            continue;
                        }
                        else
                        {
                          int manat= miqdar / Array[i];
                        }
                    }
                }

            }
        }
    }
}
