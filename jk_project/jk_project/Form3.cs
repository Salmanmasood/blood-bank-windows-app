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
    public partial class Form3 : Form
    {
        string []cryo=new string[5];
        string[] redcell = new string[5];
        string[] plasma = new string[5];
        string[] platelates = new string[5];
        string[] sepration = new string[5];
        string BAGID;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BAGID=textBox13.Text;
            cryo[0] = textBox1.Text;
            cryo[1] = textBox2.Text;
            cryo[2] = textBox3.Text;
            cryo[3] = comboBox2.SelectedItem.ToString();
            textBox4.Text = textBox3.Text; ;
            textBox7.Text = textBox3.Text; ;
            textBox10.Text = textBox3.Text; ;
            groupBox3.Enabled = true;

            if (checkBox1.Checked==true)
            {
                insertclasss I = new insertclasss();
                I.insert_WASTE(BAGID, "cryo", richTextBox1.Text, textBox2.Text);

            }

            else
            {
                insertclasss I = new insertclasss();
                I.insert_cryo(cryo);

            }


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox2.Items.Add("A+");
            comboBox2.Items.Add("AB+");
            comboBox2.Items.Add("A-");
            comboBox2.Items.Add("O+");
            comboBox2.Items.Add("O-");
            comboBox1.Items.Add("A+");
            comboBox1.Items.Add("AB+");
            comboBox1.Items.Add("A-");
            comboBox1.Items.Add("O+");
            comboBox1.Items.Add("O-");
            comboBox3.Items.Add("A+");
            comboBox3.Items.Add("AB+");
            comboBox3.Items.Add("A-");
            comboBox3.Items.Add("O+");
            comboBox3.Items.Add("O-");
            comboBox4.Items.Add("A+");
            comboBox4.Items.Add("AB+");
            comboBox4.Items.Add("A-");
            comboBox4.Items.Add("O+");
            comboBox4.Items.Add("O-");
            
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            textBox2.Text = System.DateTime.Now.ToString();
            textBox5.Text = System.DateTime.Now.ToString();
            textBox8.Text = System.DateTime.Now.ToString();
            textBox11.Text = System.DateTime.Now.ToString();

        
        }

        private void button2_Click(object sender, EventArgs e)
        {

            redcell[0] = textBox6.Text;
            redcell[1] = cryo[1];
            redcell[2] = cryo[2];
            redcell[3] = comboBox1.SelectedItem.ToString();
            groupBox5.Enabled = true;
            if (checkBox4.Checked == true)
            {
                insertclasss I = new insertclasss();
                I.insert_WASTE(BAGID, "Redcells", richTextBox2.Text, textBox2.Text);

            }

            else
            {
                insertclasss I = new insertclasss();
                I.insert_redcells(redcell);

            }

        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            plasma[0] = textBox12.Text;
            plasma[1] = cryo[1];
            plasma[2] = cryo[2];
            plasma[3] = comboBox4.SelectedItem.ToString();
            groupBox4.Enabled = true;

            if (checkBox8.Checked == true)
            {
                insertclasss I = new insertclasss();
                I.insert_WASTE(BAGID, "Plasma", richTextBox4.Text, textBox2.Text);

            }

            else
            {
                insertclasss I = new insertclasss();
                I.insert_plasma(plasma);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            platelates[0] = textBox9.Text;
            platelates[1] = cryo[1];
            platelates[2] = cryo[2];
            platelates[3] = comboBox3.SelectedItem.ToString();

            if (checkBox8.Checked == true)
            {
                insertclasss I = new insertclasss();
                I.insert_WASTE(BAGID, "Platelets", richTextBox3.Text, textBox2.Text);

            }

            else
            {
                insertclasss I = new insertclasss();
                I.insert_paltelates(platelates);
            }

            sepration[0] = BAGID;
            sepration[1] = textBox1.Text;

            sepration[2] = textBox9.Text;
            sepration[3] = textBox12.Text;
            sepration[4] = textBox6.Text;
            insertclasss yI = new insertclasss();
            yI.insert_sepration(sepration);





        }

        

        
    }
}
