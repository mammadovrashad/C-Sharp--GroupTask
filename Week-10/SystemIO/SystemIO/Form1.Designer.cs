
namespace SystemIO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createFileBtn = new System.Windows.Forms.Button();
            this.createFolderBtn = new System.Windows.Forms.Button();
            this.folderTB = new System.Windows.Forms.TextBox();
            this.fileTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileTypecombobox = new System.Windows.Forms.ComboBox();
            this.showFile = new System.Windows.Forms.RichTextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openBtn
            // 
            this.openBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.openBtn.ForeColor = System.Drawing.Color.White;
            this.openBtn.Location = new System.Drawing.Point(863, 411);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(145, 41);
            this.openBtn.TabIndex = 0;
            this.openBtn.Text = "Open";
            this.openBtn.UseVisualStyleBackColor = false;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // DataGrid
            // 
            this.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Type});
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Left;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.RowTemplate.Height = 29;
            this.DataGrid.Size = new System.Drawing.Size(252, 518);
            this.DataGrid.TabIndex = 1;
            this.DataGrid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGrid_MouseDoubleClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 125;
            // 
            // createFileBtn
            // 
            this.createFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.createFileBtn.ForeColor = System.Drawing.Color.White;
            this.createFileBtn.Location = new System.Drawing.Point(233, 224);
            this.createFileBtn.Name = "createFileBtn";
            this.createFileBtn.Size = new System.Drawing.Size(145, 35);
            this.createFileBtn.TabIndex = 4;
            this.createFileBtn.Text = "Create File";
            this.createFileBtn.UseVisualStyleBackColor = false;
            this.createFileBtn.Click += new System.EventHandler(this.createFileBtn_Click);
            // 
            // createFolderBtn
            // 
            this.createFolderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.createFolderBtn.ForeColor = System.Drawing.Color.White;
            this.createFolderBtn.Location = new System.Drawing.Point(233, 100);
            this.createFolderBtn.Name = "createFolderBtn";
            this.createFolderBtn.Size = new System.Drawing.Size(145, 37);
            this.createFolderBtn.TabIndex = 5;
            this.createFolderBtn.Text = "Create Folder";
            this.createFolderBtn.UseVisualStyleBackColor = false;
            this.createFolderBtn.Click += new System.EventHandler(this.createFolderBtn_Click);
            // 
            // folderTB
            // 
            this.folderTB.BackColor = System.Drawing.Color.White;
            this.folderTB.Location = new System.Drawing.Point(206, 43);
            this.folderTB.Name = "folderTB";
            this.folderTB.Size = new System.Drawing.Size(200, 30);
            this.folderTB.TabIndex = 6;
            // 
            // fileTB
            // 
            this.fileTB.Location = new System.Drawing.Point(206, 168);
            this.fileTB.Name = "fileTB";
            this.fileTB.Size = new System.Drawing.Size(200, 30);
            this.fileTB.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(69, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Folder Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(69, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "File Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.createFileBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.createFolderBtn);
            this.panel1.Controls.Add(this.folderTB);
            this.panel1.Controls.Add(this.fileTB);
            this.panel1.Location = new System.Drawing.Point(381, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 284);
            this.panel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.fileTypecombobox);
            this.groupBox1.Location = new System.Drawing.Point(821, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 145);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // fileTypecombobox
            // 
            this.fileTypecombobox.FormattingEnabled = true;
            this.fileTypecombobox.Items.AddRange(new object[] {
            "html",
            "jpg",
            "txt",
            "png",
            "py",
            "js"});
            this.fileTypecombobox.Location = new System.Drawing.Point(6, 29);
            this.fileTypecombobox.Name = "fileTypecombobox";
            this.fileTypecombobox.Size = new System.Drawing.Size(151, 31);
            this.fileTypecombobox.TabIndex = 0;
            this.fileTypecombobox.Text = "  Choose Type";
            // 
            // showFile
            // 
            this.showFile.Location = new System.Drawing.Point(32, 32);
            this.showFile.Name = "showFile";
            this.showFile.Size = new System.Drawing.Size(189, 30);
            this.showFile.TabIndex = 12;
            this.showFile.Text = "";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(62, 78);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(145, 38);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.showFile);
            this.panel2.Controls.Add(this.saveBtn);
            this.panel2.Location = new System.Drawing.Point(565, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 125);
            this.panel2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::SystemIO.Properties.Resources.smart_folder_icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1020, 518);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.openBtn);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
           
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Button createFileBtn;
        private System.Windows.Forms.Button createFolderBtn;
        private System.Windows.Forms.TextBox folderTB;
        private System.Windows.Forms.TextBox fileTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox fileTypecombobox;
        private System.Windows.Forms.RichTextBox showFile;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

