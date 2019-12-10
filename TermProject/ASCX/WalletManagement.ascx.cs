using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.IO;
using System.Net;
using System.Text;
using System.Data;
using Utilities;
using TermProjectLibary;

namespace TermProject.ASCX
{
    public partial class WalletManagement : System.Web.UI.UserControl
    {
        private int MerchantAccountID = 15;
        private string APIKey = "ACSXGKZFGG";
        string webApiUrl = "http://cis-iis2.temple.edu/Fall2019/CIS3342_tug47424/WebAPI/api/PaymentService/";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtAddress.Text != "" && txtBankName.Text != "")
            {
                int cardNumber = 0;
                if (int.TryParse(txtCardNumber.Text, out cardNumber))
                {
                    Wallet wallet = new Wallet();
                    wallet.Name = txtName.Text;
                    wallet.Address = txtAddress.Text;
                    wallet.Email = txtEmail.Text;
                    wallet.BankName = txtBankName.Text;
                    wallet.CardType = txtCardType.Text;
                    wallet.CardNumber = int.Parse(txtCardNumber.Text);
                    wallet.MerchantAccountID = MerchantAccountID;

                    JavaScriptSerializer js = new JavaScriptSerializer();
                    String jsonCustomer = js.Serialize(wallet);

                    try
                    {
                        WebRequest request = WebRequest.Create(webApiUrl + "UpdatePaymentAccount/" + APIKey + "/");
                        request.Method = "PUT";
                        request.ContentLength = jsonCustomer.Length;
                        request.ContentType = "application/json";
                        // Write the JSON data to the Web Request
                        StreamWriter writer = new StreamWriter(request.GetRequestStream());
                        writer.Write(jsonCustomer);
                        writer.Flush();
                        writer.Close();
                        // Read the data from the Web Response, which requires working with streams.
                        WebResponse response = request.GetResponse();
                        Stream theDataStream = response.GetResponseStream();
                        StreamReader reader = new StreamReader(theDataStream);
                        String data = reader.ReadToEnd();
                        if (data == "true")
                        {
                            lblSuccess.Visible = true;
                            btnSave.Enabled = true;
                            txtName.Text = wallet.Name;
                            txtAddress.Text = wallet.Address;
                            txtBankName.Text = wallet.BankName;
                            txtCardType.Text = wallet.CardType;
                            txtCardNumber.Text = wallet.CardNumber.ToString();
                        }
                    }
                    catch
                    {
                        lblFailure.Visible = true;
                    }
                }
            }
        }
    }
}