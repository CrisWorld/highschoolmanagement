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
    public partial class CreateTest : Form
    {
        string constr = "server=localhost;uid=root;pwd=;database=qldl";
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        string query;
        DataTable data = new DataTable();
        DataGridView dgv = new DataGridView();
        void loaddata()
        {
            cmd = con.CreateCommand();
            string select_query = "select * from teacher;";
            cmd.CommandText = select_query;
            adapter.SelectCommand = cmd;
            data.Clear();
            adapter.Fill(data);

            dgv.DataSource = data;
        }
        public CreateTest()
        {
            InitializeComponent();
        }

        private void C_Click(object sender, EventArgs e)
        {
            if ((tb1.Text == "" ) || (tb2.Text == "") || (tb3.Text == "") || (tb4.Text == "") || (tb5.Text == "") || (tb6.Text == ""))
            {
                MessageBox.Show("Dữ liệu chưa đầy đủ!");
            }
            else
            {
                con = new MySqlConnection(constr); con.Open();
                query = "insert into test(testcode,testname,password,duration,classID,amountofquestions) " +
                    "values ('" + tb1.Text + "','" + tb2.Text + "','" + tb3.Text + "','" + tb4.Text + "','" + tb5.Text + "','" + tb6.Text + "');";
                cmd = new MySqlCommand(query, con);
                try
                {
                    cmd.ExecuteNonQuery();
                    questions question = new questions(Convert.ToInt32(tb6.Text), tb1.Text);
                    question.Name = "Question";
                    question.MdiParent = this.ParentForm;
                    question.Show();
                } catch (Exception ex) 
                {
                    MessageBox.Show("Lỗi kết nối hoặc Test code đã tồn tại hoặc Class ID không tồn tại!","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            
        }

        private void CreateTest_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
            con.Open();
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
