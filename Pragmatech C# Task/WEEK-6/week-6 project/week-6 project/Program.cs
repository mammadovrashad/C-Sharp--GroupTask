using System;
using System.Collections;

namespace week_6_project
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task-1
            /*
             * Console-dan daxil edilen en ve uzunluga gore duzbucaqlinin sahesinin hesablanmasi.
             * class memeber-ler ve encapsulation movuzlarina uygun isleyin.
             * Qeyd: daxil edilnlerden her hansisa birinin menfi olub olmamasini yoxlayin.
             * menfidirse deyeri 0 beraber edin.
             */
            #endregion
            #region
            /*
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("uzunlugu daxil edin : 1,2,3 .......");
            rectangle.Uzunluq = int.Parse(Console.ReadLine());
            Console.WriteLine("en daxil edin :1,2,3 .......");
            rectangle.En = int.Parse(Console.ReadLine());

            if(rectangle.Uzunluq <=0 || rectangle.En <=0)
            {
                Console.WriteLine("Duzbucaqlinin sahesi  0 -di");
            }
            else
            {
                Console.WriteLine($"Duzbucaqlinin sahesi : {rectangle.Hasil}-dir");
            }
            */
            #endregion





            #region Task-2
            /*
             *  Muellim modeli yaradin, id, adi,soyadi,vezifesi,dogum tarixi, ise baslama tarixi, islediyi yer
             *  datalarini saxlasin.
             *  Id: sadece oxuna biler auto yaradilacaq.
             *  Vezife: daxil edilmeyibse nulldursa Teacher deye set edilsin.
             *  Ise Baslama tarixi : Muellimin eger 23 yasi varsa muellim olaraq fealiyyet gostere biler.
             */
            #endregion

            #region
            /*
            Teacher teacher = new Teacher();

            Hashtable muellimData = new Hashtable();
            ArrayList muellimler = new ArrayList();
            int yas = DateTime.Now.Year - (teacher.DogumTarixi.Year);
                Console.WriteLine("adinizi daxil edin :");
                teacher.Name = Console.ReadLine();
                Console.WriteLine("Soyadinizi daxil edin :");
                teacher.Surame = Console.ReadLine();
                Console.WriteLine("Dogum tarixinizi  daxil edin :");
                teacher.DogumTarixi=DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Isebaslama tarixini  daxil edin :");
                teacher.IseBaslamasi = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Is yerini  daxil edin :");
                teacher.IslediyiYer = Console.ReadLine();
                if (yas >= 23)
                {
                    muellimData.Add("Id", teacher.Id);
                    muellimData.Add("Ad", teacher.Name);
                    muellimData.Add("Soyad", teacher.Surame);
                    muellimData.Add("Vezife", teacher.Vezife);
                    muellimData.Add("DogumTarixi", teacher.DogumTarixi);
                    muellimData.Add("IseBaslama", teacher.IseBaslamasi);
                    muellimData.Add("IsYeri", teacher.IslediyiYer);

                    muellimler.Add(muellimData);

                }
                 else
                 {
                Console.WriteLine("Yasiniz 23-den yuksek olmalidir !");
                 }
                foreach (DictionaryEntry items in muellimData)
                {
                    Console.WriteLine($"{items.Key} {items.Value}");
                }
            */
            #endregion
            #region gelende eve corey al
            /*
             *  Online alis veris :
             *  * Console ekaraninda musterini ilk once  menu qarsilamalidir,
             *  mehsullari menudan sececek( qiymetleri de olmalidir) sonra hansindan ne qeder istediyini qeyd edecek
             *  bildiklerinizi tetbiq ederek asagidaki numune cekin hazilanmasi
             *  lazimdir. Mehsul adlari onlarin qiymetleri edv olub olmamasi mehsulda endirim olub olmamasi
             *  siz terefden serbest teyin olunacaq.(burada gosterilenler hayel urunudur hic biri gercegi yansitmamaktadir).
             *
             *  | mehsul adi        |  miqdar  |  qiymet  |EDV  |toplam|
             *  | Un                | 5 kq     |  1       |0 %  |5     |
             *   Sizin qazanciniz=================== 0,495             |
             *  | quzu eti          | 3,5 kq   |  12      |18 % |42    |
             *   Sizin qazanciniz=================== 0,90              |
             *  | cay               | 2   eded |  1,50    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | alma qirmizi      | 2   kq   |  2,50    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | alma sari         | 2   kq   |  2       |18 % |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | goyerti           | 2   eded |  0,15    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | makaron           | 2   eded |  2       |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | baliq konservasi  | 2   eded |  3,50    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | lavas             | 1   eded |  1,50    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | corek             | 2   eded |  0,50    |18 % |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | pomidor           | 2   kq   |  2,50    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | xiyar             | 2   kq   |  2       |0 %  |      |
             *   Sizin qazanciniz=================== 0,90              |
             *  | toyuq             | 2   eded |  2,50    |0 %  |      |
             *   Sizin qazanciniz=================== 0,90
             * +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
             * Endirim                                          | 2,48 |
             * vergi edv                                        | 5,02 |
             * yekun mebleg                                     | 54,50|
             * odenis novu: kartla odenib                        
             * tarix 20:04:21
             * qebz nomresi : 12
             *
             * Musterinin hesabinda umumi 450 azn pul var,
             * elave olaraq musteri bravo endirim kartina sahib oldugu ucun her alis verishinde
             * umumi meblegin 2% qeder endirim elde edir. Musteri odenisi kartla ederse 0,18 elave deyer vergisinin
             * 10 % qederini , negd pulla ederse 15 % qederini yeniden musterinin hesabina kocurulur.
             *
             * sizin qazanciniz :
             * | Un                | 5 kq     |  1       |0 %  | 5
             *  Sizin qazanciniz=================== 0,495 ( 5 % endirim olub bu mehsulda digerlerinde de bu sekilde endrim olarsa hesablanmalidir.)
             *  0,495 qaliqlarda yuvarlasdirmada edersiz 
             * EDV :
             *  asagida gosterildiyi kimi bezi mehsullarda 0% bezilerinde 18% edv olmalidir.
             *  Sonda elave deyer vergisi-de hansi mehsullarda varsa toplanib yekun meblegin
             *  uzerine gelmelidir. Musteri odenisi kart-la  edibse 10% negd yolla odenis edibse
             *  15 % umumi edv-den musterinin hesabina pul qayidacaq.
             * 
             *  | mehsul adi        |  miqdar  |  qiymet  |EDV  |toplam
             *  | Un                | 5 kq     |  1       |0 %  |5
             *   Sizin qazanciniz=================== 0,495
             *  | quzu eti          | 3,5 kq   |  12      |18 % |42
             *
             *
             *  alis veris 15 azn den azdirsa catdirilma ucun 4,50 azn teleb olunacaq.
             */


            #endregion
            #region
            Console.WriteLine(" Hesabinizda olan mebleg  450 AZN\n");
            Console.WriteLine(" Product Menu ---------------------------\n");

            Console.WriteLine("| mehsul adi        |   qiymet    |EDV |\n");
            Console.WriteLine("| Un                |   1  AZN    |5 %  |");

            Console.WriteLine("| quzu eti          |   12 AZN    |18 % |");

            Console.WriteLine("| cay               |   1,50 AZN  |2 %  |");

            Console.WriteLine("| alma qirmizi      |   2,50 AZN  |0 %  |");

            Console.WriteLine("| alma sari         |   2 AZN     |18 % |");

            Console.WriteLine("| goyerti           |   0,15 AZN  |0 %  |");

            Console.WriteLine("| makaron           |   2  AZN    |7 %  |");

            Console.WriteLine("| baliq konservasi  |   3,50 AZN  |0 %  |");

            Console.WriteLine("| lavas             |   1,50 AZN  |0 %  |");

            Console.WriteLine("| corek             |   0,50 AZN  |18 % |");

            Console.WriteLine("| pomidor           |   2,50 AZN  |0 %  |");

            Console.WriteLine("| xiyar             |   2  AZN    |6 %  |");
                     
            Console.WriteLine("| toyuq             |   2,50 AZN  |0 % |\n\n");
            Random random = new Random();
            Productcs product = new Productcs()           
            {
                Name = "Un",
                Miqdar = 1,
                Qiymet = 2,
                Edv = 0.5,
                Odenis = "Kartla",
                BravoKart = "var"
            };
           

            Console.WriteLine($"Elave odenilecek Mebleg : {(product.Miqdar * product.Qiymet) * product.Edv}");
            if (Productcs.total < 15)
            {
                Console.WriteLine("Elave catdirilma ucun : 4.50 AZN ");
                Console.WriteLine($"Yekun mebleg : {Productcs.total + 4.50}");
            }
            else
            {
                Console.WriteLine($"Yekun mebleg : {Productcs.total}");
            }
            Console.WriteLine($"Odenis novu: {product.Odenis}");
            Console.WriteLine($"Tarix : {DateTime.Now}");
            Console.WriteLine($"Qebzin omresi : {random.Next(1, 100000)}");
            #endregion
        }
    }
}
