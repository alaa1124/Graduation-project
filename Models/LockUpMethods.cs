using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace GradProjectAPI.Models
{
    public class LockUpMethods
    {
        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
        public DataTable SelectAttachments()
        {
            DataTable dt = null;
            try
            {
                DAL.Open();
                dt = new DataTable();
                dt = DAL.SelectData("SelectAttachments", null);
                DAL.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public DataTable SelectGender()
        {
            DataTable dt = null;
            try
            {
                DAL.Open();
                dt = new DataTable();
                dt = DAL.SelectData("SelectGender", null);
                DAL.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public DataTable SelectGovernments()
        {
            DataTable dt = null;
            try
            {
                DAL.Open();
                dt = new DataTable();
                dt = DAL.SelectData("SelectGovernments", null);
                DAL.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public DataTable SelectGrades()
        {
            DataTable dt = null;
            try
            {
                DAL.Open();
                dt = new DataTable();
                dt = DAL.SelectData("SelectGrades", null);
                DAL.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public DataTable SelectRoles()
        {
            DataTable dt = null;
            try
            {
                DAL.Open();
                dt = new DataTable();
                dt = DAL.SelectData("SelectRoles", null);
                DAL.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public DataTable SelectSection()
        {
            DataTable dt = null;
            try
            {
                DAL.Open();
                dt = new DataTable();
                dt = DAL.SelectData("SelectSection", null);
                DAL.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public DataTable SelectStatus()
        {
            DataTable dt = null;
            try
            {
                DAL.Open();
                dt = new DataTable();
                dt = DAL.SelectData("SelectStatus", null);
                DAL.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public DataTable SelectTalbatTypes()
        {
            DataTable dt = null;
            try
            {
                DAL.Open();
                dt = new DataTable();
                dt = DAL.SelectData("SelectTalbatTypes", null);
                DAL.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
    }
}