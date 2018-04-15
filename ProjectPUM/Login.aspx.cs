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
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        protected void Login_bt_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LUX-TORPEDA\SQLEXPRESS; Initial Catalog=MedBay; Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            String query = "SELECT * FROM UserSet WHERE Login='" + txtuser.Text + "' AND Password='" + txtpass.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(query, connection);


            int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
            if (count == 1)
            {
                Response.Write("<script>alert('Logowanie zakończone sukcesem');</script>");
            }
            else
            {
                Response.Write("<script>alert('Logowanie niepomyślne');</script>");

            }
            connection.Close();
        }
    }
            
}