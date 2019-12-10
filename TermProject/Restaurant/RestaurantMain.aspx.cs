using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using TermProjectLibary;

namespace TermProject
{
    public partial class RestuarantMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RestaurantObj currentRestaurant = (RestaurantObj)Session["currentRestaurant"];
                lblWelcome.Text = "<h1>Welcome, " + currentRestaurant.getRestaurantName() + "! This is your main hub</h1>";
            }
        }

        protected void btnManageMenu_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManageMenu.aspx");
        }

        protected void btnViewTransactions_Click(object sender, EventArgs e)
        {
            Response.Redirect("Transactions.aspx");
        }

        protected void btnViewCurrentOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("Orders.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("../LoginRegistration/Login.aspx");
        }
    }
}