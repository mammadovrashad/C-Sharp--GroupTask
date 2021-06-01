
namespace WinFormsAppTask2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.authorLbl = new System.Windows.Forms.Label();
            this.authorTxt = new System.Windows.Forms.TextBox();
            this.categoryTxt = new System.Windows.Forms.TextBox();
            this.ctockcountTxt = new System.Windows.Forms.TextBox();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.stockcountLbl = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsAppTask2.Properties.Resources._13_e5p0_3r;
            this.pictureBox1.Location = new System.Drawing.Point(557, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(9, 43);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(49, 20);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(94, 36);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(125, 27);
            this.nameTxt.TabIndex = 2;
            // 
            // authorLbl
            // 
            this.authorLbl.AutoSize = true;
            this.authorLbl.Location = new System.Drawing.Point(4, 99);
            this.authorLbl.Name = "authorLbl";
            this.authorLbl.Size = new System.Drawing.Size(54, 20);
            this.authorLbl.TabIndex = 3;
            this.authorLbl.Text = "Author";
            // 
            // authorTxt
            // 
            this.authorTxt.Location = new System.Drawing.Point(94, 99);
            this.authorTxt.Name = "authorTxt";
            this.authorTxt.Size = new System.Drawing.Size(125, 27);
            this.authorTxt.TabIndex = 4;
            // 
            // categoryTxt
            // 
            this.categoryTxt.Location = new System.Drawing.Point(94, 157);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(125, 27);
            this.categoryTxt.TabIndex = 5;
            // 
            // ctockcountTxt
            // 
            this.ctockcountTxt.Location = new System.Drawing.Point(94, 224);
            this.ctockcountTxt.Name = "ctockcountTxt";
            this.ctockcountTxt.Size = new System.Drawing.Size(125, 27);
            this.ctockcountTxt.TabIndex = 6;
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Location = new System.Drawing.Point(4, 157);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(69, 20);
            this.categoryLbl.TabIndex = 7;
            this.categoryLbl.Text = "Category";
            // 
            // stockcountLbl
            // 
            this.stockcountLbl.AutoSize = true;
            this.stockcountLbl.Location = new System.Drawing.Point(0, 224);
            this.stockcountLbl.Name = "stockcountLbl";
            this.stockcountLbl.Size = new System.Drawing.Size(88, 20);
            this.stockcountLbl.TabIndex = 8;
            this.stockcountLbl.Text = "Stock Count";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(94, 304);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(307, 134);
            this.description.TabIndex = 9;
            this.description.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Description";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Blue;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateBtn.Location = new System.Drawing.Point(722, 387);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(115, 41);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBtn.Location = new System.Drawing.Point(557, 387);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(126, 41);
            this.addBtn.TabIndex = 12;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(866, 450);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.stockcountLbl);
            this.Controls.Add(this.categoryLbl);
            this.Controls.Add(this.ctockcountTxt);
            this.Controls.Add(this.categoryTxt);
            this.Controls.Add(this.authorTxt);
            this.Controls.Add(this.authorLbl);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label authorLbl;
        private System.Windows.Forms.TextBox authorTxt;
        private System.Windows.Forms.TextBox categoryTxt;
        private System.Windows.Forms.TextBox ctockcountTxt;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Label stockcountLbl;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
    }
}

