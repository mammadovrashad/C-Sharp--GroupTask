using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SystemIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Hide();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string directory;
        private string path;
        private string fileName;



        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        ///  Bu method daxil edilen adli Folder yaradir
        /// </summary>
      
        private void createFolderBtn_Click(object sender, EventArgs e)
        {
            string path = $"C:\\test\\{folderTB.Text}";
            
            if (Directory.Exists(path))
            {
                DialogResult dialogResult= MessageBox.Show("Bu Folder artiq yaddasda movcuddur! Folder override olunsun ?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
                    DataGrid.Rows.Add(directoryInfo,"Folder");
                    folderTB.Clear();
                  
                }
                else if(dialogResult == DialogResult.Cancel)
                {
                    folderTB.Clear();
                }
                
            }
            else
            {
                DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
                DataGrid.Rows.Add(directoryInfo,"Folder");
                folderTB.Clear();

            }
            
        }
        /// <summary>
        /// Bu method secdiyimiz file tipine uygun file create edir  
        /// </summary>
        private void createFileBtn_Click(object sender, EventArgs e)
        {
          
            if (fileTypecombobox.SelectedItem==null|| string.IsNullOrEmpty(fileTB.Text))
            {
                MessageBox.Show("Faylin tipi bos ola bilmez", "xeta", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            }
            else
            {
                string type = fileTypecombobox.SelectedItem.ToString();
                if(type is "jpg"|| type is "png")
                {
                    DirectoryInfo directoryImages = Directory.CreateDirectory($"C:\\test\\IMAGES");
                    fileName = $"C:\\test\\{directoryImages.Name}\\{fileTB.Text}.{type}";
                    FileStream fileStream = File.Create(fileName);
                    fileStream.Close();
                    DataGrid.Rows.Add(fileStream.Name, "File");
                    fileTB.Clear();
                }
                else
                {
                    DirectoryInfo directory = Directory.CreateDirectory($"C:\\test\\{type.ToUpper()}");
                    fileName = $"C:\\test\\{type.ToUpper()}\\{fileTB.Text}.{type}";
                    FileStream fileStream = File.Create(fileName);
                    fileStream.Close();
                    DataGrid.Rows.Add(fileStream.Name, "File");
                    fileTB.Clear();
                }
                
                
            }
            
        }

/// <summary>
/// Bu method Open duymesine click edende secdiyimiz folderden butun file ve folderleri getirib DataGride yazir
/// </summary>
        private void openBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                directory = folderBrowserDialog1.SelectedPath.ToString();
                foreach (var folder in Directory.GetDirectories(directory))
                {
                    DataGrid.Rows.Add(folder, "Folder");
                }
                foreach(var file in Directory.GetFiles(directory))
                {
                    DataGrid.Rows.Add(file, "File");
                }
                
                
            }

        }

        
    }
}
 