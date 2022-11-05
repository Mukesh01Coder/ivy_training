using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Security.AccessControl;

namespace netCore.Pages
{
    public class add_salesModel : PageModel
    {
       public Sales_info infos = new Sales_info();
       public string success_msg = "";

        public string Error_msg = "";
        public void OnPost()
        {
            try
            {
                string ConnectionString = "Data Source=INLPF3KTP43\\MSSQLSERVER1;Initial Catalog=mukesh;trusted_connection=true";
                SqlConnection sqlCon = new SqlConnection(ConnectionString);
                
                infos.s_name = Request.Form["name"];
                infos.amount = Convert.ToInt64(Request.Form["amount"]);
                infos.city = Request.Form["city"];
                infos.email_Address = Request.Form["e-mail"];
               

                sqlCon.Open();

                SqlCommand cmd = new SqlCommand("create_sales", sqlCon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@p_s_name", System.Data.SqlDbType.VarChar).Value = infos.s_name;
                cmd.Parameters.Add("@p_s_amount", System.Data.SqlDbType.BigInt).Value = infos.amount;
                cmd.Parameters.Add("@p_city", System.Data.SqlDbType.VarChar).Value = infos.city;
                cmd.Parameters.Add("@email", System.Data.SqlDbType.VarChar).Value = infos.email_Address;

                cmd.ExecuteNonQuery();
               

                sqlCon.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Sql related problem");
                Error_msg = ex.Message;
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("C# related problem");
                Error_msg = ex.Message;
                return;
            }
            infos.s_name = "";
            infos.amount = 0;
            infos.city = "";
            infos.email_Address = " ";
             success_msg = "Succefully added";


            //            Response.Redirect("/sales");
          


        }
    }
}
