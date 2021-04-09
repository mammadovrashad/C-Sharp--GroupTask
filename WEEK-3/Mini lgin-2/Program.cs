using System;

namespace Mini_lgin_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            /*
            * Istifadeciden role(selahiyyet) isteyerek daxil etdiyi role uygun mesaj verin.
            *
            *  Istifadeci selahiyyeti (I.S) :
            *
            * I.S = AA , BB , CC ise "Admin selahiyyetlerine sahibsiniz."
            * I.S = MM "Moderator selahiyyetlerine sahibsiniz."
            * I.S = MH "Muhasib selahiyyetlerine sahibsiniz."
            * I.S = UU "Standart istifadeci selahiyyetlerine sahibsiniz."
            *
            * qeyd edilenlerden ferqli olarsa : "Daxil edilen selahiyyet dogru deyil"
            *
            * switchden istifade edin.
            */
            #endregion
            #region
            Console.WriteLine("istidaeci selahiyyeti I.S daxil edin :");
            string userAuthority = Console.ReadLine();
            switch (userAuthority)
            {
                case "AA" :
                    Console.WriteLine("Admin selahiyyetlerine sahibsiniz.");
                break;
                case "BB" :
                    goto case "AA";
                case "CC":
                    goto case "AA";
                case "MM":
                    Console.WriteLine("Moderator selahiyyetlerine sahibsiniz.");
                    break;
                case "MH":
                    Console.WriteLine("Muhasib selahiyyetlerine sahibsiniz.");
                    break;
                case "UU":
                    Console.WriteLine("Standart istifadeci selahiyyetlerine sahibsiniz.");
                    break;
                default:
                    Console.WriteLine("Daxil edilen selahiyyet dogru deyil");
                    break;
            }

            #endregion
        }
    }
}
