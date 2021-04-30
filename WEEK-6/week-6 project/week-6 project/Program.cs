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
        }
    }
}
