using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jk_project
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            ob.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 ob = new Form2();
            ob.Show();


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 ob = new Form4();
            ob.Show();


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form5 ob = new Form5();
            ob.Show();


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form6 ob = new Form6();
            ob.Show();


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form7 ob = new Form7();
            ob.Show();


        }




    }
}
