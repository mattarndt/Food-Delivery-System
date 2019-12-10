using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using Utilities;
using TermProjectLibary;

namespace TermProject.Restaurant
{
    public partial class Transactions : System.Web.UI.Page
    {
        private int MerchantAccountID = 15;
        private string APIKey = "ACSXGKZFGG";
        protected void Page_Load(object sender, EventArgs e)
        {
            RestaurantObj currentRestaurant = (RestaurantObj)Session["currentRestaurant"];
            string email = currentRestaurant.getEmail();
            DisplayTransactions(email);
        }
        public void DisplayTransactions(string email)
        {
            WebRequest request = WebRequest.Create("http://cis-iis2.temple.edu/Fall2019/CIS3342_tug47424/WebAPI/api/PaymentService/" + "GetTransactions/" + email + "/" + MerchantAccountID + "/" + APIKey);
            WebResponse response = request.GetResponse();
            Stream theDataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(theDataStream);
            String data = reader.ReadToEnd();
            reader.Close();
            response.Close();
            JavaScriptSerializer js = new JavaScriptSerializer();
            List<Transaction> theList = new List<Transaction>();
            List<Transaction> transactions = js.Deserialize<List<Transaction>>(data);
            gvTransactions.DataSource = transactions;
            gvTransactions.DataBind();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("RestaurantMain.aspx");
        }
    }
}