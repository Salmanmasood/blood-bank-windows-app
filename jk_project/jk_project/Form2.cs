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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] biodata = new string[6];
            biodata[0] = textBox1.Text;
            biodata[1] = textBox2.Text;
            biodata[2] = textBox3.Text;
            biodata[3] = comboBox1.SelectedItem.ToString();
            biodata[4] = textBox5.Text;
            biodata[5] = comboBox2.SelectedItem.ToString();


            insertclasss i = new insertclasss();
            string c = i.insert_receiver_details(biodata);
            MessageBox.Show(c);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            comboBox2.Items.Add("A+");
            comboBox2.Items.Add("AB+");
            comboBox2.Items.Add("A-");
            comboBox2.Items.Add("O+");
            comboBox2.Items.Add("O-");

        }
    }
}
