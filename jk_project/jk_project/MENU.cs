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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            log_in ob = new log_in();
            ob.Show();
            this.Hide();
           // ob.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LOG_IN_LAB ob = new LOG_IN_LAB();
            ob.Show();
            this.Hide();
           
        }
    }
}
