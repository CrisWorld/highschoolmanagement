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

            ListAccounts list = new ListAccounts();
            Person a = new Student("Nguyen Minh Hoang Quoc", "quochoang", "0122642359", "Dia chi hgehe", "Nam", "0775771042", DateTime.Parse("01/01/2004"), "quoch147@gmail.com", "DE180909");
            Person b = new HighSchool.Teacher("Nguyen Minh Hoang Quoc", "quochoang1", "0122642359", "Dia chi hgehe", "Nam", "0775771042", DateTime.Parse("01/01/2004"), "quoch147@gmail.com", "FA108909", "1");
            list.accounts.Add("quochoang", a);
            list.accounts.Add("quochoang1", b);
            if (list.CheckUserName(tk1.Text))
            {
                if (list.CheckLogin(tk1.Text, password.Text)) 
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    Teacher form2 = new Teacher();
                    form2.Show();
                    this.Hide();
                } else MessageBox.Show("Sai mat khau!");

            }
            else MessageBox.Show("Tai khoan khong ton tai!","Error");
        }
    }
}
