using System;
using System.Collections;

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
            /*
            Student student = new Student();
            while (true)
            {
                {
                    Console.WriteLine("adinizi daxil edin :");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Soyadinizi daxil edin :");
                    string Surname = Console.ReadLine();
                    var fullname = Student.FullName(Name, Surname);

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

                        var ortalama = Student.Avarage(deyer1, deyer2, deyer3);

                        if ((deyer1 > 0 && deyer1 < 100) && (deyer2 > 0 && deyer2 < 100) && (deyer3 > 0 && deyer3 < 100))
                        {
                            if (ortalama >= 81)
                            {
                                Console.WriteLine($"{fullname} sizin bal ortalamaniz {ortalama} dir  Diplom isine dusdunuz :");
                            }
                            else
                            {
                                Console.WriteLine($"{fullname} sizin bal ortalamaniz {ortalama} dir  Diplom isine dusmediniz :");
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
            */

            #endregion






            #region 2. para pul el cerki 2 yakinda sinemalarda
            /*
             * Evvelceden teyin edilen pin vasitesile ATM-ye yaxinlasan vetendas pini daxil edir.
             * Qarsinina cixan menu-dan balansina baxa, negd pul cixarda, ve ya umumi hesabdan cixaris
             * isteye biler.Secilen her hansi bir emeliyyatdan sonra istifadeci yeniden menuya- geri done bilmelidir.
             *
             *
             * login
             *
             * pin:
             * pin sadece reqemlerden ibaret olmalidir // 1234
             * pin sadece 4 reqemden ibaret olmalidir.
             *
             *
             * Menu
             *
             * 1.Balans:
             * (evvelceden standart olaraq balans 1000 azn olaraq nezerde tutulur.)
             *
             * 2.Negd pulun verilmesi:
             *  Istifadeci ATM-den min 1 manat max 1000 manat ceke biler.Balans yoxlamasi olacaq,
             *  daxil edilen mebleg hansi esginasdan nece eded olacaq o sekilde netice olaraq gosterilir.
             *   
             *
             * 3.Balansdan cixaris:
             *   Eger balansdan mexaric olubsa mexaric olunan meblegi ve hemin tarixi cap edin,
             *   Yox eger hele balansdan mexaric olunmayibsa bu haqqda mesaj gosterin.
             *
             *
             * Qeyd: consoledan daxil edilenler yalniz eded ola biler bular yoxlayanacaq ,
             * mumkun derece methodlarla isleyin
             *   
             */
            #endregion

            #region
            ArrayList vaxt = new ArrayList();
            while (true) {
                Console.WriteLine("Pin daxil edin :");
            string pin = Console.ReadLine();
                Console.WriteLine(Atm.Pin(pin));
                Console.WriteLine("cixaris ucun reqmi daxil edin:");
             int nomre = int.Parse(Console.ReadLine());
                Atm.Switch(nomre);
                
            }

            #endregion


        }



    }
}
