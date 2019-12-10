using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TermProjectLibary;

namespace TermProject
{
    public partial class Login : System.Web.UI.Page
    {
        string ID = "";
        string apiKey = "ACSXGKZFGG";
        DBMethods dbm = new DBMethods();
        string username;
        string password;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie objCookie = Request.Cookies["myCookie"];
                if (objCookie != null)
                {
                    username = objCookie["Username"].ToString();
                    password = objCookie["Password"].ToString();
                    txtUsrname.Text = username;
                    txtPssword.Text = password;
                }
            }
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            if (cbRememberLogin.Checked)
            {
                HttpCookie myCookie = new HttpCookie("myCookie");
                myCookie["Username"] = txtUsrname.Text;
                myCookie["Password"] = txtPssword.Text;
                myCookie.Expires = new DateTime(2025, 1, 1);
                Response.Cookies.Add(myCookie) ;
            }
            int num = dbm.GetAccountTypeById(txtUsrname.Text);
            switch (num)
            {
                case 0:
                    lblNoAccount.Visible = true;
                    break;
                case 1:
                    DataSet custData = dbm.GetCustomerByIdAndPassword(txtUsrname.Text, txtPssword.Text);

                    try
                    {
                        DataRow dRow = custData.Tables[0].Rows[0];
                        String customerId = dRow.ItemArray.GetValue(0).ToString();
                        String password = dRow.ItemArray.GetValue(1).ToString();
                        String deliveryAddress = dRow.ItemArray.GetValue(2).ToString();
                        String billingAddress = dRow.ItemArray.GetValue(3).ToString();
                        String emailAddress = dRow.ItemArray.GetValue(4).ToString();
                        String name = dRow.ItemArray.GetValue(5).ToString();

                        CustomerObj customer = new CustomerObj(customerId, password, deliveryAddress, billingAddress, emailAddress, name);
                        Session["currentCustomer"] = customer;

                        Response.Redirect("../Customer/CustomerDashboard.aspx");
                    }
                    catch (Exception)
                    {
                        Response.Write("error transferring data");
                    }
                    break;
                case -1:
                    DataSet restData = dbm.GetRestaurantByIdAndPassword(txtUsrname.Text, txtPssword.Text);

                    try
                    {
                        DataRow dRow = restData.Tables[0].Rows[0];
                        String restaurantId = dRow.ItemArray.GetValue(0).ToString();
                        String password = dRow.ItemArray.GetValue(1).ToString();
                        String email = dRow.ItemArray.GetValue(2).ToString();
                        String address = dRow.ItemArray.GetValue(3).ToString();
                        String logo = dRow.ItemArray.GetValue(4).ToString();
                        String phone = dRow.ItemArray.GetValue(5).ToString();
                        String restaurantName = dRow.ItemArray.GetValue(6).ToString();

                        RestaurantObj restaurant = new RestaurantObj(restaurantId, password, email, address, logo, phone, restaurantName);
                        Session["currentRestaurant"] = restaurant;
                        Response.Redirect("../Restaurant/RestaurantMain.aspx");
                    }
                    catch (Exception)
                    {
                        Response.Write("error transferring data");
                    }
                    break;
            }
        }

        protected void btnForgetInfo_Click(object sender, EventArgs e)
        {
            HttpCookie objCookie = Request.Cookies["myCookie"];
            if (objCookie != null)
            {
                objCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(objCookie);
                txtUsrname.Text = "";
                txtPssword.Text = "";
            }
            else
            {
                Response.Write("No cookie to delete");
            }
        }

        protected void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerRegistration.aspx");

        }

        protected void btnRestaurantRegistration_Click(object sender, EventArgs e)
        {
            Response.Redirect("RestaurantRegistration.aspx");
        }
    }
}