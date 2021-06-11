using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace iram2
{
    public partial class hello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Response.Write("Page load");
            //HttpCookie userInfo = new HttpCookie("userInfo");
            //userInfo["UserName"] = "IRAM";            
            //Response.Cookies.Add(userInfo);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Hello Worls");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //HttpCookie userInfo = new HttpCookie("userInfo");
            //userInfo["UserName"] = "IRAM";
            //userInfo.Expires = DateTime.Now.AddDays(-1d);
            //Response.Cookies.Add(userInfo);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {            
            products.additem(TextBox1.Text);
            Session.Add("product", products.items) ;
            Response.Write($"Added product {TextBox1.Text} in your shopping cart");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            var items = Session["product"] as List<string>;

            if(items != null)
            {
                Response.Write($"There are {items?.Count} products in your shopping cart");
                Response.Write("\n");
                foreach (var item in items)
                {
                    Response.Write(item);
                    Response.Write("\n");
                }
            }
            else
            {
                Response.Write($"There are ZERO products in your shopping cart");
            }
            
        }
    }

    public static class products
    {
        public static List<string> items = new List<string>();

        public static void additem(string item)
        {
            items.Add(item);
        }
    }
}