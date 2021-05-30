using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormTask
{
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }

        

        private void saveBtn_Click(object sender, EventArgs e)
        {
           DialogResult dialogResult= MessageBox.Show("Yeni data elave etmek isteyirsiniz ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Customer customer = new Customer()
                {
                    Name = nameTxt.Text,
                    Surname = surnameTxt.Text,
                    Email = emailTxt.Text,
                    Number = numberTxt.Text
                };
                VirtualDB.CustomerDb.Add(customer);
                var DBcount=VirtualDB.CustomerDb.Count();
                foreach(var items in VirtualDB.CustomerDb)
                {
                    CustomerList.Items.Add($"Name: {items.Name}  Surname: { items.Surname}");
                }

                MessageBox.Show(DBcount.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                nameTxt.Clear();
                surnameTxt.Clear();
                emailTxt.Clear();
                numberTxt.Clear();

            }
            else if (dialogResult == DialogResult.No)
            {
                nameTxt.Clear();
                surnameTxt.Clear();
                emailTxt.Clear();
                numberTxt.Clear();
            }
        }

        private void Musteri_Load(object sender, EventArgs e)
        {

        }

      
    }
}
