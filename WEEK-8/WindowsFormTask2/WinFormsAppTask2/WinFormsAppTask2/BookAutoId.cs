using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppTask2
{
  public partial class Book
    {
        public Book(string _name, string _author, string _category, int _stockcount, string _description)
        {
            this.Name = _name;
            this.Author = _author;
            this.Category = _author;
            this.Description = _description;
            this.StockCount = _stockcount;
            this.Id++;

        }
    }
}
