using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GradProjectAPI.Models
{
    public class HolidaysMethods
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

        public bool InsertDaysOff(HolidaysVariables date)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@StartHolidayDate", SqlDbType.Date);
                param[0].Value = date.StartHolidayDate;
                param[1] = new SqlParameter("@EndHolidayDate ", SqlDbType.Date);
                param[1].Value = date.EndHolidayDate;
                param[2] = new SqlParameter("@UniID", SqlDbType.Int);
                param[2].Value = date.UniID;
                param[3] = new SqlParameter("@UserID", SqlDbType.Int);
                param[3].Value = date.UserID;
                f = dal.ExecuteCommand("InsertHolidays", param);
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