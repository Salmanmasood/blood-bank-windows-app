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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string[] data = new string[2];
        private void button1_Click(object sender, EventArgs e)
        {
            data[0] = textBox2.Text;
            data[1] = textBox1.Text;
            UPDATEClass ob = new UPDATEClass();
            ob.update_REDCELL(data);
            MessageBox.Show(ob.update_REDCELL(data));

        }

        private void Form5_Load(object sender, EventArgs e)
        {

            string Q1 = "SELECT r_redcell_id,r_expirydate,r_sentdate,r_blood_group FROM redcell WHERE r_receiver_id IS NULL";
            string Q2 = "SELECT r_redcell_id,r_expirydate,r_sentdate,r_blood_group FROM redcell WHERE r_receiver_id IS NOT NULL";
            viewclass OB = new viewclass(Q1);
            dataGridView1.DataSource = OB.showrecords();
            viewclass OB2 = new viewclass(Q2);
            dataGridView2.DataSource = OB2.showrecords();



        }
    }
}
