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

namespace TermProject
{
    public partial class CustomerDashboard : System.Web.UI.Page
    {
        DataSet dsRest = new DataSet();
        SqlCommand objCommand = new SqlCommand();
        DBConnect db = new DBConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            CustomerObj currentCustomer = (CustomerObj)Session["currentCustomer"];
            lblWelcome.Text = "<h1>Welcome " + currentCustomer.getName() + "!</h1>";
            if (!IsPostBack)
                {             
                    objCommand.Parameters.Clear();
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.CommandText = "TP_GetRestaurants";
                    dsRest = db.GetDataSetUsingCmdObj(objCommand);
                    rptRest.DataSource = dsRest;
                    rptRest.DataBind();
                }
            }
            public void bindData()
            {
                objCommand.Parameters.Clear();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "Tp_GetRestaurants";
                dsRest = db.GetDataSetUsingCmdObj(objCommand);
                int countValue = Convert.ToInt16(txtHidden.Value);
                if (countValue <= 0)
                {
                    countValue = 0;
                }
                rptRest.DataSource = dsRest;
                rptRest.DataBind();
            }

            protected void repeaterRest_ItemCommand(object source, RepeaterCommandEventArgs e)
            {
                int rowIndex = e.Item.ItemIndex;
                Label myLabel = (Label)rptRest.Items[rowIndex].FindControl("lblEmail");
                String productNumber = myLabel.Text;
                Session["RestaurantID"] = productNumber;
                Response.Redirect("ViewMenu.aspx");
            }

        protected void btnViewTransactions_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerTransactions.aspx");
        }
    }
    }
