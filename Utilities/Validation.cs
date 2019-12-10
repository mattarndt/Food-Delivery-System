using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Data.OleDb;
using Utilities;
using System.Collections;
using System.Net;
using System.IO;

namespace Utilities
{
    public class Validation
    {
        DBConnect db = new DBConnect();
        SqlCommand dbCommand = new SqlCommand();
        public int CheckMerchantExists(string AccountEmail)
        {
            dbCommand.Parameters.Clear();
            dbCommand.CommandType = CommandType.StoredProcedure;
            dbCommand.CommandText = "TP_CheckMerchantExists";
            SqlParameter inputEmail = new SqlParameter("@Account_Email", AccountEmail.ToString());
            SqlParameter outputCount = new SqlParameter("@Count", 0);

            inputEmail.Direction = ParameterDirection.Input;
            inputEmail.SqlDbType = SqlDbType.VarChar;
            inputEmail.Size = 50;
            outputCount.Direction = ParameterDirection.Output;
            outputCount.SqlDbType = SqlDbType.VarChar;
            outputCount.Size = 50;

            dbCommand.Parameters.Add(inputEmail);
            dbCommand.Parameters.Add(outputCount);

            db.GetDataSetUsingCmdObj(dbCommand);
            int count = int.Parse(dbCommand.Parameters["@Count"].Value.ToString());
            return count;
        }
    }
}
