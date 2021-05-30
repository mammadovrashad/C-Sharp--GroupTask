using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_emeliyyatlari.Laptop
{
    partial class Laptop : Product.Product, Interface.ICrud
    {
        public void Add(Product.Product product)
        {
            
           
                if (DataBase.Database._database.Contains(product.BarCode))
                {
                Console.WriteLine($"{Constats.Constants._data}");
                }
                else
                {
                Laptop AllLaptop = new()
                {
                    Id=product.Id,
                    Name=product.Name,
                    BarCode=product.BarCode,
                    CreateDate=this.CreateDate,
                    Price=this.Price,
                    RAM=this.RAM,
                    VideoCart=this.VideoCart,
                    CPU=this.CPU,
                    
                };
                DataBase.Database._database.Add(AllLaptop);
                



                Console.WriteLine($"{Constats.Constants._add}");
                }
            Console.WriteLine(product.BarCode);
            Console.WriteLine(this.Price);
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
       
    }
}
