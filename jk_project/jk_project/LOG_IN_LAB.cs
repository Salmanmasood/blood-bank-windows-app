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
    public partial class LOG_IN_LAB : Form
    {
        public LOG_IN_LAB()
        {
            InitializeComponent();
        }

        private void LOG_IN_LAB_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string USER = "LAB";
            string PAS = "123";
            if (USER == "LAB" && PAS == "123")
            {
                Form3 ob = new Form3();
                ob.Show();
                this.Hide();
                //ob.Close();
            }

            else
            {

                MessageBox.Show("INVALID PASWORD!!");
            }
        }
    }
}
