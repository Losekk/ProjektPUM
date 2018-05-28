using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using ProjectPUM.Database;
using ProjectPUM.Models;

namespace ProjectPUM.Pages
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillPage();
        }

        protected void buttonAdd_Click(object sender, EventArgs e)
        {
           AddToCart();
        }

        private void AddToCart()
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                string userID = Context.User.Identity.GetUserId();
                if (userID != null)
                {
                    int id = Convert.ToInt32((Request.QueryString["id"]));
                    int quantity = Convert.ToInt32(quantityTextBox.Text);

                    Cart cart = new Cart
                    {
                        ProductID = id,
                        Quantity = quantity,
                        CustomerID = userID
                        
                        
                    };

                    CartService cartService = new CartService();
                    labelResult.Text = cartService.InsertCart(cart);
                    Response.Redirect("~/Pages/ShoppingCart.aspx?id={0}" + cart.Id);
                }
                else
                {
                    labelResult.Text = "Aby dokonać zakupu zaloguj się!";
                }
            }
        }

        private void FillPage()
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                ProductSevice productSevice = new ProductSevice();
                Products product = productSevice.GetProduct(id);

                labelTitle.Text = product.Product_Name;
                labelDescription.Text = product.Product_Description;
                labelPrice.Text = String.Format("Cena: {0} zł" , product.Price);
                productImage.ImageUrl = "~/Images/Products/" + product.PictureFileName;
            }
        }
    }
}