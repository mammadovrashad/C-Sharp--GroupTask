using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
 namespace WEEK_5
{
  public  class Atm
    {
       
        public static void Menu()
        {
            Console.WriteLine("Secim edin :\n");
            Console.WriteLine(" 1 reqemi Balansi yoxlamaq ucundur:");
            Console.WriteLine(" 2 reqemi Negd pul cixarmaq ucundur:");
            Console.WriteLine(" 3 reqemi  Umumi hesabdan cixaris ucundur:\n");
            
        }
        public static string Pin(string pin)
        {
            if (pin.Length is 4)
            {
               if(int.TryParse(pin, out int deyer))
                {
                    if (deyer is 1234)
                    {
                        Menu();
                        return $"sizin sifreniz {pin} olaraq dogrudur";
                    }
                    else
                    {
                        return $"daxil etdiyiniz pin yalnisdir !";
                    }
                }
                else
                {
                    return $"Pin yalniz reqem olmaldir !";
                }
            }
            else
            {
                return $"Pin 4 reqemden ibaret olmaldir !";
            }
        }
        public static int Switch(int nomre)
        {
            ArrayList vaxt = new ArrayList();
            switch (nomre)
            {
                case 1:
                    Console.WriteLine("hazirda balansinizda 1000 AZN movcuddur");
                    break;
                case 2:
                    Console.WriteLine("Cixarmaq istediyiniz meblegi daxil edin :");
                    int mebleg = int.Parse(Console.ReadLine());
                    Console.WriteLine( Cixaris(mebleg));
                    break;
                case 3:
                    if (vaxt is null)
                    {
                        Console.WriteLine("siz indiyedek hesabdan cixaris etmeyibsiniz :");
                    }
                    else {
                        foreach (var items in vaxt)
                        {
                            Console.WriteLine(items);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("daxil etdiyiniz simvol Menu-ya uygun deyil !:");
                    break;
            }
            return nomre;
           
        }
        public static int Cixaris(int mebleg)
        {
            #region
            int pul = mebleg;
            ArrayList vaxt = new ArrayList();
            Array siyahi = new int[] { 200, 100, 50, 20, 10, 5, 1 };
            for (int i = 0; i < siyahi.Length; i++)
            {
                int manat = (int)siyahi.GetValue(i);
                if (mebleg / manat > 0)
                {
                    int say = mebleg / manat;
                    mebleg = mebleg - manat * say;
                    Console.WriteLine($"{say} eded {manat} manat");
                    DateTime zaman = DateTime.Now;
                    vaxt.Add(zaman);
                }
               
            }
            
            Console.WriteLine("balansinizda qalan pul :");
            return 1000-pul;
            #endregion
        }


    }
}
