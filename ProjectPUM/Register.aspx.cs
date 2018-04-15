using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ProjectPUM
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Register_bt_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LUX-TORPEDA\SQLEXPRESS; Initial Catalog=MedBay; Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT into [UserSet](Login, Password) values (@Login , @Password)";
                cmd.Parameters.AddWithValue("@Login", txtuser_rg.Text);
                cmd.Parameters.AddWithValue("@Password", txtpass_rg.Text);
                cmd.Connection = connection;
                int a = cmd.ExecuteNonQuery();
                if (a == 1)
                {
                Response.Write("<script>alert('Rejestracja zakończona sukcesem');</script>");

                }
                else
                {

                Response.Write("<script>alert('Rejestracja nieudana');</script>");
                }


              

            
                
            
        }
    }
}