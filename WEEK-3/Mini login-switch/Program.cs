using System;

namespace Mini_login_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Istifadeci adini daxil edin :");
                string userName = Console.ReadLine();
                Console.WriteLine("Sifrenizi  daxil edin :");
                string password = Console.ReadLine();
                bool True = userName == "admin" && password == "6gH123";
                switch (True)
                {
                    case true:
                        Console.WriteLine("welcome to Page again");
                    break;
                    default:
                        Console.WriteLine("istifadeci adi ve ya sifre dogru deyil");
                    break;
                }
            }
        }
    }
}
