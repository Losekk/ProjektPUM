using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectPUM.Model;

namespace ProjectPUM
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        void LogIn()
        {
            MedBayEntities db = new MedBayEntities();
            var user = db.UserSet.FirstOrDefault(x => x.Login == txtuser.Text);
            if (user != null)
            {
                if (user.Password == txtpass.Text)
                {
                    Response.Write("<script>alert('Logowanie zakończone sukcesem');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Logowanie niepomyślne');</script>");

                }

            }


        }
        
        protected void Login_bt_Click(object sender, EventArgs e)
        {

            LogIn();
           
        }
    }
            
}