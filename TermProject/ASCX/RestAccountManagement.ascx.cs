using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using Utilities;
using TermProjectLibary;

namespace TermProject.ASCX
{
    public partial class RestAccountManagement : System.Web.UI.UserControl
    {
        DBConnect db = new DBConnect();
        SqlCommand dbCommand = new SqlCommand();
        DBMethods dbm = new DBMethods();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RestaurantObj currentRestaurant = (RestaurantObj)Session["currentRestaurant"];
                txtId.Text = currentRestaurant.getRestaurantId();
                txtPassword.Text = currentRestaurant.getPassword();
                txtEmail.Text = currentRestaurant.getEmail();
                txtAddress.Text = currentRestaurant.getAddress();
                txtPhone.Text = currentRestaurant.getPhone();
                txtName.Text = currentRestaurant.getRestaurantName();
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtPassword.Enabled = true;
            txtName.Enabled = true;
            txtAddress.Enabled = true;
            txtPhone.Enabled = true;

            btnChange.Enabled = true;
            btnSave.Enabled = false;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dbm.updateRestaurantAccountInfo(txtId.Text, txtPassword.Text, txtEmail.Text, txtAddress.Text, txtPhone.Text, txtName.Text);
            DisableFields();
        }
        public void DisableFields()
        {
            txtId.Enabled = false;
            txtPassword.Enabled = false;
            txtEmail.Enabled = false;
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtPhone.Enabled = false;
        }
    }
}