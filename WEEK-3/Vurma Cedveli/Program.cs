using System;

namespace Vurma_Cedveli
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 8. vurma cedveli
            /*
             * vurma cedveli hazirlayin. (12 vereqli defeterlerin arxasindaki gorunuse sahib olsun.)
             * 
             * netice asagidaki kimi olsun
             *
             * 1 * 1 = 1   1 * 2 = 2  1 * 3 = 3 // belece davam edir
             * 2 * 1 = 2   2 * 2 = 4  2 * 3 = 6
             * 
             */
            #endregion
            #region vurma cedveli
            for(int i=1; i<=10; i++)
            {
                for(int j = 1; j <=10; j++)
                {
                    Console.Write($"{i}*{j}={i*j}\t");
                }
                Console.WriteLine("");
            }
            #endregion
        }
    }
}
