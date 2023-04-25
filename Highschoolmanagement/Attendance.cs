using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HighSchool;
using MySql.Data.MySqlClient;

namespace Highschoolmanagement
{
    public partial class Attendance : Form
    {
        string constr = "server=localhost;uid=root;pwd=;database=qldl";
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        List<string> list = new List<string>();
        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            lb3.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clb.Items.Clear();
            DataTable data = new DataTable();
            string select_query = "select * from class where classID='" + textBox1.Text + "';";
            con.ConnectionString = constr;
            con.Open();
            cmd = new MySqlCommand(select_query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Đã tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                select_query = "select fullname,studentID from student as st,class as cl where st.classID=cl.classID;";
                if (reader.HasRows == false) { MessageBox.Show("Lớp chưa có học sinh!"); reader.Close(); }
                else
                {
                    reader.Close();
                    cmd = new MySqlCommand(select_query, con);
                    MySqlDataReader reader2 = cmd.ExecuteReader();
                    while (reader2.Read())
                    {
                        var fullname = reader2.GetString(0);
                        var studentID = reader2.GetString(1);
                        list.Add(studentID);
                        clb.Items.Add(fullname);
                    }
                }

                //cmd = new MySqlCommand(select_query,con);
            }
            else MessageBox.Show("Không tìm thấy lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string select_query = "select attendancelistID from attendancelist where days = '" + lb3.Text + "' and classID = '" + textBox1.Text + "';";
            con.ConnectionString = constr;
            con.Open();
            cmd = new MySqlCommand(select_query, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) { reader.Close(); MessageBox.Show("Bạn đã điểm danh hôm nay rồi !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                select_query = "insert into attendancelist(days,classID) values ('" + lb3.Text + "','" + textBox1.Text + "');";
                reader.Close();
                cmd = new MySqlCommand(select_query, con);
                cmd.ExecuteNonQuery();
                int count = 0;
                foreach (var item in clb.Items)
                {

                    select_query = "insert into attendance(attendancelistID,studentID,checked) values ((select attendancelistID from attendancelist where classID='" + textBox1.Text + "' and days='" + lb3.Text + "'),'" + list[count] + "','0');";
                    count++;
                    cmd = new MySqlCommand(select_query, con);
                    cmd.ExecuteNonQuery();
                }
                count = 0;
                foreach (var item in clb.CheckedItems)
                {
                    select_query = "update attendance set checked='1' where studentID='" + list[count] + "';";
                    count++;
                    cmd = new MySqlCommand(select_query, con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }
    }
}
