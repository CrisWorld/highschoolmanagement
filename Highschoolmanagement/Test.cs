using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Highschoolmanagement
{
    public partial class Test : Form
    {
        bool Check(string name, Form parent)
        {
            foreach (Form form in parent.MdiChildren)
            {
                if (form.Name == name) { form.Activate(); return true; }
            }
            return false;
        }
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ok = 0;
            foreach (Form form1 in this.MdiChildren)
            {
                if (form1.Name == "CreateTest")
                {
                    form1.Activate();
                    ok = 1;
                    break;
                }
            }
            if (ok == 0)
            {
                CreateTest form = new CreateTest();
                form.MdiParent = this.ParentForm;
                form.Name = "CreateTest";
                form.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Check("Modifytest", this.ParentForm))
            {
                Modifytest form = new Modifytest();
                form.MdiParent = this.ParentForm;
                form.Name = "Modifytest";
                form.Show();
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {
            //constr = "server=localhost;uid=root;pwd=;database=qldl;";
            //MySqlConnection con = new MySqlConnection(constr);
            //con.Open();
            //MySqlCommand cmd = con.CreateCommand();
            //query = "delete from test where testcode = '" + tb1.Text + "';";
            //cmd.CommandText = query;
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Bài kiểm tra chưa có câu hỏi! vui lòng tạo lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Check("PreviewTest", this.ParentForm))
            {
                PreviewTest form = new PreviewTest();
                form.MdiParent = this.ParentForm;
                form.Name = "PreviewTest";
                form.Show();
            }
        }
    }
}
