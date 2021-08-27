using System;

namespace tersine_duzmek
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 3. geriden geriden
            /*
             * asagida verilen arrayin elementlerini tersine duzerek
             * ekrana cap edin
             *
             * qeyd : manual edilecek/ hazir methodlarsiz
             */
            //int[] arr = { 5, 6, 9, 12, 15, 7, 3, 20, 14, 36, 24 };

            #endregion
            #region
            int eded ;
            int[] newArr = new int[11];
            int j = 0;
            int[] arr = { 5, 6, 9, 12, 15, 7, 3, 20, 14, 36, 24 };
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                newArr[j] = arr[i];
                j++;
            }
            foreach (var index in newArr)
            {
                Console.WriteLine(index);
            }
            #endregion

        }
    }
}
