using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud_emeliyyatlari.Tv
{
    partial class Tv : Product.Product, Interface.ICrud
    {
        public bool SmartTv { get; set; } = false;
        public bool Hdmi { get; set; } = false;
        public string Inch { get; set; }
    }
}
