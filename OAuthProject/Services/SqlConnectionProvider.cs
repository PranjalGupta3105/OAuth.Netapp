//using RegistrationService.Models;
//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Web;

//namespace OAuthProject.Services
//{
//    public class SqlConnectionProvider
//    {
//        SqlConnection conn;
//        string sqlQuery;
//        public string EstablishConnection(string connectionString,string tableName,UserDetails registrationDetails)
//        {
//            conn = new SqlConnection("test.ctrtxehuc3lz.us-east-1.rds.amazonaws.com,1433");
//            conn.Open();
//            SqlCommand command;
//            SqlDataAdapter adapter = new SqlDataAdapter();

//            sqlQuery = "INSERT INTO dbo.Employees VALUES("
//                +registrationDetails.FirstName+"," 
//                + registrationDetails.LastName + ","
//                + registrationDetails.Gender + ","
//                + registrationDetails.Salary + ","
//                + ");";

//            command = new SqlCommand(sqlQuery,conn);
//            adapter.InsertCommand = new SqlCommand(sqlQuery, conn);
//            adapter.InsertCommand.ExecuteNonQuery();
//            command.Dispose();
//            conn.Dispose();

//            return "Record Creation Successful";

//        }

//    }
//}