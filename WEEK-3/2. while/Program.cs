using System;

namespace _2._while
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            // 2. while ile consoledan daxil edilen ededden geriye dogru loop

            #endregion

            #region While
            short eded = Convert.ToInt16(Console.ReadLine());
            while (eded > 0)
            {
                eded--;
                Console.WriteLine(eded);
            }
            #endregion
        }
    }
}
