using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppTask2
{
    public partial class Form1 : Form
    {
        public Form1(Book data)
        {
            InitializeComponent();
            nameTxt.Text = data.Name;
            authorTxt.Text = data.Author;
            categoryTxt.Text = data.Category;
            ctockcountTxt.Text =Convert.ToString( data.StockCount);
            description.Text = data.Description;

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
            Book books = new Book(nameTxt.Text, authorTxt.Text, categoryTxt.Text, Convert.ToInt32(ctockcountTxt.Text), description.Text);
            BookDB.database.Add(books);
            BookList book = new BookList();
            book.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
