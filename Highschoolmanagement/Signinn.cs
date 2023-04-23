using HighSchool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HighSchool;
using MySql.Data.MySqlClient;

namespace Highschoolmanagement
{
    public partial class Signinn : Form
    {
        public Signinn()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void enterbutton_Click(object sender, EventArgs e)
        {
            string constr = "server=localhost;uid=root;pwd=;database=qldl;";
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = constr;
            conn.Open();
            string query = "select * from teacher where username='" + tk1.Text + "' and pwd='" + password.Text + "';";
            MySqlCommand cmd = new MySqlCommand(query,conn);
            MySqlDataReader dr = cmd.ExecuteReader();
                try { 
                     if (dr.HasRows)
            {   
                    MessageBox.Show("Đăng Nhập Thành Công!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    Teacher form2 = new Teacher();
                    form2.Show();
                    this.Hide();
                    conn.Close();
                }
                else MessageBox.Show("Sai mật khẩu hoặc sai tài khoản!","Sai",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Signinn_Load(object sender, EventArgs e)
        {

        }
    }
}
