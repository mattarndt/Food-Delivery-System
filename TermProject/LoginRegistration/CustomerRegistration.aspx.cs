using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;
using TermProjectLibary;

namespace TermProject
{
    
    public partial class CustomerRegistration : System.Web.UI.Page
    {
        DBMethods dbm = new DBMethods();
        string apiKey = "ACSXGKZFGG";
        string webApiUrl = "http://cis-iis2.temple.edu/Fall2019/CIS3342_tug47424/WebAPI/api/PaymentService/";
        private int MerchantAccountID = 15;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BackToLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void CreateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                dbm.CreateNewCustomer(txtCustomerId.Text, txtPassword.Text, txtDeliveryAddress.Text,
                txtBillingAddress.Text, txtContactEmail.Text, txtName.Text);

                Wallet wallet = new Wallet();
                wallet.Name = txtName.Text;
                wallet.Address = txtBillingAddress.Text;
                wallet.Email = txtContactEmail.Text;
                wallet.BankName = txtBankName.Text;
                wallet.CardType = txtCardType.Text;
                wallet.CardNumber = int.Parse(txtCardNumber.Text);
                wallet.MerchantAccountID = MerchantAccountID;

                JavaScriptSerializer js = new JavaScriptSerializer();
                String jsonCustomer = js.Serialize(wallet);

                WebRequest request = WebRequest.Create(webApiUrl + "CreateNewWallet/" + apiKey);
                request.Method = "POST";
                request.ContentType = "application/json";

                StreamWriter writer = new StreamWriter(request.GetRequestStream());
                writer.Write(jsonCustomer);
                writer.Flush();
                writer.Close();
                WebResponse response = request.GetResponse();
                Stream theDataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(theDataStream);
                String data = reader.ReadToEnd();
                reader.Close();
                response.Close();

                lblAccountSuccessful.Visible = true;
            }
            catch (Exception)
            {
                Response.Write("ERROR CREATING ACCOUNT");
            }
        }
    }
}