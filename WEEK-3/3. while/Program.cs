using System;

namespace _3._while
{
    class Program
    {
        static void Main(string[] args)
        {
            #region

            // 3. while ile 0 ile 100 arasindaki tek ededlerin cemi

            #endregion

            #region
            Console.WriteLine("baslangic ededi daxil edin :");
            short firstNumber = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("sonuncu ededi daxil edin :");
            short endNumber = Convert.ToInt16(Console.ReadLine());

            int i = firstNumber;
            int s = default;
            while (i < endNumber) 
            {
                if (i % 2 == 1)
                {
                    s = s + i;
                }
                i++;
            }
            Console.WriteLine($"{firstNumber} ile {endNumber} araligindaki tek ededlerin cemi {s} -dir");
            #endregion
        }
    }
}
