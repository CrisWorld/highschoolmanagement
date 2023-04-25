using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Highschoolmanagement
{
    public partial class PreviewTest : Form
    {
        string constr = "server=localhost;uid=root;pwd=;database=qldl;";
        string query;
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlCommand cmd2;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        public PreviewTest()
        {
            InitializeComponent();
        }

        private void PreviewTest_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void find_Click(object sender, EventArgs e)
        {
            query = "select testcode,password,testname,duration from test where testcode='" + testcode.Text + "' and password = '" + password.Text + "';";
            conn = new MySqlConnection(constr);     
            conn.Open();
            cmd = new MySqlCommand(query, conn);
            reader = cmd.ExecuteReader();
            if (reader.Read()) {
                find.Enabled = false;
                MessageBox.Show("Đã tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lb3.Text = lb3.Text + reader.GetString(3);
                lb4.Text = lb4.Text + reader.GetString(2);
                reader.Close();
                cmd.CommandText = "select q.questionID,q.questioncontent,a.answercontent from question as q,answer as a where testcode='"+testcode.Text+"' and a.questionID=q.questionID;";
                reader = cmd.ExecuteReader();
                int count = 0;
                fl.AutoScroll= true;
                while (reader.Read())
                {
                    DataTable data= new DataTable();
                    count++;
                    FlowLayoutPanel flow = new FlowLayoutPanel();
                    flow.WrapContents = false;
                    flow.FlowDirection = FlowDirection.TopDown;
                    flow.AutoSize = true;
                    Label lb = new Label();
                    lb.Text = "Câu " + count.ToString() + ": " + reader.GetString(1);
                    flow.Controls.Add(lb);
                    RadioButton rb = new RadioButton();
                    rb.Text = reader.GetString(2);
                    flow.Controls.Add(rb);
                    for (int i = 0; i < 3; i++)
                    {
                        reader.Read();
                        rb = new RadioButton();
                        rb.AutoSize = true; 
                        rb.Text = reader.GetString(2);
                        flow.Controls.Add(rb);
                    }
                    fl.Controls.Add(flow);
                    fl.AutoScroll= true;
                }
                reader.Close() ;
            } else { MessageBox.Show("Không tồn tại hoặc sai mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            conn.Close();
            
        }

        private void comeback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
