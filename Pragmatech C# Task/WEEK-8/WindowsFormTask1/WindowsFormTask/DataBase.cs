using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormTask
{
    class VirtualDB
    {
        public static readonly List<Customer> CustomerDb;
        static VirtualDB()
        {
            CustomerDb = new List<Customer>();
        }
    }
}
