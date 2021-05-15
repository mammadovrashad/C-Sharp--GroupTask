using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace week_6_project
{/// <summary>
/// Product istehsal edir
/// </summary>
    class Productcs
    {
        
        public static double result;
        public static double total;
        private static double mebleg;

        private string bravokart="Yoxdur";
        private string odenis = "Negd";
        public string Odenis
        {
            get
            {
                return odenis;
            }
            set
            {
                if (OdenisNovu(value))
                {
                    Hesabla();
                    mebleg=result- (this.Miqdar * this.Qiymet) *this.Edv*0.15;
                }
                else
                {
                    Hesabla();
                    mebleg = result - (this.Miqdar * this.Qiymet) *this.Edv * 0.1;
                }
            }
        }
        public string BravoKart
        {
            get
            {
                return bravokart;
            }
            set
            {
                    if (BravoCart(value))
                    {
                    bravokart = value;
                    Hesabla();
                    total = mebleg - mebleg * 0.02;
                    
                }
                else
                {
                    Hesabla();
                    total = mebleg;
                }
            }
        }
        public string Name { get; set; }
        public int Miqdar  { get; set; }
        public double Qiymet { get; set; }
        public double Edv { get; set; } = 0;

        #region Bu method bravoKartin olub olmamasini yoxlayir
        private static bool BravoCart(string deyer)
        {
            if (deyer.ToUpper() == "VAR")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Bu method mehsul ucun odenilecek meblegi hesablayir
        private void Hesabla()
        {
            if (Edv > 0)
            {
                result = (this.Miqdar * this.Qiymet) + (this.Miqdar * this.Qiymet) * this.Edv;
            }
            else
            {
                result = (this.Miqdar * this.Qiymet);
            }
        }
        private static bool OdenisNovu(string odenis)
        {
            if (odenis.ToUpper() == "Negd")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}
