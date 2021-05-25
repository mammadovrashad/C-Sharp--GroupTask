using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_emeliyyatlari.Product
{
   public abstract class Product
    {
        private double _price = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string BarCode { get; set; }
        public double Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"{Constats.Constants._defaultprice}");
                }
                else
                {
                    _price = value;
                }
               
            }
        }
        public string CreateDate { get; set; }
        public DateTime DeleteTime { get; } = DateTime.Now;
        public DateTime UpdateTime { get; } = DateTime.Now;
       
          
        
    }
}
