using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GradProjectAPI.Models
{
    public class PharmacistTaklefMethods
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public bool InsertPharmacistTaklef(PharmacistTaklefVariables talb)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@StartTaklefDate", SqlDbType.Date);
                param[0].Value = talb.StartTaklefDate;
                param[1] = new SqlParameter("@EndTaklefDate", SqlDbType.Date);
                param[1].Value = talb.EndTaklefDate;
                param[2] = new SqlParameter("@UniID", SqlDbType.Int);
                param[2].Value = talb.UniID;
                f = dal.ExecuteCommand("InsertPharmacistTaklef", param);
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