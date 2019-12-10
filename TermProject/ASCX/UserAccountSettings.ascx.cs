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

namespace TermProject
{
    public partial class AccountSettings : System.Web.UI.UserControl
    {
        DBConnect db = new DBConnect();
        SqlCommand dbCommand = new SqlCommand();
        DBMethods dbm = new DBMethods();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CustomerObj currentCustomer = (CustomerObj)Session["currentCustomer"];
                txtId.Text = currentCustomer.getCustomerId();
                txtPassword.Text = currentCustomer.getPassword();
                txtEmail.Text = currentCustomer.getEmailAddress();
                txtBillingAddress.Text = currentCustomer.getBillingAddress();
                txtDeliveryAddress.Text = currentCustomer.getDeliveryAddress();
                txtName.Text = currentCustomer.getName();
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtPassword.Enabled = true;
            txtName.Enabled = true;
            txtBillingAddress.Enabled = true;
            txtDeliveryAddress.Enabled = true;

            btnChange.Enabled = true;
            btnSave.Enabled = false;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            dbm.updateCustomerAccountInfo(txtId.Text, txtPassword.Text, txtEmail.Text, txtBillingAddress.Text, txtDeliveryAddress.Text, txtName.Text);
            DisableFields();
        }
        public void DisableFields()
        {
            txtId.Enabled = false;
            txtPassword.Enabled = false;
            txtEmail.Enabled = false;
            txtName.Enabled = false;
            txtDeliveryAddress.Enabled = false;
            txtBillingAddress.Enabled = false;
        }
    }
}