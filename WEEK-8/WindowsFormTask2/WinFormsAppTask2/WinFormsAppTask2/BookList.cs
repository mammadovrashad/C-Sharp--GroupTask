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
    public partial class BookList : Form
    {
        public BookList()
        {
            InitializeComponent();
            foreach (var item in BookDB.database)
            {
                if (item is not null)
                {
                    booklistCombobox.Items.Add($"Book Name:{item.Name}");
                }
            }
        }

        private void BookList_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = BookDB.database[booklistCombobox.SelectedIndex];
            Form1 form = new Form1( data);
            form.Show();
            
            
            


        }
    }
}
