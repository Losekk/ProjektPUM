using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectPUM.Models;

namespace ProjectPUM.Pages
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductSevice model = new ProductSevice();
            List<Database.Products> products = model.GetAllProducts();
            
            if (products != null)
            {
                foreach (Database.Products product in products)
                {
                    Panel productPanel = new Panel();
                    ImageButton imageButton = new ImageButton
                    {
                        ImageUrl = "~/Images/Products/" + product.PictureFileName,
                        CssClass = "productImage",
                        PostBackUrl = string.Format("~/Pages/ProductDetails.aspx?id={0}", product.ProductId)
                    };
                    Label lblName = new Label
                    {
                        Text = product.Product_Name,
                        CssClass = "productName"
                    };
                    Label lblPrice = new Label
                    {
                        
                        Text = "£ " + product.Price,
                        CssClass = "productPrice"
                    };

                    productPanel.Controls.Add(imageButton);
                    productPanel.Controls.Add(new Literal { Text = "<br/>" });
                    productPanel.Controls.Add(lblName);
                    productPanel.Controls.Add(new Literal { Text = "<br/>" });
                    productPanel.Controls.Add(lblPrice);

                    //Add dynamic controls to static control
                    pnlProducts.Controls.Add(productPanel);
                }
            }
            else
                pnlProducts.Controls.Add(new Literal { Text = "No products found!" });
        }
    }
}