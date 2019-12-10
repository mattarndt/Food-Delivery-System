using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Utilities;
using System.Collections;
using System.Web.Script.Serialization;
using System.IO;
using System.Net;
using System.Text;
using TermProjectLibary;
namespace TermProject.Customer
{
    public partial class ViewMenu : System.Web.UI.Page
    {
        Validation validate = new Validation();
        SqlCommand objCommand = new SqlCommand();
        DBConnect db = new DBConnect();

        int orderID = 0;
        string name = "";
        string email = "";
        string restaurantID = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                restaurantID = Session["RestaurantID"].ToString();
                Menu(restaurantID);
            }
            
        }
        public void Menu(string restID)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Tp_GetMenu";
            SqlParameter inputEmail = new SqlParameter("@Email", restaurantID);
            objCommand.Parameters.Add(inputEmail);
            DataSet result = db.GetDataSetUsingCmdObj(objCommand);
            gvMenu.DataSource = result;
            gvMenu.DataBind();
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {           
            int check = 0;
            CustomerOrder Order;
            CheckMenuItems(gvMenu, out check);
            float orderPrice = 0;
            if (check > 0)
            {
                for (int row = 0; row < gvMenu.Rows.Count; row++)
                {
                    CheckBox CBox;
                    CBox = (CheckBox)gvMenu.Rows[row].FindControl("chkSelect");
                    if (CBox.Checked == true)
                    {
                        Order = new CustomerOrder();
                        Order.Name = gvMenu.Rows[row].Cells[2].Text;
                        string Price = gvMenu.Rows[row].Cells[5].Text.Replace("$", "");
                        Order.Price = float.Parse(Price);
                        float price = Order.Price;
                        orderPrice += price;
                        Order.Type = gvMenu.Rows[row].Cells[3].Text;
                    }
                }
            }
            CreateOrder(orderPrice);
            orderID = int.Parse(Session["OrderID"].ToString());
            DisplayOrder(orderID);
        }

        public void CreateOrder(float orderPrice)
        {
            CustomerObj currentCustomer = (CustomerObj)Session["currentCustomer"];
            name = currentCustomer.getName();
            email = currentCustomer.getEmailAddress();
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Tp_NewOrder";
            DateTime date = DateTime.Today;
            SqlParameter inputName = new SqlParameter("@OrderName", name);
            SqlParameter inputEmail = new SqlParameter("@UserEmail", email);
            SqlParameter inputRestEmail = new SqlParameter("@RestaurantEmail", restaurantID);
            SqlParameter inputCost = new SqlParameter("@OrderCost", orderPrice);
            SqlParameter outputID = new SqlParameter("@OrderID", 1);

            outputID.Direction = ParameterDirection.Output;
            outputID.SqlDbType = SqlDbType.Int;

            objCommand.Parameters.Add(inputName);
            objCommand.Parameters.Add(inputEmail);
            objCommand.Parameters.Add(inputRestEmail);
            objCommand.Parameters.Add(inputCost);
            objCommand.Parameters.Add(outputID);
            db.DoUpdateUsingCmdObj(objCommand);
            orderID = int.Parse(objCommand.Parameters["@OrderID"].Value.ToString());
            Session["OrderID"] = orderID;
        }

        public void DisplayOrder(int OrderID)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Tp_OrderInfo";
            SqlParameter inputEmail = new SqlParameter("@OrderID", OrderID);

            objCommand.Parameters.Add(inputEmail);
            DataSet result = db.GetDataSetUsingCmdObj(objCommand);
            lblOrderName.Visible = true;
            lblUserEmail.Visible = true;
            lblRestaurantEmail.Visible = true;
            lblOrderCost.Visible = true;
            lblOrderName.Text = Convert.ToString(result.Tables[0].Rows[0]["OrderName"]);
            lblUserEmail.Text = Convert.ToString(result.Tables[0].Rows[0]["UserEmail"]);
            lblRestaurantEmail.Text = Convert.ToString(result.Tables[0].Rows[0]["RestaurantEmail"]);
            lblOrderCost.Text = Convert.ToString(result.Tables[0].Rows[0]["OrderCost"]);
            
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Tp_GetItem";
            SqlParameter inputOrderID = new SqlParameter("@OrderID", OrderID);

            objCommand.Parameters.Add(inputOrderID);
            DataSet ds = db.GetDataSetUsingCmdObj(objCommand);       
        }

        public void CheckMenuItems(GridView gvCurrent, out int count)
        {
            count = 0;
            for (int row = 0; row < gvCurrent.Rows.Count; row++)
            {
                CheckBox CBox;
                CBox = (CheckBox)gvCurrent.Rows[row].FindControl("chkSelect");
                if (CBox.Checked)
                {
                    count = count + 1;
                }

            }
        }
    }
}