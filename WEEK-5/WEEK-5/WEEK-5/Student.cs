using System;
using System.Collections.Generic;
using System.Text;

namespace WEEK_5
{
    public  class Student
    {
        #region
        public static string FullName(string Name, string Surname)
        {
            return $"{Surname} {Name} ";
        }
        public static int Avarage(int Imtahan1, int Imtahan2, int Imtahan3)
        {
            return (Imtahan1 + Imtahan2 + Imtahan3) / 3;
        }
        #endregion
    }
}
