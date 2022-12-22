using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace GradProjectAPI.Models.DAL
{
    public class DataAccessLayer
    {
        SqlConnection SqlConnection;

        //constructor to intialize connection:
        public DataAccessLayer()
        {
            try
            {
                SqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["medical"].ConnectionString);
            }
            catch (SqlException)
            {

            }
        }

        //Method to open the connection:
        public void Open()
        {
            if (SqlConnection.State != ConnectionState.Open)
            {
                SqlConnection.Open();
            }
        }

        //Method to close the connection:
        public void Close()
        {
            if (SqlConnection.State == ConnectionState.Open)
            {
                SqlConnection.Close();
            }
        }

        public bool ExecuteCommand(string StoredProcedure, SqlParameter[] param)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = StoredProcedure;
                sqlCommand.Connection = SqlConnection;
                if (param != null)
                {
                    sqlCommand.Parameters.AddRange(param);
                }
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public DataTable SelectData(string StoredProcedure, SqlParameter[] param)
        {
            DataTable dt = null;
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandText = StoredProcedure;
                sqlCommand.Connection = SqlConnection;
                if (param != null)
                {
                    sqlCommand.Parameters.AddRange(param);
                }
                SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (SqlException)
            {
                return dt;
            }
        }
    }
}