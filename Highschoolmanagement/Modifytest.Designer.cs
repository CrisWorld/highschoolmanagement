namespace Highschoolmanagement
{
    partial class Modifytest
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.testcode = new System.Windows.Forms.TextBox();
            this.questionID = new System.Windows.Forms.TextBox();
            this.questioncontent = new System.Windows.Forms.TextBox();
            this.answercontent = new System.Windows.Forms.TextBox();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.answerrr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "QuestionID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nội dung câu trả lời";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nội dung câu hỏi";
            // 
            // testcode
            // 
            this.testcode.Location = new System.Drawing.Point(18, 46);
            this.testcode.Name = "testcode";
            this.testcode.Size = new System.Drawing.Size(100, 20);
            this.testcode.TabIndex = 5;
            // 
            // questionID
            // 
            this.questionID.Location = new System.Drawing.Point(50, 110);
            this.questionID.Name = "questionID";
            this.questionID.ReadOnly = true;
            this.questionID.Size = new System.Drawing.Size(100, 20);
            this.questionID.TabIndex = 6;
            // 
            // questioncontent
            // 
            this.questioncontent.Location = new System.Drawing.Point(12, 173);
            this.questioncontent.Name = "questioncontent";
            this.questioncontent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.questioncontent.Size = new System.Drawing.Size(195, 20);
            this.questioncontent.TabIndex = 7;
            // 
            // answercontent
            // 
            this.answercontent.Location = new System.Drawing.Point(12, 228);
            this.answercontent.Name = "answercontent";
            this.answercontent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.answercontent.Size = new System.Drawing.Size(195, 20);
            this.answercontent.TabIndex = 8;
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.answerrr,
            this.answers});
            this.dgv3.Location = new System.Drawing.Point(535, 46);
            this.dgv3.Name = "dgv3";
            this.dgv3.Size = new System.Drawing.Size(253, 361);
            this.dgv3.TabIndex = 12;
            this.dgv3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv3_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(124, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv2
            // 
            this.dgv2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1});
            this.dgv2.Location = new System.Drawing.Point(241, 46);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(268, 361);
            this.dgv2.TabIndex = 11;
            this.dgv2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv2_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "questionID";
            this.ID.HeaderText = "Question ID";
            this.ID.Name = "ID";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "questioncontent";
            this.Column1.HeaderText = "Nội dung câu hỏi";
            this.Column1.Name = "Column1";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(62, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // answerrr
            // 
            this.answerrr.DataPropertyName = "answerID";
            this.answerrr.HeaderText = "Answer ID";
            this.answerrr.Name = "answerrr";
            // 
            // answers
            // 
            this.answers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.answers.DataPropertyName = "answercontent";
            this.answers.HeaderText = "Nội dung câu trả lời";
            this.answers.Name = "answers";
            // 
            // Modifytest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 456);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv3);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.answercontent);
            this.Controls.Add(this.questioncontent);
            this.Controls.Add(this.questionID);
            this.Controls.Add(this.testcode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Modifytest";
            this.Text = "Modifytest";
            this.Load += new System.EventHandler(this.Modifytest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox testcode;
        private System.Windows.Forms.TextBox questionID;
        private System.Windows.Forms.TextBox questioncontent;
        private System.Windows.Forms.TextBox answercontent;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerrr;
        private System.Windows.Forms.DataGridViewTextBoxColumn answers;
    }
}