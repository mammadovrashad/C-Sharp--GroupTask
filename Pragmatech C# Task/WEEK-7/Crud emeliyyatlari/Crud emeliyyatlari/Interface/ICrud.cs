using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_emeliyyatlari.Interface
{
   public interface ICrud
    {
        void Add(Product.Product product);
        void Delete();
        void Update();
        void GetAll();
    }
}
