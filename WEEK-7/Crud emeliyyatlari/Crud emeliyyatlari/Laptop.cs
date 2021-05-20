using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_emeliyyatlari
{
    class Laptop:Product,Icrud
    {
        public int Ram { get; set; }
        public string VidieoCard { get; set; }

        public  void Add()
        {
            Laptop laptop = new Laptop(){ BarCode="123", Name = "hp",Colour = "black",Price = 1200,Size = 120,Ram = 8,VidieoCard = "1080",Year = ("2020")};
            Laptop laptop1 = new Laptop() { BarCode = "456", Name = "Asus", Colour = "white", Price = 1500, Size = 120, Ram = 16, VidieoCard = "1080HD", Year =("2021") };
            
            Crud.database.Add(laptop);
            Crud.database.Add(laptop1);
        }
        
        public  void Delete()
        {
           
        }

        public  void Update()
        {
            
        }
        public void GetAll()
        {

        }

       
    }
}
