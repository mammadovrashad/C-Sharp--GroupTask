using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_emeliyyatlari.Laptop
{
   partial class Laptop :Product.Product,Interface.ICrud
    {
       public string CPU { get; set; }
       public int RAM { get; set; }
       public string VideoCart { get; set; }
    }
   
}
