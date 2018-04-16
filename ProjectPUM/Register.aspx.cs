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

            if (txtLogin_register.Text== "" || txtPassword_register.Text == "" || txtFirstName_register.Text == "" ||
                txtLastName_register.Text == "" || txtEmail_register.Text == "" )

            {
                 Response.Write("<script>alert('Wszystkie pola musza być wypełnione!');</script>");

            }
            else
            {
            
                Customer customer = new Customer();


                customer.User.Login = txtLogin_register.Text;
                customer.User.Password = txtPassword_register.Text;
                customer.FirstName = txtFirstName_register.Text;
                customer.LastName = txtLastName_register.Text;
                customer.Email = txtEmail_register.Text;
                customer.MarketingAgreements = true;

                db.CustomerSet.Add(customer);
                db.UserSet.Add(customer.User);
                db.SaveChanges();
            }

       


        }
        protected void Register_bt_Click(object sender, EventArgs e)
        {
         
            RegisterUser();
        }
    }
}