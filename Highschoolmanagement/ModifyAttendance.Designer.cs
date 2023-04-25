namespace Highschoolmanagement
{
    partial class ModifyAttendance
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
            this.days = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.classID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.clb = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // days
            // 
            this.days.Location = new System.Drawing.Point(376, 78);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(100, 20);
            this.days.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập ngày điểm danh";
            // 
            // classID
            // 
            this.classID.Location = new System.Drawing.Point(376, 171);
            this.classID.Name = "classID";
            this.classID.Size = new System.Drawing.Size(100, 20);
            this.classID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Class ID";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(393, 242);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(83, 39);
            this.save.TabIndex = 9;
            this.save.Text = "Lưu";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(277, 242);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(83, 39);
            this.find.TabIndex = 8;
            this.find.Text = "Tìm";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // clb
            // 
            this.clb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb.FormattingEnabled = true;
            this.clb.Location = new System.Drawing.Point(492, 28);
            this.clb.Name = "clb";
            this.clb.Size = new System.Drawing.Size(298, 344);
            this.clb.TabIndex = 11;
            // 
            // ModifyAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 455);
            this.Controls.Add(this.clb);
            this.Controls.Add(this.save);
            this.Controls.Add(this.find);
            this.Controls.Add(this.classID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.days);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cật nhật điểm danh";
            this.Load += new System.EventHandler(this.ModifyAttendance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox days;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox classID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.CheckedListBox clb;
    }
}