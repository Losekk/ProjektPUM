using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectPUM.Model;

namespace ProjectPUM
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        void RegisterUser()
        {
            MedBayEntities db = new MedBayEntities();

            User user = new User();
            user.Login = txtuser_rg.Text;
            user.Password = txtpass_rg.Text;

           
            db.UserSet.Add(user);
            db.SaveChanges();


        }
        protected void Register_bt_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }
    }
}