using System;

namespace tek_ededlerin_kub_cemi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 5. tek ededlerin kublari cemi
            /*
             * 1-10 qeder tek ededlerin kublarinin cemini yazin.
             */
            #endregion
            #region
            double s = 0;
            int eded;
            string  arrayElement = Console.ReadLine();
            var Array=arrayElement.Split(' ');
            for(int i = 0; i < Array.Length; i++)
            {
                eded = int.Parse(Array[i]);
                if(eded%2 is 0 ){
                    continue;
                }
                else
                {
                    s+= Math.Pow(eded, 3);
                }
            }
            Console.WriteLine(s);
            #endregion

        }
    }
}
