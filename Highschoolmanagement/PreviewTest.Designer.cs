namespace Highschoolmanagement
{
    partial class PreviewTest
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
            this.lb3 = new System.Windows.Forms.Label();
            this.comeback = new System.Windows.Forms.Button();
            this.fl = new System.Windows.Forms.FlowLayoutPanel();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.testcode = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.find = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(200, 36);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(82, 21);
            this.lb3.TabIndex = 0;
            this.lb3.Text = "Thời gian: ";
            // 
            // comeback
            // 
            this.comeback.Location = new System.Drawing.Point(564, 297);
            this.comeback.Name = "comeback";
            this.comeback.Size = new System.Drawing.Size(75, 23);
            this.comeback.TabIndex = 1;
            this.comeback.Text = "Quay lại";
            this.comeback.UseVisualStyleBackColor = true;
            this.comeback.Click += new System.EventHandler(this.comeback_Click);
            // 
            // fl
            // 
            this.fl.AutoScroll = true;
            this.fl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.fl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fl.Location = new System.Drawing.Point(203, 98);
            this.fl.Name = "fl";
            this.fl.Size = new System.Drawing.Size(286, 312);
            this.fl.TabIndex = 3;
            this.fl.WrapContents = false;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(540, 179);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(83, 21);
            this.lb1.TabIndex = 4;
            this.lb1.Text = "Test Code";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(540, 228);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(82, 21);
            this.lb2.TabIndex = 5;
            this.lb2.Text = "Mật khẩu";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(199, 64);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(126, 21);
            this.lb4.TabIndex = 6;
            this.lb4.Text = "Tên bài kiểm tra: ";
            // 
            // testcode
            // 
            this.testcode.Location = new System.Drawing.Point(638, 179);
            this.testcode.Name = "testcode";
            this.testcode.Size = new System.Drawing.Size(125, 20);
            this.testcode.TabIndex = 7;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(638, 228);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(125, 20);
            this.password.TabIndex = 8;
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(700, 297);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(75, 23);
            this.find.TabIndex = 9;
            this.find.Text = "Nhập";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // PreviewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 455);
            this.Controls.Add(this.find);
            this.Controls.Add(this.password);
            this.Controls.Add(this.testcode);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.fl);
            this.Controls.Add(this.comeback);
            this.Controls.Add(this.lb3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PreviewTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreviewTest";
            this.Load += new System.EventHandler(this.PreviewTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Button comeback;
        private System.Windows.Forms.FlowLayoutPanel fl;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox testcode;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button find;
    }
}