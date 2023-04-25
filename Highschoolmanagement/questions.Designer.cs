namespace Highschoolmanagement
{
    partial class questions
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
            this.an1 = new System.Windows.Forms.TextBox();
            this.fl1 = new System.Windows.Forms.FlowLayoutPanel();
            this.an2 = new System.Windows.Forms.TextBox();
            this.an3 = new System.Windows.Forms.TextBox();
            this.an4 = new System.Windows.Forms.TextBox();
            this.an5 = new System.Windows.Forms.TextBox();
            this.tt = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.fl = new System.Windows.Forms.FlowLayoutPanel();
            this.fl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // an1
            // 
            this.an1.Location = new System.Drawing.Point(3, 3);
            this.an1.Name = "an1";
            this.an1.Size = new System.Drawing.Size(257, 20);
            this.an1.TabIndex = 1;
            // 
            // fl1
            // 
            this.fl1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.fl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fl1.AutoScroll = true;
            this.fl1.Controls.Add(this.an1);
            this.fl1.Controls.Add(this.an2);
            this.fl1.Controls.Add(this.an3);
            this.fl1.Controls.Add(this.an4);
            this.fl1.Controls.Add(this.an5);
            this.fl1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fl1.Location = new System.Drawing.Point(265, 94);
            this.fl1.Name = "fl1";
            this.fl1.Size = new System.Drawing.Size(280, 147);
            this.fl1.TabIndex = 5;
            // 
            // an2
            // 
            this.an2.Location = new System.Drawing.Point(3, 29);
            this.an2.Name = "an2";
            this.an2.Size = new System.Drawing.Size(257, 20);
            this.an2.TabIndex = 2;
            // 
            // an3
            // 
            this.an3.Location = new System.Drawing.Point(3, 55);
            this.an3.Name = "an3";
            this.an3.Size = new System.Drawing.Size(257, 20);
            this.an3.TabIndex = 3;
            // 
            // an4
            // 
            this.an4.Location = new System.Drawing.Point(3, 81);
            this.an4.Name = "an4";
            this.an4.Size = new System.Drawing.Size(257, 20);
            this.an4.TabIndex = 4;
            // 
            // an5
            // 
            this.an5.Location = new System.Drawing.Point(3, 107);
            this.an5.Name = "an5";
            this.an5.Size = new System.Drawing.Size(257, 20);
            this.an5.TabIndex = 5;
            // 
            // tt
            // 
            this.tt.AutoSize = true;
            this.tt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tt.Location = new System.Drawing.Point(573, 140);
            this.tt.Name = "tt";
            this.tt.Size = new System.Drawing.Size(97, 55);
            this.tt.TabIndex = 6;
            this.tt.Text = "Tiếp Tục";
            this.tt.UseVisualStyleBackColor = true;
            this.tt.Click += new System.EventHandler(this.tt_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(198, 94);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(44, 13);
            this.lb.TabIndex = 7;
            this.lb.Text = "Câu 1:";
            // 
            // fl
            // 
            this.fl.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.fl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fl.Location = new System.Drawing.Point(201, 110);
            this.fl.Name = "fl";
            this.fl.Size = new System.Drawing.Size(34, 131);
            this.fl.TabIndex = 0;
            // 
            // questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(760, 400);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.tt);
            this.Controls.Add(this.fl1);
            this.Controls.Add(this.fl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "questions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "questions";
            this.Load += new System.EventHandler(this.questions_Load);
            this.fl1.ResumeLayout(false);
            this.fl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox an1;
        private System.Windows.Forms.FlowLayoutPanel fl1;
        private System.Windows.Forms.TextBox an2;
        private System.Windows.Forms.TextBox an3;
        private System.Windows.Forms.TextBox an4;
        private System.Windows.Forms.Button tt;
        private System.Windows.Forms.TextBox an5;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.FlowLayoutPanel fl;
    }
}