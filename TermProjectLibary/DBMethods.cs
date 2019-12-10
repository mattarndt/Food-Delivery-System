using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Utilities;

namespace TermProjectLibary
{
    public class DBMethods
    {
        public void CreateNewCustomer(String customerId, String password, String deliveryAddress,
            String billingAddress, String emailAddress, String name)
        {
            SqlCommand objCommand = new SqlCommand();
            DBConnect objDB = new DBConnect();
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_CreateNewCustomer"; // name of the Stored Procedure 

            // Pass an input parameter value to the Stored Procedure that is used for the 
            // @theName built-in parameter

            objCommand.Parameters.AddWithValue("@CustomerId", customerId);
            objCommand.Parameters.AddWithValue("@Password", password);
            objCommand.Parameters.AddWithValue("@DeliveryAddress", deliveryAddress);
            objCommand.Parameters.AddWithValue("@BillingAddress", billingAddress);
            objCommand.Parameters.AddWithValue("@EmailAddress", emailAddress);
            objCommand.Parameters.AddWithValue("@Name", name);

            objDB.GetConnection();
            objDB.DoUpdateUsingCmdObj(objCommand);
            objDB.CloseConnection();
        }

        public void CreateNewRestaurant(String restaurantId, String password, String email,
            String address, String logo, String phone, String restaurantName)
        {
            SqlCommand objCommand = new SqlCommand();
            DBConnect objDB = new DBConnect();
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_CreateNewRestaurant"; // name of the Stored Procedure 

            // Pass an input parameter value to the Stored Procedure that is used for the 
            // @theName built-in parameter

            objCommand.Parameters.AddWithValue("@RestaurantId", restaurantId);
            objCommand.Parameters.AddWithValue("@Password", password);
            objCommand.Parameters.AddWithValue("@Email", email);
            objCommand.Parameters.AddWithValue("@Address", address);
            objCommand.Parameters.AddWithValue("@Logo", logo);
            objCommand.Parameters.AddWithValue("@Phone", phone);
            objCommand.Parameters.AddWithValue("@RestaurantName", restaurantName);

            objDB.GetConnection();
            objDB.DoUpdateUsingCmdObj(objCommand);
            objDB.CloseConnection();
        }

        //Returns 1 if Customer, -1 if Restaurant, and 0 if does not exist
        public int GetAccountTypeById(String id)
        {
            int value = 0;
            //search for account in customer account
            try{
                SqlCommand objCommand = new SqlCommand();
                DBConnect objDB = new DBConnect();
                objCommand.Parameters.Clear();
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_GetAccountTypeById"; // name of the Stored Procedure 
                
                SqlParameter returnParameter = new SqlParameter("@outp", DbType.Int32);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                objCommand.Parameters.Add(returnParameter);
                objCommand.Parameters.AddWithValue("@id", id);

                objDB.GetConnection();
                objDB.DoUpdateUsingCmdObj(objCommand);

                objDB.GetDataSetUsingCmdObj(objCommand);
                value = int.Parse(objCommand.Parameters["@outp"].Value.ToString());
                
                objDB.CloseConnection();
            }
            catch (Exception){ Console.WriteLine("ah"); }
            return value;
        }

        public DataSet GetCustomerByIdAndPassword(String userid, String password)
        {
            SqlCommand objCommand = new SqlCommand();

            objCommand.Parameters.Clear();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_GetCustomerByIdAndPassword";

            objCommand.Parameters.AddWithValue("@theUser", userid);
            objCommand.Parameters.AddWithValue("@password", password);

            DBConnect objDB = new DBConnect();
            DataSet myDataSet = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDataSet;
        }

        public DataSet GetRestaurantByIdAndPassword(String userid, String password)
        {
            SqlCommand objCommand = new SqlCommand();

            objCommand.Parameters.Clear();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_GetRestaurantByIdAndPassword";

            objCommand.Parameters.AddWithValue("@theUser", userid);
            objCommand.Parameters.AddWithValue("@password", password);

            DBConnect objDB = new DBConnect();
            DataSet myDataSet = objDB.GetDataSetUsingCmdObj(objCommand);
            return myDataSet;
        }

        public void updateRestaurantAccountInfo(string restId, string password, string email, string address, string phone, string restName)
        {
            SqlCommand objCommand = new SqlCommand();
            DBConnect objDB = new DBConnect();
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_UpdateRestaurantAccountInformation"; // name of the Stored Procedure 

            // Pass an input parameter value to the Stored Procedure that is used for the 
            // @theName built-in parameter

            objCommand.Parameters.AddWithValue("@RestaurantId", restId);
            objCommand.Parameters.AddWithValue("@Password", password);
            objCommand.Parameters.AddWithValue("@Email", email);
            objCommand.Parameters.AddWithValue("@Address", address);
            objCommand.Parameters.AddWithValue("@Phone", phone);
            objCommand.Parameters.AddWithValue("@RestaurantName", restName);

            objDB.GetConnection();
            objDB.DoUpdateUsingCmdObj(objCommand);
            objDB.CloseConnection();
        }
        public void updateCustomerAccountInfo(string customerId, string password, string email, string billingAddress, string deliveryAddress, string Name)
        {
            SqlCommand objCommand = new SqlCommand();
            DBConnect objDB = new DBConnect();
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_UpdateCustomerAccountInformation"; // name of the Stored Procedure 

            // Pass an input parameter value to the Stored Procedure that is used for the 
            // @theName built-in parameter

            objCommand.Parameters.AddWithValue("@CustomerId", customerId);
            objCommand.Parameters.AddWithValue("@Password", password);
            objCommand.Parameters.AddWithValue("@Email", email);
            objCommand.Parameters.AddWithValue("@BillingAddress", billingAddress);
            objCommand.Parameters.AddWithValue("@DeliveryAddress", deliveryAddress);
            objCommand.Parameters.AddWithValue("@Name", Name);

            objDB.GetConnection();
            objDB.DoUpdateUsingCmdObj(objCommand);
            objDB.CloseConnection();
        }
        public DataSet GetMenu(string email)
        {
            SqlCommand objCommand = new SqlCommand();
            DBConnect objDB = new DBConnect();

            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "Tp_GetMenu";
            SqlParameter inputEmail = new SqlParameter("@Email", email);
            objCommand.Parameters.Add(inputEmail);
            DataSet ds = objDB.GetDataSetUsingCmdObj(objCommand);
            return ds;
        }

        public void addMenuItem(string name, double price, string type, string email, string photo)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();

            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_AddMenuItem";

            objCommand.Parameters.AddWithValue("@ItemName", name);
            objCommand.Parameters.AddWithValue("@ItemType", type);
            objCommand.Parameters.AddWithValue("@ItemPrice", price);
            objCommand.Parameters.AddWithValue("@Email", email);
            objCommand.Parameters.AddWithValue("@ItemPhoto", photo);

            objDB.GetConnection();
            objDB.DoUpdateUsingCmdObj(objCommand);
            objDB.CloseConnection();
        }

        public void deleteItem(string itemId)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();

            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_DeleteMenuItem";

            objCommand.Parameters.AddWithValue("@ItemID", itemId);

            objDB.GetConnection();
            objDB.DoUpdateUsingCmdObj(objCommand);
            objDB.CloseConnection();
        }
    }
}