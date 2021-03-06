using System;
using System.Collections;
namespace Crud_emeliyyatlari
{
    class Program
    {
        static void Main(string[] args)
        {
            #region crud emeliyyatlari
            /*
            * Productin database elave edilmesi, silinmesi, redakte edilmesi,butun mehsullarin gosterilmesi.
            * Taski yerine yetirerken kecdiyimiz yeni movzulari
            * ehate etmesine fikir verilmelidir. 2 mehsul tipimiz olacaq biri Tv digeri ise Laptop.
            *
            *
            * Product
            * Id : sistem terefinden genarete olunacaq , set oluna bilmez, 1-den baslayaraq artan olmalidir.
            * Barcode : DataBase-de eyni barcode-a sahip mehsulun olub olmamasi yoxlanmalidir.
            * Purchase price : mehsulun alis qiymeti 0-dan kicik ve ya beraber ola bilmez.
            * Sale price : mehsulun satis qiymeti alis qiymetinden kicik ola bilmez.
            * Discount price : mehsulun endirimli qiymeti 0-dan kicik ve ya beraber ola bilmez.
            * CreateDate : set edile bilmez.
            * Brand
            * Model
            * IsDeleted (bool)
            * DeletedDate : set edile bilmez
            * UpdatedDate : set edile bilmez
             *
             *
            * *Laptop
            * cpu
            * ram
            * videoCard
            *
            * * Tv
            * SmartTv (bool)
            * Inch
            * HDMi (bool)
            *
            * *Database 
            * Add : mehsulun elave edilmesi
            * Remove : mehsulun silinmesi(sadece isDeleted statusu redakte edilir.)
            * GetAll : IsDeleted statusu false olanlarin siyahisinin gosterilmesi 
            * Update : Mehsulun Brand,Model,Discount price,Sale price,Purchase price, Barcode xususiyyetleri redakte edilecek.
            *
            *
            */
            #endregion
            Laptop.Laptop laptop = new ()
            {
                Id = 1,
                Name = "Hp",
                BarCode = "233",
                RAM = 8,
                CreateDate = "2019",
                Price = 1200,
                CPU = "corpewt",
                VideoCart = "1080"
            };
            Laptop.Laptop laptop1 = new()
            {
                Id = 2,
                Name = "ASUS",
                BarCode = "233",
                RAM = 8,
                CreateDate = "2020",
                Price = 1400,
                CPU = "corpewt",
                VideoCart = "1080hd"
            };
            laptop.Add(laptop);
            laptop.Add(laptop1);

        }
    }
}
