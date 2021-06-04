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
                    StringBuilder fullname = new StringBuilder();
                    fullname.Append($"{items.Name}  ");
                    fullname.Append(items.Surname);
                    CustomerList.Items.Add(fullname);
                    
                }

                // MessageBox.Show(DBcount.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
                notifyIcon = new NotifyIcon()
                {
                    BalloonTipText = $"musteri sayi : {DBcount}",
                    BalloonTipTitle = $"Information",
                    Icon = SystemIcons.Information,
                    Visible = true
                };
                notifyIcon.ShowBalloonTip(1500);
                

            }
            else if (dialogResult == DialogResult.No)
            {
                ClearData();
            }
        }

        private void ClearData()
        {
            nameTxt.Clear();
            surnameTxt.Clear();
            emailTxt.Clear();
            numberTxt.Clear();
        }

        private void Musteri_Load(object sender, EventArgs e)
        {

        }

     
    }
}
