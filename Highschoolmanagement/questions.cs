using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace Highschoolmanagement
{
    public partial class questions : Form
    {
        string constr = "server=localhost;uid=root;pwd=;database=qldl";
        MySqlConnection con;
        string query;
        MySqlCommand cmd;
        int i;
        string testcode;
        public questions(int i,string testcode)
        {
            InitializeComponent();
            this.i = i;
            this.testcode= testcode;
        }
        RadioButton rb1 = new RadioButton();
        RadioButton rb2 = new RadioButton();
        RadioButton rb3 = new RadioButton();
        RadioButton rb4 = new RadioButton();
        private void questions_Load(object sender, EventArgs e)
        {
            lb.Text = "Câu hỏi 1";
            rb1.AutoSize = false;
            rb1.Height = 19;
            rb1.Width = 85;
            fl.Controls.Add(rb1);
            rb2.AutoSize = false;
            rb2.Height = 19;
            rb2.Width = 85;
            fl.Controls.Add(rb2);
            rb3.AutoSize = false;
            rb3.Height = 19;
            rb3.Width = 85;
            fl.Controls.Add(rb3);
            rb4.AutoSize = false;
            rb4.Height = 19;
            rb4.Width = 85;
            fl.Controls.Add(rb4);
        }
        int count = 1;
        private void tt_Click(object sender, EventArgs e)
        { 
            con = new MySqlConnection(constr);
            con.Open();
            query = "insert into question(testcode,questioncontent,quanity) values ('"+testcode+"','"+an1.Text+"','"+i+"');";
            cmd = new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();
            
            if (rb1.Checked) { query = "insert into answer(questionID,correct,answercontent) values ((select questionID from question " +
                   "where testcode = '" + testcode + "' and questioncontent='" + an1.Text + "'),true,'" + an2.Text + "');"; } 
            else
            {
                query = "insert into answer(questionID,correct,answercontent) values ((select questionID from question " +
                   "where testcode = '" + testcode + "' and questioncontent='" + an1.Text + "'),false,'" + an2.Text + "');";
            }
            cmd.CommandText = query;
            try
            {
                cmd.ExecuteNonQuery();
            } catch { }
            if (rb2.Checked)
            {
                query = "insert into answer(questionID,correct,answercontent) values ((select questionID from question " +
                   "where testcode = '" + testcode + "' and questioncontent='" + an1.Text + "'),true,'" + an3.Text + "');";
            }
            else
            {
                query = "insert into answer(questionID,correct,answercontent) values ((select questionID from question " +
                   "where testcode = '" + testcode + "' and questioncontent='" + an1.Text + "'),false,'" + an4.Text + "');";
            }
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            if (rb3.Checked)
            {
                query = "insert into answer(questionID,correct,answercontent) values ((select questionID from question " +
                   "where testcode = '" + testcode + "' and questioncontent='" + an1.Text + "'),true,'" + an4.Text + "');";
            }
            else
            {
                query = "insert into answer(questionID,correct,answercontent) values ((select questionID from question " +
                   "where testcode = '" + testcode + "' and questioncontent='" + an1.Text + "'),false,'" + an5.Text + "');";
            }
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            if (rb4.Checked)
            {
                query = "insert into answer(questionID,correct,answercontent) values ((select questionID from question " +
                   "where testcode = '" + testcode + "' and questioncontent='" + an1.Text + "'),true,'" + an5.Text + "');";
            }
            else
            {
                query = "insert into answer(questionID,correct,answercontent) values ((select questionID from question " +
                   "where testcode = '" + testcode + "' and questioncontent='" + an1.Text + "'),false,'" + an2.Text + "');";
            }
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            if (count < i)
            {
                rb1.Checked = false;
                rb2.Checked = false;
                rb3.Checked = false;
                rb4.Checked = false;
                an1.Text = "";
                an2.Text = "";
                an3.Text = "";
                an4.Text = "";
                an5.Text = "";
                count++;
                lb.Text = "Câu hỏi " + Convert.ToString(count);
                fl.Controls.Add(rb1);
                fl.Controls.Add(rb2);
                fl.Controls.Add(rb3);
                fl.Controls.Add(rb4);
            }
            else
            {
                MessageBox.Show("Đã đủ câu hỏi!");
                this.Close();
            }
        }
    }
                
        }
