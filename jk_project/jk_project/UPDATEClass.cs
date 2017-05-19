using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace jk_project
{
    class UPDATEClass
    {



        string connstring = ConfigurationManager.ConnectionStrings["kj"].ConnectionString;

        public string update_sepration(string[] data)
        {
            
             string x = "";
             SqlConnection conn = new SqlConnection(connstring);

             try
             {
                 SqlCommand cmd = new SqlCommand("UPDATINGCRYO", conn);
                 conn.Open();
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add("@cr_receiver_id", SqlDbType.NVarChar, 50).Value = data[0];
                 cmd.Parameters.Add("@cr_cryo", SqlDbType.NVarChar, 50).Value = data[1];
          



                 cmd.ExecuteNonQuery();
                 x = "Record inserted.....";


             }

             catch (Exception ex)
             {

                 x = "Record is not  inserted....." + ex.Message;

             }
             finally
             {
                 conn.Close();
             }
             return x;




        } //METHOD END.......


        public string update_REDCELL(string[] data)
        {

            string x = "";
            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATINGREDCELL", conn);
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@r_receiver_id", SqlDbType.NVarChar, 50).Value = data[0];
                cmd.Parameters.Add("@r_redcell_id", SqlDbType.NVarChar, 50).Value = data[1];




                cmd.ExecuteNonQuery();
                x = "Record inserted.....";

            
            }
            catch (Exception ex)
            {

                x = "Record is not  inserted....." + ex.Message;

            }
            finally
            {
                conn.Close();
            }
            return x;





        } //METHOD END...





        public string update_plasma(string[] data)
        {

            string x = "";
            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATINGplasma", conn);
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@plas_receiver_id", SqlDbType.NVarChar, 50).Value = data[0];
                cmd.Parameters.Add("@plas_redcell_id", SqlDbType.NVarChar, 50).Value = data[1];




                cmd.ExecuteNonQuery();
                x = "Record inserted.....";


            }
            catch (Exception ex)
            {

                x = "Record is not  inserted....." + ex.Message;

            }
            finally
            {
                conn.Close();
            }
            return x;





        } //METHOD END...




        public string update_plaettlates(string[] data)
        {

            string x = "";
            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                SqlCommand cmd = new SqlCommand("UPDATINGplatellates", conn);
                conn.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@plt_receiver_id", SqlDbType.NVarChar, 50).Value = data[0];
                cmd.Parameters.Add("@plt_redcell_id", SqlDbType.NVarChar, 50).Value = data[1];

                cmd.ExecuteNonQuery();
                x = "Record inserted.....";


            }
            catch (Exception ex)
            {

                x = "Record is not  inserted....." + ex.Message;

            }
            finally
            {
                conn.Close();
            }
            return x;

        } //METHOD END...







    }
}
