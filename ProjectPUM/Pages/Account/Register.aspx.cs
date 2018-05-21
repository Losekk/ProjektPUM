using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using ProjectPUM.Database;
using ProjectPUM.Models;
using Microsoft.Owin.Host.SystemWeb;

namespace ProjectPUM.Pages.Account
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buttonRegister_Click(object sender, EventArgs e)
        {
            var userStore = new UserStore<IdentityUser>();
            userStore.Context.Database.Connection.ConnectionString =
                System.Configuration.ConfigurationManager.ConnectionStrings["MedbayEntities"].ConnectionString;
            var manager = new UserManager<IdentityUser>(userStore);
            var user = new IdentityUser { UserName = txtUserName.Text };

            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                try
                {
                    IdentityResult result = manager.Create(user, txtPassword.Text);
                    if (result.Succeeded)
                    {
                        Customer customer = new Customer
                        {
                            
                           
                            FirstName = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            UserID = user.Id,
                            PhoneNumber = "",
                            Email = "",
                            Adress = new Adress
                            {
                                Street = "",
                                Number = "",
                                City = "",
                                PostalCode = ""
                            }


                        };
                     
                        CustomerService service = new CustomerService();
                        service.InsertCustomer(customer);


                        var authenticationManager = HttpContext.Current.GetOwinContext().Authentication;
                        var userIdentity = manager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                        authenticationManager.SignIn(new AuthenticationProperties(), userIdentity);
                        Response.Redirect("~/Pages/Index.aspx");
                    }
                    else
                    {
                        literalStatusMessage.Text = result.Errors.FirstOrDefault();
                    }
                }
                catch (Exception ex)
                {
                    literalStatusMessage.Text = ex.ToString();
                }
            }
            else
            {
                literalStatusMessage.Text = "Niepoprawne dane!";
            }
        }
    }
}