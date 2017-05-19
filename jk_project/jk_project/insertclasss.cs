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
    class insertclasss
    {
        string connstring = ConfigurationManager.ConnectionStrings["kj"].ConnectionString;

         public string insertdonor_details(string[] biodata)
    {
        string x = "";
        SqlConnection conn = new SqlConnection(connstring);

        try
        {
            SqlCommand cmd = new SqlCommand("insert_donors_details", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@d_name", SqlDbType.NVarChar, 50).Value = biodata[0];
            cmd.Parameters.Add("@d_address", SqlDbType.NVarChar, 50).Value = biodata[2];
            cmd.Parameters.Add("@d_telephone#", SqlDbType.NVarChar, 50).Value = biodata[4];
            cmd.Parameters.Add("@d_gender", SqlDbType.NVarChar, 50).Value = biodata[3];
            cmd.Parameters.Add("@d_cnic", SqlDbType.NVarChar, 50).Value = biodata[1];
            cmd.Parameters.Add("@d_bloodtype", SqlDbType.NVarChar, 50).Value = biodata[5];

            conn.Open();
            cmd.ExecuteNonQuery();
            x = "Record inserted.....";



        }
        catch(Exception)
        {

            x = "Record is not  inserted.....";

        }
        finally
        {
            conn.Close();
        }

        return x;
    } //method end....

         public string insert_receiver_details(string[] biodata)
         {
             string x = "";
             SqlConnection conn = new SqlConnection(connstring);

             try
             {
                 SqlCommand cmd = new SqlCommand("INSERTING_RECEIVER_DETAILS", conn);
                 conn.Open();
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add("@r_name", SqlDbType.NVarChar, 50).Value = biodata[0];
                 cmd.Parameters.Add("@r_address", SqlDbType.NVarChar, 50).Value = biodata[2];
                 cmd.Parameters.Add("@r_telephone#", SqlDbType.NVarChar, 50).Value = biodata[4];
                 cmd.Parameters.Add("@r_gender", SqlDbType.NVarChar, 50).Value = biodata[3];
                 cmd.Parameters.Add("@r_cnic", SqlDbType.NVarChar, 50).Value = biodata[1];
                 cmd.Parameters.Add("@r_bloodtype", SqlDbType.NVarChar, 50).Value = biodata[5];


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
         } //method end....



         public string insertbloogbagrecord(string[] bag_record)
         {
             string x = "";
             SqlConnection conn = new SqlConnection(connstring);

             try
             {
                 SqlCommand cmd = new SqlCommand("inserting_BLOOD_BAGS", conn);
                 conn.Open();
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add("@B_cnic", SqlDbType.NVarChar, 50).Value = bag_record[0];
                 cmd.Parameters.Add("@b_donation_date", SqlDbType.NVarChar, 50).Value = bag_record[1];
                 cmd.Parameters.Add("@b_bagvolume", SqlDbType.Int).Value = bag_record[2];
                 cmd.Parameters.Add("@b_bag_id", SqlDbType.NVarChar, 50).Value = bag_record[3];


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
         }//method end....

         public string insert_cryo(string[]data)
         { 

         string x = "";
             SqlConnection conn = new SqlConnection(connstring);

             try
             {
                 SqlCommand cmd = new SqlCommand("inserting_cryo2", conn);
                 conn.Open();
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add("@cr_cryo", SqlDbType.NVarChar, 50).Value = data[0];
                 cmd.Parameters.Add("@cr_sentdate", SqlDbType.NVarChar, 50).Value = data[1];
                 cmd.Parameters.Add("@cr_expirydate", SqlDbType.NVarChar, 50).Value = data[2];
                 cmd.Parameters.Add("@cr_blood_group", SqlDbType.NVarChar, 50).Value = data[3];
               //  cmd.Parameters.Add("@cr_receiver_id", SqlDbType.NVarChar, 50).Value = " ";

            
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
         } //method end


         public string insert_redcells(string[] data)
         {

             string x = "";
             SqlConnection conn = new SqlConnection(connstring);

             try
             {
                 SqlCommand cmd = new SqlCommand("inserting_redcell2", conn);
                 conn.Open();
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add("@r_redcell_id", SqlDbType.NVarChar, 50).Value = data[0];
                 cmd.Parameters.Add("@r_sentdate", SqlDbType.NVarChar, 50).Value = data[1];
                 cmd.Parameters.Add("@r_expirydate", SqlDbType.NVarChar, 50).Value = data[2];
                 cmd.Parameters.Add("@r_blood_group", SqlDbType.NVarChar, 50).Value = data[3];


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
         } //method end



         public string insert_plasma(string[] data)
         {

             string x = "";
             SqlConnection conn = new SqlConnection(connstring);

             try
             {
                 SqlCommand cmd = new SqlCommand("inserting_plasma2", conn);
                 conn.Open();
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add("@plas_redcell_id", SqlDbType.NVarChar, 50).Value = data[0];
                 cmd.Parameters.Add("@plas_sentdate", SqlDbType.NVarChar, 50).Value = data[1];
                 cmd.Parameters.Add("@plas_expirydate", SqlDbType.NVarChar, 50).Value = data[2];
                 cmd.Parameters.Add("@plas_blood_group", SqlDbType.NVarChar, 50).Value = data[3];


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
         } //method end


         public string insert_paltelates(string[] data)
         {

             string x = "";
             SqlConnection conn = new SqlConnection(connstring);

             try
             {
                 SqlCommand cmd = new SqlCommand("inserting_palatelates2", conn);
                 conn.Open();
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add("@plt_redcell_id", SqlDbType.NVarChar, 50).Value = data[0];
                 cmd.Parameters.Add("@plt_sentdate", SqlDbType.NVarChar, 50).Value = data[1];
                 cmd.Parameters.Add("@plt_expirydate", SqlDbType.NVarChar, 50).Value = data[2];
                 cmd.Parameters.Add("@plt_blood_group", SqlDbType.NVarChar, 50).Value = data[3];


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
         } //method end



         public string insert_WASTE(string A, string B, string C, string D)
         {

             string x = "";
             SqlConnection conn = new SqlConnection(connstring);

             try
             {
                 SqlCommand cmd = new SqlCommand("insert_wasteblood", conn);
                 conn.Open();
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add("@w_bag_id", SqlDbType.NVarChar, 50).Value = A;
                 cmd.Parameters.Add("@w_component_name", SqlDbType.NVarChar, 50).Value = B;
                 cmd.Parameters.Add("@w_reason", SqlDbType.NVarChar, 50).Value = C;
                 cmd.Parameters.Add("@w_date", SqlDbType.NVarChar, 50).Value = D;


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
         } //method end


         public string insert_sepration(string[] data)
         {

             string x = "";
             SqlConnection conn = new SqlConnection(connstring);

             try
             {
                 SqlCommand cmd = new SqlCommand("insert_seperation", conn);
                 conn.Open();
                 cmd.CommandType = CommandType.StoredProcedure;
                 cmd.Parameters.Add("@s_bag_id", SqlDbType.NVarChar, 50).Value = data[0];
                 cmd.Parameters.Add("@s_cryo", SqlDbType.NVarChar, 50).Value = data[1];
                 cmd.Parameters.Add("@s_palatelates", SqlDbType.NVarChar, 50).Value = data[2];
                 cmd.Parameters.Add("@s_plasma", SqlDbType.NVarChar, 50).Value = data[3];
                 cmd.Parameters.Add("@s_redcell", SqlDbType.NVarChar, 50).Value = data[4];

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
         } //method end













    }
}
