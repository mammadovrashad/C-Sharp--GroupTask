using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_emeliyyatlari
{
    class Tv:Product
    {
        public bool SmartTv { get; set; }
        public bool Hdmi { get; set; }

        public void Add()
        {
            Tv tv = new Tv() {BarCode="236", Name ="Svmsung",Colour="black",SmartTv=true,Size=150,Price=800,Year="2021",Hdmi=true};
            Tv tv1 = new Tv() { BarCode = "276", Name = "OLG", Colour = "white", SmartTv = false, Size = 120, Price = 600, Year = ("2020"), Hdmi = true };
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
