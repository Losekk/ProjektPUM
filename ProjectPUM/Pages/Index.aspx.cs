using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjectPUM.Models;
using Microsoft.AspNet.Identity;
using ProjectPUM.Database;
using Image = System.Drawing.Image;

namespace ProjectPUM.Pages
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {     
          CreateProductPanel();    
        }

        public void CreateProductPanel()
        {

            ProductSevice productSevice = new ProductSevice();
            List<Database.Products> products = productSevice.GetAllProducts();

            if (products != null)
            {
                foreach (Database.Products product in products)
                {
                   
                    ImageButton imageButton = new ImageButton
                    {
                        ImageUrl = "~/Images/Products/" + product.PictureFileName,
                       // CssClass = "productImage",
                        PostBackUrl = string.Format("~/Pages/ProductDetails.aspx?id={0}", product.ProductId)
                    };
           
                    LinkButton detailButton = new LinkButton
                    {
                        Text = "Szczegóły",
                        CssClass = "button",
                        PostBackUrl = string.Format("~/Pages/ProductDetails.aspx?id={0}", product.ProductId)

                    };
                 

                    LinkButton addCartButton = new LinkButton
                    {
                        Text = "Kup teraz!",
                        CssClass = "button",
                        PostBackUrl = string.Format("~/Pages/ProductDetails.aspx?id={0}", product.ProductId)

                    };
                    addCartButton.Click += new EventHandler(this.AddToCart);


                    Label added = new Label()
                    {
                        Text = "Dodano do koszyka!",
                        Visible = false
                    };
                    




                    Table table = new Table { CssClass = "CartTable" };
                    TableRow row1 = new TableRow();
                    TableRow row2 = new TableRow();

                    TableCell cell1_1 = new TableCell { RowSpan = 2, Width = 50 };
                    TableCell cell1_2 = new TableCell
                    {
                        Text = string.Format("<h4>{0}</h4>",
                            product.Product_Name),
                        HorizontalAlign = HorizontalAlign.Center,
                        Width = 350,
                    };
                    TableCell cell1_3 = new TableCell { Text = String.Format("Cena<hr/>{0} zł", product.Price ), Width = 150};
                    TableCell cell1_4 = new TableCell { Text = String.Format("Ilość<hr/> {0}", product.Quantity), Width  = 150};
                    TableCell cell1_5 = new TableCell();
                    TableCell cell1_6 = new TableCell();

                   TableCell cell2_6 = new TableCell();

                    cell1_1.Controls.Add(imageButton);
                    cell1_5.Controls.Add(detailButton);
                    cell2_6.Controls.Add(added);
                    cell1_6.Controls.Add(addCartButton);
                  

                    row1.Cells.Add(cell1_1);
                    row1.Cells.Add(cell1_2);
                    row1.Cells.Add(cell1_3);
                    row1.Cells.Add(cell1_4);
                    row1.Cells.Add(cell1_5);
                    row1.Cells.Add(cell1_6);
                    row2.Cells.Add((cell2_6));

                   
                    table.Rows.Add(row1);
                    table.Rows.Add(row2);



                    pnlProducts.Controls.Add(table);
                }
            }
            else


                pnlProducts.Controls.Add(new Literal {Text = "No products found!"});
            
        }



        private void AddToCart(Object sender,
            EventArgs e)
        {
            Response.Redirect("~/Pages/ProductDetails.aspx?id={0}");
            if (!string.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                string userID = Context.User.Identity.GetUserId();
                if (userID != null)
                {
                    int id = Convert.ToInt32((Request.QueryString["id"]));
                    int quantity = 1;

                    Cart cart = new Cart
                    {
                        ProductID = id,
                        Quantity = quantity,
                        CustomerID = userID

                    };

                    CartService cartService = new CartService();
                   
                    cartService.InsertCart(cart);
                    
                    Response.Write("<script>alert('Dodano do koszyka.');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Aby dokonać zakupu zaloguj się!');</script>");
                }
            }
          
        }
    }
}