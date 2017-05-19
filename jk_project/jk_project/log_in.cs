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
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string USER = "ADMIN";
            string PAS = "123";
            if (USER == "ADMIN" && PAS == "123")
            {
                mainform ob = new mainform();
                ob.Show();
                this.Hide();
                //ob.Close();
            }

            else {

                MessageBox.Show("INVALID PASWORD!!");
            }
        }
    }
}
