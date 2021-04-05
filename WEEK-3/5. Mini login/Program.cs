using System;

namespace _5._Mini_login
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

            #region if aperatoru
            while (true) {
                Console.WriteLine("Istifadeci adini daxil edin :");
                string userName = Console.ReadLine();
                Console.WriteLine("Sifrenizi  daxil edin :");
                string password = Console.ReadLine();
                if (userName is null)
                {
                    Console.WriteLine("Istifadeci adi bos ola bilmez !");
                }
                else if (password is null)
                {
                    Console.WriteLine("password hisse bos ola bilmez !");
                }
                else if(userName is null && password is null)
                {
                    Console.WriteLine("istifadeci adi ve sifre bos ola bilmez !");
                }
                else if (userName == "admin" && password == "6gH123")
                {
                    Console.WriteLine("Welcome to page again");
                }
                else
                {
                    Console.WriteLine("istifadeci adi ve ya sifre uygun deyil ! zehmet olmasa yeniden daxil edin :");
                }
            }
            #endregion

        }
    }
}
