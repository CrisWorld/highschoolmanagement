namespace Highschoolmanagement
{
    partial class Signinn
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
            this.signin = new System.Windows.Forms.Label();
            this.tk1 = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.enterbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // signin
            // 
            this.signin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.Location = new System.Drawing.Point(266, 177);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(355, 221);
            this.signin.TabIndex = 0;
            this.signin.Text = "Đăng Nhập";
            this.signin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tk1
            // 
            this.tk1.Location = new System.Drawing.Point(26, 39);
            this.tk1.Name = "tk1";
            this.tk1.Size = new System.Drawing.Size(125, 20);
            this.tk1.TabIndex = 1;
            this.tk1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(26, 78);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(125, 20);
            this.password.TabIndex = 2;
            this.password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(23, 23);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(55, 13);
            this.username.TabIndex = 3;
            this.username.Text = "Tài khoản";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mật khẩu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.enterbutton);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tk1);
            this.panel1.Controls.Add(this.username);
            this.panel1.Location = new System.Drawing.Point(300, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 137);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // enterbutton
            // 
            this.enterbutton.Location = new System.Drawing.Point(167, 78);
            this.enterbutton.Name = "enterbutton";
            this.enterbutton.Size = new System.Drawing.Size(75, 23);
            this.enterbutton.TabIndex = 5;
            this.enterbutton.Text = "Enter";
            this.enterbutton.UseVisualStyleBackColor = true;
            this.enterbutton.Click += new System.EventHandler(this.enterbutton_Click);
            // 
            // Signinn
            // 
            this.AcceptButton = this.enterbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signin);
            this.MinimizeBox = false;
            this.Name = "Signinn";
            this.Text = "HighSchool";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label signin;
        private System.Windows.Forms.TextBox tk1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button enterbutton;
    }
}

