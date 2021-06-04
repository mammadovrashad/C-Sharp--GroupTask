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
            Book data = BookDB.database[booklistCombobox.SelectedIndex];
             var a = booklistCombobox.SelectedIndex;
             Form1 form = new Form1( data);
             form.Show();
             this.Hide();
            
            
            


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selecteIndex = booklistCombobox.SelectedIndex;

            
            DialogResult result= MessageBox.Show("Datani silmek istediyinize eminsinizmi ?", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result is DialogResult.OK)
            {
                booklistCombobox.Items.RemoveAt(selecteIndex);
                BookDB.database.RemoveAt(selecteIndex);
            }
            

        }
    }
}
