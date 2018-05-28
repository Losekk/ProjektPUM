using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using ProjectPUM.Models;

namespace ProjectPUM.Pages
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string userId = User.Identity.GetUserId();
            GetPurchasesInCart(userId);
        }

        protected void Delete_Item(object sender, EventArgs e)
        {
            LinkButton selectedLink = (LinkButton)sender;
            string link = selectedLink.ID.Replace("del", "");
            int cartId = Convert.ToInt32(link);

            var cartModel = new CartService();
            cartModel.DeleteCart(cartId);

            Response.Redirect("~/Pages/ShoppingCart.aspx");
        }

        private void ddlAmount_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DropDownList selectedList = (DropDownList)sender;
            int cartId = Convert.ToInt32(selectedList.ID);
            int quantity = Convert.ToInt32(selectedList.SelectedValue);

            
            CartService cartModel = new CartService();
            cartModel.UpdateQuantity(cartId, quantity);
            Response.Redirect("~/Pages/ShoppingCart.aspx");
        }

        private void GetPurchasesInCart(string userId)
        {
            CartService cartModel = new CartService();
            double subTotal = 0;

            
            List<Database.Cart> purchaseList = cartModel.GetOrdersInCart(userId);
            CreateShopTable(purchaseList, out subTotal);

            
            
            double totalAmount = subTotal;

            litTotal.Text = "PLN " + subTotal;
            

           
        }

        private void CreateShopTable(IEnumerable<Database.Cart> carts, out double subTotal)
        {
            subTotal = new double();
            ProductSevice model = new ProductSevice();

            foreach (Database.Cart cart in carts)
            {
                
                Database.Products product = model.GetProduct(cart.ProductID);

                ImageButton btnImage = new ImageButton
                {
                    ImageUrl = string.Format("~/Images/Products/{0}", product.PictureFileName),
                    PostBackUrl = string.Format("~/Pages/Product.aspx?id={0}", product.ProductId)
                };

                LinkButton lnkDelete = new LinkButton
                {
                    PostBackUrl = string.Format("~/Pages/ShoppingCart.aspx?productId={0}", cart.Id),
                    Text = "Usuń",
                    ID = "del" + cart.Id,
                };

                lnkDelete.Click += Delete_Item;

                
                int[] amount = Enumerable.Range(1, 20).ToArray();
                DropDownList ddlAmount = new DropDownList
                {
                    DataSource = amount,
                    AppendDataBoundItems = true,
                    AutoPostBack = true,
                    ID = cart.Id.ToString()
                };
                ddlAmount.DataBind();
                ddlAmount.SelectedValue = cart.Quantity.ToString();
                ddlAmount.SelectedIndexChanged += ddlAmount_SelectedIndexChanged;

                
                Table table = new Table { CssClass = "CartTable" };
                TableRow row1 = new TableRow();
                TableRow row2 = new TableRow();

                TableCell cell1_1 = new TableCell { RowSpan = 2, Width = 50 };
                TableCell cell1_2 = new TableCell
                {
                    Text = string.Format("<h4>{0}</h4> <br /> Ilość na stanie: <br />{1}<br/>",
                    product.Product_Name, product.Quantity),
                    HorizontalAlign = HorizontalAlign.Left,
                    Width = 350,
                };
                TableCell cell1_3 = new TableCell { Text = "Cena<hr/>" };
                TableCell cell1_4 = new TableCell { Text = "Ilość<hr/>" };
                TableCell cell1_5 = new TableCell { Text = "Suma<hr/>" };
                TableCell cell1_6 = new TableCell();

                TableCell cell2_1 = new TableCell();
                TableCell cell2_2 = new TableCell { Text = "PLN  " + product.Price };
                TableCell cell2_3 = new TableCell();
                TableCell cell2_4 = new TableCell { Text = "PLN  " + (cart.Quantity * product.Price) };
                TableCell cell2_5 = new TableCell();

                
                cell1_1.Controls.Add(btnImage);
                cell1_6.Controls.Add(lnkDelete);
                cell2_3.Controls.Add(ddlAmount);

                
                row1.Cells.Add(cell1_1);
                row1.Cells.Add(cell1_2);
                row1.Cells.Add(cell1_3);
                row1.Cells.Add(cell1_4);
                row1.Cells.Add(cell1_5);
                row1.Cells.Add(cell1_6);

                row2.Cells.Add(cell2_1);
                row2.Cells.Add(cell2_2);
                row2.Cells.Add(cell2_3);
                row2.Cells.Add(cell2_4);
                row2.Cells.Add(cell2_5);
                table.Rows.Add(row1);
                table.Rows.Add(row2);
                pnlShoppingCart.Controls.Add(table);

               
                subTotal += (cart.Quantity * product.Price);
            }

            
            Session[User.Identity.GetUserId()] = carts;
        }
        
    }
}
