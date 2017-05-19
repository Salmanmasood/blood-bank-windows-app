using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace jk_project
{
    class viewclass
    {
        private string connstring = ConfigurationManager.ConnectionStrings["kj"].ConnectionString;
        private string query;

        public viewclass(string q)
        {

            this.query = q;

        }


        public DataTable showrecords()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();

                SqlDataReader dr = cmd.ExecuteReader(); //line by line reading

                if (dr.HasRows)
                {
                    dt.Load(dr);
                }

            }

            catch (Exception)
            {
                MessageBox.Show("no records were found!!");

            }

            finally 
            {
                conn.Close();

            }

            return dt;
        }


    }
}
