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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string Q1 = "select cr_cryo,cr_expirydate,cr_sentdate,cr_blood_group from cryo WHERE cr_receiver_id IS NULL";
            string Q2 = "select cr_cryo,cr_expirydate,cr_sentdate,cr_blood_group from cryo WHERE cr_receiver_id IS NOT NULL";
            viewclass OB = new viewclass(Q1);
            dataGridView1.DataSource = OB.showrecords();
            viewclass OB2 = new viewclass(Q2);
            dataGridView2.DataSource = OB2.showrecords();



        }
        string[] data = new string[2];
        private void button1_Click(object sender, EventArgs e)
        {
            data[0] = textBox2.Text;
            data[1] = textBox1.Text;
            UPDATEClass ob = new UPDATEClass();
            ob.update_sepration(data);
            MessageBox.Show(ob.update_sepration(data));


        }
    }
}
