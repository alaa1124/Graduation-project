using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


namespace GradProjectAPI.Models
{
    public class AssignedTalbatMethods
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public bool InsertAssignedTalbat(int NumOfTasks, string EmpName)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@NumOfTasks", SqlDbType.Int);
                param[0].Value = NumOfTasks;
                param[1] = new SqlParameter("@EmpName", SqlDbType.NVarChar, 60);
                param[1].Value = EmpName;
                f = dal.ExecuteCommand("InsertAssignedTalbat", param);
                dal.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }
        public bool UpdateAssignedTalbat(int NumOfTasks, string EmpName, int ID)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@NumOfTasks", SqlDbType.Int);
                param[0].Value = NumOfTasks;
                param[1] = new SqlParameter("@EmpName", SqlDbType.NVarChar, 60);
                param[1].Value = EmpName;
                param[2] = new SqlParameter("@ID", SqlDbType.Int);
                param[2].Value = ID;
                f = dal.ExecuteCommand("UpdateAssignedTalbat", param);
                dal.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }
        public DataTable SelectAssignedTalbat(string EmpName)
        {
            DataTable dt = null;
            try
            {
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@EmpName", SqlDbType.NVarChar, 60);
                param[0].Value = EmpName;
                dal.Open();
                dt = dal.SelectData("SelectAssignedTalbat", param);
                dal.Close();
                return dt;
            }
            catch (Exception e)
            {
                return dt;
            }
        }

        public bool DeleteAssignedTalbat(int ID)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;
                f = dal.ExecuteCommand("DeleteAssignedTalbat", param);
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