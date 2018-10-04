namespace Library
{
    partial class signup_page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signup_page));
            this.namebox = new System.Windows.Forms.TextBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.tckimlikbox = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.typeyazı = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.Label();
            this.TC_Kimlik = new System.Windows.Forms.Label();
            this.typebox = new System.Windows.Forms.ComboBox();
            this.signup2 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.usernamel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.passwordl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.BackColor = System.Drawing.Color.FloralWhite;
            this.namebox.Location = new System.Drawing.Point(98, 80);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(130, 20);
            this.namebox.TabIndex = 2;
            this.namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
            // 
            // emailbox
            // 
            this.emailbox.BackColor = System.Drawing.Color.FloralWhite;
            this.emailbox.Location = new System.Drawing.Point(355, 131);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(130, 20);
            this.emailbox.TabIndex = 7;
            // 
            // tckimlikbox
            // 
            this.tckimlikbox.BackColor = System.Drawing.Color.FloralWhite;
            this.tckimlikbox.Location = new System.Drawing.Point(98, 28);
            this.tckimlikbox.Name = "tckimlikbox";
            this.tckimlikbox.Size = new System.Drawing.Size(130, 20);
            this.tckimlikbox.TabIndex = 1;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(60, 83);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(35, 13);
            this.name.TabIndex = 8;
            this.name.Text = "Name";
            // 
            // typeyazı
            // 
            this.typeyazı.AutoSize = true;
            this.typeyazı.Location = new System.Drawing.Point(308, 187);
            this.typeyazı.Name = "typeyazı";
            this.typeyazı.Size = new System.Drawing.Size(101, 13);
            this.typeyazı.TabIndex = 10;
            this.typeyazı.Text = "Üyelik Tipini Seçiniz";
            this.typeyazı.Click += new System.EventHandler(this.label3_Click);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(318, 134);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(35, 13);
            this.email.TabIndex = 12;
            this.email.Text = "E-mail";
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.Location = new System.Drawing.Point(276, 83);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(78, 13);
            this.phone.TabIndex = 13;
            this.phone.Text = "Phone Number";
            // 
            // TC_Kimlik
            // 
            this.TC_Kimlik.AutoSize = true;
            this.TC_Kimlik.Location = new System.Drawing.Point(28, 34);
            this.TC_Kimlik.Name = "TC_Kimlik";
            this.TC_Kimlik.Size = new System.Drawing.Size(68, 13);
            this.TC_Kimlik.TabIndex = 14;
            this.TC_Kimlik.Text = "TC Kimlik No";
            this.TC_Kimlik.Click += new System.EventHandler(this.label7_Click);
            // 
            // typebox
            // 
            this.typebox.AccessibleName = "";
            this.typebox.BackColor = System.Drawing.Color.FloralWhite;
            this.typebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typebox.FormattingEnabled = true;
            this.typebox.Items.AddRange(new object[] {
            "Instructor",
            "Student",
            "Others"});
            this.typebox.Location = new System.Drawing.Point(355, 219);
            this.typebox.Name = "typebox";
            this.typebox.Size = new System.Drawing.Size(130, 21);
            this.typebox.TabIndex = 8;
            this.typebox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // signup2
            // 
            this.signup2.BackColor = System.Drawing.Color.Purple;
            this.signup2.ForeColor = System.Drawing.Color.White;
            this.signup2.Location = new System.Drawing.Point(224, 270);
            this.signup2.Name = "signup2";
            this.signup2.Size = new System.Drawing.Size(75, 23);
            this.signup2.TabIndex = 17;
            this.signup2.Text = "Sign Up";
            this.signup2.UseVisualStyleBackColor = false;
            this.signup2.Click += new System.EventHandler(this.signup2_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(355, 80);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(130, 20);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // usernamel
            // 
            this.usernamel.AutoSize = true;
            this.usernamel.Location = new System.Drawing.Point(42, 134);
            this.usernamel.Name = "usernamel";
            this.usernamel.Size = new System.Drawing.Size(55, 13);
            this.usernamel.TabIndex = 20;
            this.usernamel.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.textBox1.Location = new System.Drawing.Point(98, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 3;
            // 
            // passwordl
            // 
            this.passwordl.AutoSize = true;
            this.passwordl.Location = new System.Drawing.Point(271, 31);
            this.passwordl.Name = "passwordl";
            this.passwordl.Size = new System.Drawing.Size(83, 13);
            this.passwordl.TabIndex = 22;
            this.passwordl.Text = "Password Again";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FloralWhite;
            this.textBox2.Location = new System.Drawing.Point(355, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Password";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FloralWhite;
            this.textBox3.Location = new System.Drawing.Point(98, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.Size = new System.Drawing.Size(130, 20);
            this.textBox3.TabIndex = 4;
            // 
            // signup_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(546, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.passwordl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.usernamel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.signup2);
            this.Controls.Add(this.typebox);
            this.Controls.Add(this.TC_Kimlik);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.typeyazı);
            this.Controls.Add(this.name);
            this.Controls.Add(this.tckimlikbox);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.namebox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "signup_page";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.signup_page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.TextBox tckimlikbox;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label typeyazı;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Label TC_Kimlik;
        private System.Windows.Forms.ComboBox typebox;
        private System.Windows.Forms.Button signup2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label usernamel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label passwordl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
    }
}