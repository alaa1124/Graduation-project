using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace GradProjectAPI.Models
{
    public class LoginMethods
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public bool InsertLogin(LoginVariables log)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 20);
                param[0].Value = log.UserName;
                param[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 20);
                param[1].Value = log.Password;
                param[2] = new SqlParameter("@EMPName", SqlDbType.NVarChar, 50);
                param[2].Value = log.EmpName;
                param[3] = new SqlParameter("@UserID", SqlDbType.Int);
                param[3].Value = log.UserID;
                f = dal.ExecuteCommand("InsertLogin", param);
                dal.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }
        public bool UpdateLogin(LoginVariables log)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 20);
                param[0].Value = log.UserName;
                param[1] = new SqlParameter("@pass", SqlDbType.NVarChar, 20);
                param[1].Value = log.Password;
                param[2] = new SqlParameter("@EmpName", SqlDbType.NVarChar, 50);
                param[2].Value = log.EmpName;
                param[3] = new SqlParameter("@UserID", SqlDbType.Int);
                param[3].Value = log.UserID;
                f = dal.ExecuteCommand("UpdateLogin", param);
                dal.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }
        public DataTable SelectLoginByUserNameAndPass(string username, string password)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@UserName", SqlDbType.NVarChar, 20);
                param[0].Value = username;
                param[1] = new SqlParameter("@Password", SqlDbType.NVarChar, 20);
                param[1].Value = password;
                dt = dal.SelectData("SelectLoginByUserNameAndPass", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public DataTable SelectUserRoles(int ID)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;
                dt = dal.SelectData("SelectUserRoles", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public bool UpdateIsActive(int ID)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;
                f = dal.ExecuteCommand("UpdateIsActive", param);
                dal.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }

        public bool UpdateIsNotActive(int ID)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;
                f = dal.ExecuteCommand("UpdateIsNotActive", param);
                dal.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }

        public bool UpdateIsNotBlocked(string EmpName)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@EmpName", SqlDbType.NVarChar, 60);
                param[0].Value = EmpName;
                f = dal.ExecuteCommand("UpdateIsNotBlocked", param);
                dal.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }
        public bool UpdateIsBlocked(string EmpName)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@EmpName", SqlDbType.NVarChar, 60);
                param[0].Value = EmpName;
                f = dal.ExecuteCommand("UpdateIsBlocked", param);
                dal.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }
    }
}