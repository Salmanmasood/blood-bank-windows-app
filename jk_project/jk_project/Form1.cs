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
    public partial class Form1 : Form
    {
        string D;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            comboBox2.Items.Add("A+");
            comboBox2.Items.Add("AB+");
            comboBox2.Items.Add("A-");
            comboBox2.Items.Add("O+");
            comboBox2.Items.Add("O-");
            textBox4.Text = System.DateTime.Now.ToString();


            D = textBox4.Text;

            string q = "select * from donors_details";
            viewclass ob = new viewclass(q);
            dataGridView1.DataSource = ob.showrecords();




        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] BAG = new string[4];
            string[] biodata = new string[6];
            biodata[0] = textBox1.Text;
            biodata[1] = textBox2.Text;
            biodata[2] = textBox3.Text;
            biodata[3] = comboBox1.SelectedItem.ToString();
            biodata[4] = textBox5.Text;
            biodata[5] = comboBox2.SelectedItem.ToString();
            BAG[0] = biodata[1];
            BAG[1] = D;
            BAG[2] = textBox6.Text;
            BAG[3] = textBox7.Text;
            insertclasss i = new insertclasss();
            string c = i.insertdonor_details(biodata);

            MessageBox.Show(c);
            c = i.insertbloogbagrecord(BAG);
            MessageBox.Show(c);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Viewcs ob = new Viewcs();
            ob.Show();
        }

        //private void groupBox2_Enter(object sender, EventArgs e)
        //{

        //}
    }
}
