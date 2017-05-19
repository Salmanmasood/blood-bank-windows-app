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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        string[] data = new string[2];
        
        private void button1_Click(object sender, EventArgs e)
        {
            data[0] = textBox2.Text;
            data[1] = textBox1.Text;
            UPDATEClass ob = new UPDATEClass();
            ob.update_plaettlates(data);
            MessageBox.Show(ob.update_plaettlates(data));
        
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            string Q1 = "select plt_redcell_id,plt_expirydate,plt_sentdate,plt_blood_group from palatelates where plt_receiver_id is null";
            string Q2 = "select plt_redcell_id,plt_expirydate,plt_sentdate,plt_blood_group from palatelates where plt_receiver_id is not null";
            viewclass OB = new viewclass(Q1);
            dataGridView1.DataSource = OB.showrecords();
            viewclass OB2 = new viewclass(Q2);
            dataGridView2.DataSource = OB2.showrecords();

        }
    }
}
