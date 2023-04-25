using System;
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
    public partial class Teacher : Form
    {
        bool check(string name, Form parent)
        {
            foreach (Form form1 in parent.MdiChildren)
            {
                if (form1.Name == name) { form1.Activate(); return true; break; } 
            }
            return false;
        }
        public Teacher()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
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
            if(!check("Attendance", this)) 
            {
                Attendance form = new Attendance();
                form.MdiParent = this;
                form.Name = "Attendance";
                form.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!check("ModifyAttendance", this))
            {
                ModifyAttendance form = new ModifyAttendance();
                form.MdiParent = this;
                form.Name = "ModifyAttendance";
                form.Show();
            }
        }
    }

   
}
