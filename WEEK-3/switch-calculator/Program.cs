using System;

namespace switch_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 6. calculator : switch
            /*
             * switch istifade ederek calculator yazin
             *
             * qeyd: hem normal switchden istifade edin hem de expressionla olan variantla
             */
            #endregion
            #region
            while (true)
            {
                Console.WriteLine("----Menu-----");
                Console.WriteLine("1- Toplama:");
                Console.WriteLine("2- Cixma:");
                Console.WriteLine("3- Vurma:");
                Console.WriteLine("4- Bolme:");
                string warning = "duzgun emeliyyat nomresidaxil et";
                Console.WriteLine("birinci ededi  daxil edin :");
                double number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("ikinci  ededi  daxil edin :");
                double number2 = int.Parse(Console.ReadLine());
                Console.WriteLine("emeliyyat nomresini  daxil edin :");
                byte calculation = byte.Parse(Console.ReadLine());
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

        
            #endregion
        }
    }
}
