using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;

namespace Highschoolmanagement
{
    public partial class Teacher : Form
    {
        string password;
        string username;
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        string query;
        string constr="server=localhost;uid=root;pwd=;database=qldl";
        bool check(string name, Form parent)
        {
            foreach (Form form1 in parent.MdiChildren)
            {
                if (form1.Name == name) { form1.Activate(); return true; break; } 
            }
            return false;
        }
        public Teacher(string username,string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fl.Hide();
            changepassword.Hide();
            fl2.Hide();
            panel1.Hide();
            if (!check("Test",this))
            {
                Test form = new Test();
                form.MdiParent = this;
                form.Name = "Test";
                form.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fl.Hide();
            changepassword.Hide();
            fl2.Hide();
            panel1.Hide();
            if (!check("Attendance", this)) 
            {
                Attendance form = new Attendance();
                form.MdiParent = this;
                form.Name = "Attendance";
                form.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            fl.Hide();
            fl.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            fl.Hide();
            changepassword.Hide();
            fl2.Hide();
            panel1.Hide();
            if (!check("ModifyAttendance", this))
            {
                ModifyAttendance form = new ModifyAttendance();
                form.MdiParent = this;
                form.Name = "ModifyAttendance";
                form.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            fl.Hide();
            changepassword.Hide();
            fl2.Hide();
            panel1.Hide();
            fl2.Show();
            con = new MySqlConnection(constr);
            con.Open();
            query = "select fullname,teacherID,username,address,phonenumber,birthday,email,subjectname from teacher as t, subject as s where username = '" + username + "' and t.subjectID=s.subjectID;";
            cmd = new MySqlCommand(query,con);
            reader = cmd.ExecuteReader();
            reader.Read();
            string teachercode = reader.GetString(1);
            fullname.Text ="Họ tên: " + reader.GetString(0);
            teacherID.Text ="Teacher ID: "+ reader.GetString(1);
            usern.Text ="Username: "+ reader.GetString(2);
            address.Text ="Địa chỉ: "+ reader.GetString(3);
            phonenumber.Text ="Số điện thoại: "+ reader.GetString(4);
            birthday.Text ="Ngày sinh: "+ reader.GetDateTime(5).ToString("yyyy-MM-dd");
            email.Text ="Email: "+ reader.GetString(6);
            Subject.Text ="Môn dạy: "+  reader.GetString(7);
            reader.Close();
            cmd.CommandText = "select classname from class as c,teacher as t where mainteacherID='" + teachercode + "';";
            reader= cmd.ExecuteReader();
            if (reader.Read())
            {
                mainteacher.Text="Chủ nhiệm lớp: "+ reader.GetString(0);
            }
            reader.Close();
            con.Close();
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            fl.Hide();
            changepassword.Hide();
            fl2.Hide();
            panel1.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            fl.Hide();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            fl.Hide();
            changepassword.Hide();
            fl2.Hide();
            panel1.Hide();
            changepassword.Show();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (oldpassword.Text==password && newpassword.Text == newpassword1.Text)
            {
                query = "update teacher set pwd = '" + newpassword.Text + "' where username = '" + username + "';";
                con = new MySqlConnection(constr);
                con.Open();
                cmd = new MySqlCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thay đổi thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show("Không thể kết nối với cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                
                con.Close();
            }
            else if (!(oldpassword.Text == password)) { MessageBox.Show("Mật khẩu cũ không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else { MessageBox.Show("Mật khẩu xác nhận không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void changepassword_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            fl.Hide();
            changepassword.Hide();
            fl2.Hide();
            panel1.Hide();
            panel1.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
            con.Open();
            query = "select slot,classname from timetable2 as t1, teachingschedule as t2, class as c where t1.teachingscheduleID=t2.teachingscheduleID and dateinfo='"+time.Value.ToString("yyyy-MM-dd")+"' and t1.classID=c.classID "+
"order by slot asc;";
            cmd = new MySqlCommand(query, con);
            adapter = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);
            dataGridView1.DataSource= dt;
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Signinn form = new Signinn();
            form.Show();
            this.Hide();
        }

        private void fl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

   
}
