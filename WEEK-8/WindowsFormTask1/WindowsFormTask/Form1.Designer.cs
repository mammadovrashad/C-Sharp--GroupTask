
namespace WindowsFormTask
{
    partial class Musteri
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
            this.components = new System.ComponentModel.Container();
            this.username = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.surname = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.numberTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.CustomerList = new System.Windows.Forms.ListBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.username.Location = new System.Drawing.Point(50, 29);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(62, 21);
            this.username.TabIndex = 0;
            this.username.Text = "Name";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.email.Location = new System.Drawing.Point(50, 192);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(51, 23);
            this.email.TabIndex = 1;
            this.email.Text = "Email";
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.surname.Font = new System.Drawing.Font("Baskerville Old Face", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.surname.Location = new System.Drawing.Point(50, 109);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(80, 21);
            this.surname.TabIndex = 2;
            this.surname.Text = "Surname";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.number.Location = new System.Drawing.Point(50, 274);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(127, 23);
            this.number.TabIndex = 3;
            this.number.Text = "Phone Number";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(50, 65);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(153, 30);
            this.nameTxt.TabIndex = 4;
            // 
            // surnameTxt
            // 
            this.surnameTxt.Location = new System.Drawing.Point(50, 146);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(153, 30);
            this.surnameTxt.TabIndex = 5;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(50, 229);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(153, 30);
            this.emailTxt.TabIndex = 6;
            // 
            // numberTxt
            // 
            this.numberTxt.Location = new System.Drawing.Point(50, 319);
            this.numberTxt.Name = "numberTxt";
            this.numberTxt.Size = new System.Drawing.Size(153, 30);
            this.numberTxt.TabIndex = 7;
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Blue;
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveBtn.Location = new System.Drawing.Point(50, 392);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(100, 40);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // CustomerList
            // 
            this.CustomerList.FormattingEnabled = true;
            this.CustomerList.ItemHeight = 23;
            this.CustomerList.Location = new System.Drawing.Point(345, 45);
            this.CustomerList.Name = "CustomerList";
            this.CustomerList.Size = new System.Drawing.Size(391, 349);
            this.CustomerList.TabIndex = 9;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Visible = true;
            // 
            // Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(828, 475);
            this.Controls.Add(this.CustomerList);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.numberTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.number);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.email);
            this.Controls.Add(this.username);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Musteri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Musteri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label surname;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ListBox CustomerList;
        private System.Windows.Forms.TextBox numberTxt;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

