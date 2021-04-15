using System;

namespace WEEK_5
{
    class Program
    {
       static void Main(string[] args)
        {
            #region 1. Havada bulut dimplom isini unut
            /*
             * Telebinin adini soyadini 3 imtahan neticesini
             * (((her hansisa imtahan neticesi daxil edilmezse default deyer 51 verilecek,
             * daxil edilen imtahan neticeleri0-dan kicik 100-den boyuk ola bilmez,
             * eded yerine simvol ve sair daxil edilen zaman xeta mesaji cixmalidir, yeniden emeliyyati duzgun yerine yetirerek davam etmelidir))) daxil edib,
             * ortalamasini hesablayaraq console-da  adi,soyadi, imtahan neticeleri,
             * ortalamasi, Diplom isine dusub dusmediyi yazilacaq(((bunun ucun ortalama 81den boyuk ve ya beraber olmalidir))).
             *
             * Taski mumkun derece kicik methodlara bolerek her methoda verilen adi ehtiva eden isler gorulsun.
             * Student classi yaradaraq method-lari orada yazib Program classi icerisinde Main methodunda istifade edeceksiz.
             *  
             */

            #endregion
            #region 
            while (true)
            {
                {
                    Console.WriteLine("adinizi daxil edin :");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Soyadinizi daxil edin :");
                    string Surname = Console.ReadLine();
                    var Netice = fullName(Name, Surname);

                    #region
                    Console.WriteLine("Imtahan1 neticenizi daxil edin :");
                    string Imtahan1 = Console.ReadLine();
                    Console.WriteLine("Imtahan2 neticenizi daxil edin :");
                    string Imtahan2 = Console.ReadLine();
                    Console.WriteLine("Imtahan3 neticenizi daxil edin :");
                    string Imtahan3 = Console.ReadLine();

                    #endregion
                    int deyer1, deyer2, deyer3;
                    if (Imtahan1 is null && Imtahan2 is null && Imtahan3 is null)
                    {
                        Console.WriteLine($"sizin imtahan neticeniz 51 dir");
                    }
                    else if (int.TryParse(Imtahan1, out deyer1) && (int.TryParse(Imtahan2, out deyer2)) && (int.TryParse(Imtahan3, out deyer3)))
                    {

                        var ortalama = balOrtalamasi(deyer1, deyer2, deyer3);

                        if ((deyer1 > 0 && deyer1 < 100) && (deyer2 > 0 && deyer2 < 100) && (deyer3 > 0 && deyer3 < 100))
                        {
                            if (ortalama >= 81)
                            {
                                Console.WriteLine($"{Netice} sizin bal ortalamaniz {ortalama} dir  Diplom isine dusdunuz :");
                            }
                            else
                            {
                                Console.WriteLine($"{Netice} sizin bal ortalamaniz {ortalama} dir  Diplom isine dusmediniz :");
                            }
                        }
                        else
                        {
                            Console.WriteLine("daxil etdiyiniz imtahan neticeleri 0 - 100 araliginda olmalidir ");
                        }
                        
                        
                        
                    }
                    else
                    {
                        Console.WriteLine("yalniz eded daxil ede bilersiniz ");
                    }
                }
            }
 
            #endregion
        }
        #region
        public static string fullName(string Name, string Surname)
        {
            return $"{Surname} {Name} ";
        }
        public static int balOrtalamasi(int Imtahan1, int Imtahan2, int Imtahan3)
        {
            return (Imtahan1 + Imtahan2 + Imtahan3) / 3;
        }
        #endregion

    }
}
