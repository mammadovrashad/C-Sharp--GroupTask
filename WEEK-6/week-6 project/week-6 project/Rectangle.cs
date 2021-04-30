using System;
using System.Collections.Generic;
using System.Text;

namespace week_6_project
{
    /// <summary>
    /// Duzbucaqlinin hasilini hesablayan Class
    /// </summary>
    class Rectangle
    {
        private int en;
        private int uzunluq;
        public int En
        {
            get
            {
                return en;
            }
            set
            {
                en = value;
            }
        }
        public int Uzunluq
        {
            get
            {
                return uzunluq;
            }
            set
            {
                uzunluq = value;
            }
        }
        public double Hasil=>en*uzunluq;
    }
}
