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
    }
   public abstract class  Product
    {
        private  int id=0;
       
        protected int Id
        {
            get
            {
                return id;
            }
            set
            {
                
                for(int i = 0; i < Crud.database.Count; i++)
                {
                    id += 1;
                   
                }
               
            }
        }
        public string Name { get; set; }
        public string Year { get; set; }
        public double Size { get; set; }
        public double Price { get; set; }
        public string Colour { get; set; }
    }
}
