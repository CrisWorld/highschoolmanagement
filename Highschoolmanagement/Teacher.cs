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
        public Teacher()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Test form2 = new Test();
            form2.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendance form = new Attendance();
            form.Show();
        }
    }
}
