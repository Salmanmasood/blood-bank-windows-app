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
    public partial class Viewcs : Form
    {
        public Viewcs()
        {
            InitializeComponent();
        }

        private void Viewcs_Load(object sender, EventArgs e)
        {
            string Q1 = "select d_cnic,d_name,b_bag_id,b_donation_date from donors_details,BLOOD_BAGS where donors_details.d_cnic=BLOOD_BAGS.B_cnic";
            viewclass OB = new viewclass(Q1);
            dataGridView1.DataSource = OB.showrecords();
            
            
        }
    }
}
