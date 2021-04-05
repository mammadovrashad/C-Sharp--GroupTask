using System;

namespace Mini_login_ternery
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
             * Username ve password deye deyisenler teyin edin.
             *
             *  Username : admin
             *  Password : 6gH123
             *
             * Istifadeciden  username ve Password daxil etmesini isteyin.
             *
             * Daxil edilen username ve passwordun teyin edilen
             * deyisenlerin deyerine beraber olub olmamasini yoxlayin,
             *
             * Netice olaraq login emeliyyatinin ugurlu ve ya
             *
             *  daxil edilen username ve ya sifrenin dogru olmadigi mesajini verin.
             *
             * ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
             *  qeyd: eyni taski, if, ternary operator ve switch ile yazin
             *
             */
            #endregion
            while (true)
            {
                Console.WriteLine("Istifadeci adini daxil edin :");
                string userName = Console.ReadLine();
                Console.WriteLine("Sifrenizi  daxil edin :");
                string password = Console.ReadLine();
                var result = (userName == "admin" && password == "6gH123") ? "welcome to page again" : "istifadeci adi ve ya sifre dogru deyil !";

            }
        }
    }
}
