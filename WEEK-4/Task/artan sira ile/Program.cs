using System;

namespace artan_sira_ile
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.
            /*
             * asagida verilen arrayin elementlerini artan sira ile
             * ekrana cap edin
             *
             * qeyd : manual edilecek/ hazir methodlarsiz
             */
            //int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };

            #endregion

            #region
            int eded;
            int[] intArray = { 2, 9, 4, 3, 5, 1, 7 };
            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] > intArray[j])
                    {
                        eded = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = eded;

                    }
                }
                Console.WriteLine(intArray[i]);

            }
            #endregion
        }
    }
}
