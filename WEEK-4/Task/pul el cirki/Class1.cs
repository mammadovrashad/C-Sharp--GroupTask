using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    class Class1
    {
        public static void result(byte calculation,double number1,double number2)
        {
            #region
            while (true)
            {
                Console.WriteLine("----Menu-----");
                Console.WriteLine("1- Toplama:");
                Console.WriteLine("2- Cixma:");
                Console.WriteLine("3- Vurma:");
                Console.WriteLine("4- Bolme:");
                string warning = "duzgun emeliyyat nomresidaxil et";
                calculation = byte.Parse(Console.ReadLine());
                var result = calculation switch
                {
                    1 => Convert.ToString(number1 + number2),
                    2 => Convert.ToString(number1 - number2),
                    3 => Convert.ToString(number1 * number2),
                    4 => Convert.ToString(number1 / number2),
                    _ => warning
                };
                Console.WriteLine(result);
            }
            result(2,4,6);

            #endregion
        }
    }
}
