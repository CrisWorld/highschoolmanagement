using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Highschoolmanagement
{
    public partial class Modifytest : Form
    {
        string constr = "server=localhost;uid=root;pwd=;database=qldl;";
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        string query;
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        public Modifytest()
        {
            InitializeComponent();
        }
        
        private void Modifytest_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            con = new MySqlConnection(constr);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = "select testcode from test where testcode = '" + testcode.Text + "';";
            cmd = new MySqlCommand(query,con);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (!(reader.Read())) { MessageBox.Show("Không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); reader.Close(); }
            else
            {
                reader.Close();
                query = "select questionID,questioncontent from question as q where q.testcode='"+testcode.Text+"';";
                adapter = new MySqlDataAdapter(query, con);
                if (adapter != null)
                {
                    adapter.Fill(dt1);
                }
                dgv2.DataSource = dt1;
                try
                {
                    questionID.Text = dgv2.Rows[0].Cells[0].Value.ToString();
                    questioncontent.Text = dgv2.Rows[0].Cells[1].Value.ToString();
                    query = "select answerID,answercontent from answer as a where a.questionID='" + dgv2.Rows[0].Cells[0].Value.ToString() + "';";
                    adapter = new MySqlDataAdapter(query, con);
                    if (adapter != null)
                    {
                        adapter.Fill(dt2);
                    }
                    dgv3.DataSource = dt2;
                    answercontent.Text = dgv3.Rows[0].Cells[1].Value.ToString();
                    button2.Enabled = true;
                    button1.Enabled = false;
                }
                catch 
                {
                    query = "delete from test where testcode = '" + testcode.Text + "';";
                    cmd.CommandText= query;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bài kiểm tra chưa có câu hỏi! vui lòng tạo lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
                
        }

        private void dgv2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            dt2 = new DataTable(); 
            i = dgv2.CurrentRow.Index;
            questionID.Text = dgv2.Rows[i].Cells[0].Value.ToString();
            questioncontent.Text = dgv2.Rows[i].Cells[1].Value.ToString();
            query = "select answerID,answercontent from answer as a where a.questionID='" + dgv2.Rows[i].Cells[0].Value.ToString() +"';";
            adapter = new MySqlDataAdapter(query, con);
            if (adapter != null)
            {
                adapter.Fill(dt2);
            }
            dgv3.DataSource = dt2;
            answercontent.Text = dgv3.Rows[0].Cells[1].Value.ToString();
        }

        private void dgv3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv3.CurrentRow.Index;
            answercontent.Text = dgv3.Rows[i].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                int i;
                i = dgv3.CurrentRow.Index;
                query = "update question set questioncontent = '" + questioncontent.Text + "' " +
                    "where questionID = '" + questionID.Text + "';";
                cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();
                query = "update answer as a set answercontent='" + answercontent.Text + "' " +
                    "where answerID='" + dgv3.Rows[i].Cells[0].Value.ToString() + "';";
                cmd = new MySqlCommand(query, con);
                cmd.ExecuteNonQuery();

                dt2 = new DataTable();
                dt1 = new DataTable();
                query = "select questionID,questioncontent from question as q where q.testcode='" + testcode.Text + "';";
                adapter = new MySqlDataAdapter(query, con);
                if (adapter != null)
                {
                    adapter.Fill(dt1);
                }
                dgv2.DataSource = dt1;
                i = dgv2.CurrentRow.Index;
                query = "select answerID,answercontent from answer as a where a.questionID='" + dgv2.Rows[i].Cells[0].Value.ToString() + "';";
                adapter = new MySqlDataAdapter(query, con);
                if (adapter != null)
                {
                    adapter.Fill(dt2);
                }
                dgv3.DataSource = dt2;
                questionID.Text = dgv2.Rows[0].Cells[0].Value.ToString();
                answercontent.Text = dgv3.Rows[0].Cells[1].Value.ToString();
                questioncontent.Text = dgv2.Rows[0].Cells[1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
