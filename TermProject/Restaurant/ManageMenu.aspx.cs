using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TermProjectLibary;
using Utilities;

namespace TermProject.Restaurant
{
    public partial class ManageMenu : System.Web.UI.Page
    {
        DBMethods dbm = new DBMethods();
        SqlCommand objCommand = new SqlCommand();
        DBConnect objDB = new DBConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet dataSet = dbm.GetMenu("contact@moes.com");

                gvMenu.DataSource = dataSet;
                gvMenu.DataBind();
            }
            
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int num = 0;
            string itemId = "";

            for (int row = 0; row < gvMenu.Rows.Count; row++)
            {
                CheckBox CBox = (CheckBox)gvMenu.Rows[row].FindControl("chkSelect") as CheckBox;
                if (CBox.Checked)
                {
                    itemId = gvMenu.Rows[row].Cells[1].Text;
                    num++;
                }
            }

            if (num != 0)
            {
                dbm.deleteItem(itemId);
                Response.Redirect(Request.RawUrl);
            }
        }

        protected void btnNewItem_Click(object sender, EventArgs e)
        {
            pnlBuild.Visible = true;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                float price = float.Parse(txtPrice.Text);
                string file = fuImage.FileName;
                dbm.addMenuItem(txtName.Text, price, txtType.Text, "contact@moes.com", file);
            }
            catch (Exception ex)
            {
                if (ex is FormatException)
                    Response.Write("You must enter a valid price");
                if (ex is ArgumentNullException)
                {
                    Response.Write("You must enter a valid price");
                }
                else
                {
                    Response.Write("Unable to add item due to db error");
                }
            }
            Response.Write("Item added");
            Response.Redirect(Request.RawUrl);
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("RestaurantMain.aspx");
        }
    }
}