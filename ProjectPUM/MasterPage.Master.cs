using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectPUM.Models;
using Microsoft.AspNet.Identity;

namespace ProjectPUM
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = Context.User.Identity;
            if (user.IsAuthenticated)
            {
                LnkLogIn.Visible = false;
                lnkRegister.Visible = false;

                litStatus.Visible = true;
                btnLogOut.Visible = true;

                CartService model = new CartService();
                string userId = HttpContext.Current.User.Identity.GetUserId();

            }
            else
            {
                LnkLogIn.Visible = true;
                lnkRegister.Visible = true;

                litStatus.Visible = false;
                btnLogOut.Visible = false;
            }
        }

        protected void lnkLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}