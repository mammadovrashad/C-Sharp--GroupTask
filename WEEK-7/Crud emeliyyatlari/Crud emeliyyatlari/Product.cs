using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Crud_emeliyyatlari
{
   
  public  interface Icrud
    {
        void Add();
        void Delete();
        void Update();
        void GetAll();
        
    }
    public abstract class BaseEntity
    {
        private int id = 0;

        protected int Id
        {
            get
            {
                return id;
            }
            set
            {

                for (int i = 0; i < Crud.database.Count; i++)
                {
                    id += 1;

                }

            }
        }
        
    }
    public abstract class Product:BaseEntity
    {
        private double price = 0;
        public string BarCode { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public double Size { get; set; }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (CheckPrice(value))
                {
                    Console.WriteLine("Mehsulun qiymeti 0-dan kicik ola bilmez .");
                }
                else
                {
                    price = value;
                }
            }
        }
        public string Colour { get; set; }





        #region mehsulun qiymetinin yoxlanmasi
        public bool CheckPrice(double price)
        {
            bool control = false;
            if (price <= 0)
            {
                return control;
            }
            else
            {
                control = true;
                return control;
            }
        }
        #endregion
    }

}
