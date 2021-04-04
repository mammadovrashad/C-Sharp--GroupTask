using System;

namespace _4._while
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //4. while ile faktorialin hesablanmasi
            #endregion

            #region While Faktorial
            short faktorial = short.Parse(Console.ReadLine());
            var result= faktorial == default || faktorial == 1 ? "netice 1":"";
            int i = 2;
            int s = 1;
            while (i<faktorial)
            {
                   s = s*i;
                   i++;
            }
            Console.WriteLine(s);
            #endregion
        }
    }
}
