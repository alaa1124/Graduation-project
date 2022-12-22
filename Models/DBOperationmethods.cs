using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GradProjectAPI.Models
{
    public class DBOperationmethods
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public DataTable SelectByInsertedOperation()
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();

                dt = dal.SelectData("SelectByInsertedOperation", null);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
        public DataTable SelectInsertedOperationByDate(string from, string to)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@From", SqlDbType.Date);
                param[0].Value = from;
                param[1] = new SqlParameter("@TO", SqlDbType.Date);
                param[1].Value = to;
                dt = dal.SelectData("SelectInsertedOperationByDate", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
        public DataTable SelectByUpdatedOperation()
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();

                dt = dal.SelectData("SelectByUpdatedOperation", null);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
        public DataTable SelectUpdatedOperationByDate(string from, string to)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@From", SqlDbType.Date);
                param[0].Value = from;
                param[1] = new SqlParameter("@TO", SqlDbType.Date);
                param[1].Value = to;
                dt = dal.SelectData("SelectUpdatedOperationByDate", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
        public DataTable SelectByDeletedOperation()
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();

                dt = dal.SelectData("SelectByDeletedOperation", null);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
        public DataTable SelectDeletedOperationByDate(string from, string to)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@From", SqlDbType.Date);
                param[0].Value = from;
                param[1] = new SqlParameter("@TO", SqlDbType.Date);
                param[1].Value = to;
                dt = dal.SelectData("SelectDeletedOperationByDate", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
        public DataTable SelectOperationsOfEmpByDate(string from, string to, int EmpID)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@From", SqlDbType.Date);
                param[0].Value = from;
                param[1] = new SqlParameter("@TO", SqlDbType.Date);
                param[1].Value = to;
                param[2] = new SqlParameter("@EmpID", SqlDbType.Int);
                param[2].Value = EmpID;
                dt = dal.SelectData("SelectOperationsOfEmpByDate", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
    }
}