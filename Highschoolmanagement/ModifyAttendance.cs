using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Highschoolmanagement
{ 
    public partial class ModifyAttendance : Form
    {
        string constr = "server=localhost;uid=root;pwd=;database=qldl";
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        public ModifyAttendance()
        {
            InitializeComponent();
        }

        private void find_Click(object sender, EventArgs e)
        {
            clb.Items.Clear();
            con.ConnectionString= constr;
            con.Open();
            string query = "select attendancelistID from attendancelist where days = '" + days.Text + "' and classID = '" + classID.Text + "';";
            cmd.Connection = con;
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("Đã tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                save.Enabled = true;
                reader.Read();
                string id = reader.GetString(0);
                reader.Close();
                query = "select fullname,checked,s.studentID from student as s,attendance as a where a.attendancelistID = " + id + " and a.studentID = s.studentID;";
                cmd = new MySqlCommand(query,con);
                reader = cmd.ExecuteReader();
                int count = -1;
                while (reader.Read()) 
                {
                    count++;
                    string i = reader.GetString(1);
                    if (i == "1")
                    { 
                        clb.Items.Add(reader.GetString(0));
                        clb.SetItemChecked(count, true);
                    }
                    else { clb.Items.Add(reader.GetString(0)); 
                        clb.SetItemChecked(count, false); }
                }
            } else { MessageBox.Show("Không tìm thấy", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); clb.Items.Clear(); save.Enabled = false;  }
            reader.Close();
            con.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            con.ConnectionString = constr;
            con.Open();
            string query = "select attendancelistID from attendancelist where days = '" + days.Text + "' and classID = '" + classID.Text + "';";
            cmd.Connection = con;
            cmd.CommandText = query;
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string id = reader.GetString(0);
            reader.Close();
            foreach (var check in clb.Items)
            { 
                query = "update attendance set checked='0' where studentID = (select studentID from student where fullname='"+clb.GetItemText(check)+"');";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            foreach (var check in clb.CheckedItems)
            {
                query = "update attendance set checked='1' where studentID = (select studentID from student where fullname='" + clb.GetItemText(check) + "');";
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }
        private void ModifyAttendance_Load(object sender, EventArgs e)
        {
            save.Enabled = false;
        }
    }
}
