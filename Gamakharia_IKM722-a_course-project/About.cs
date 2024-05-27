using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamakharia_IKM722_a_course_project
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void tAbout_Tick(object sender, EventArgs e)
        {
            Close();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();

        }
    }
}
