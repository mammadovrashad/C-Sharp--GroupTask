using System;

namespace switch_calculator
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
            #region
            Console.WriteLine("Cixarmaq istediyiniz meblegi daxil edin :");
            int mebleg = int.Parse(Console.ReadLine());
            Array siyahi = new int[] { 200, 100, 50, 20, 10, 5, 1 };
            for (int i = 0; i < siyahi.Length; i++)
            {
                int manat = (int)siyahi.GetValue(i);
                if (mebleg / manat > 0)
                {
                    int say = mebleg / manat;
                    mebleg = mebleg - manat * say;
                    Console.WriteLine($"{say} eded {manat} manat");

                }


            }

            #endregion
        }
    }
}