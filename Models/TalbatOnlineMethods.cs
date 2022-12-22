using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace GradProjectAPI.Models
{
    public class TalbatOnlineMethods
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public bool InsertOnlineTalb(TalbatOnlineVariables talb)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[36];
                param[0] = new SqlParameter("@SSD", SqlDbType.Char, 14);
                param[0].Value = talb.SSD;
                param[1] = new SqlParameter("@NameAR", SqlDbType.NVarChar, 60);
                param[1].Value = talb.NameAR;
                param[2] = new SqlParameter("@NameEN", SqlDbType.NVarChar, 60);
                param[2].Value = talb.NameEN;
                param[3] = new SqlParameter("@Address", SqlDbType.NVarChar, int.MaxValue);
                param[3].Value = talb.Address;
                param[4] = new SqlParameter("@GovBirth", SqlDbType.TinyInt);
                param[4].Value = talb.GovBirth;

                param[5] = new SqlParameter("@GovStay", SqlDbType.TinyInt);
                param[5].Value = talb.GovStay;
                param[6] = new SqlParameter("@EMail", SqlDbType.NVarChar, 60);
                param[6].Value = talb.EMail;
                param[7] = new SqlParameter("@Tele1", SqlDbType.Char, 11);
                param[7].Value = talb.Tele1;
                if (string.IsNullOrEmpty(talb.Tele2))
                {
                    param[8] = new SqlParameter("@Tele2", SqlDbType.Char, 11);
                    param[8].Value = DBNull.Value;
                }
                else
                {
                    param[8] = new SqlParameter("@Tele2", SqlDbType.Char, 11);
                    param[8].Value = "-";
                }
                param[9] = new SqlParameter("@Gender", SqlDbType.TinyInt);
                param[9].Value = talb.Gender;

                param[10] = new SqlParameter("@Status", SqlDbType.TinyInt);
                param[10].Value = talb.Status;
                param[11] = new SqlParameter("@DoB", SqlDbType.Date);
                param[11].Value = talb.DoB;
                param[12] = new SqlParameter("@Uni", SqlDbType.TinyInt);
                param[12].Value = talb.Uni;
                param[13] = new SqlParameter("@Section", SqlDbType.TinyInt);
                param[13].Value = talb.Section;

                param[14] = new SqlParameter("@Dof3a", SqlDbType.SmallInt);
                param[14].Value = talb.Dof3a;
                param[15] = new SqlParameter("@Doar", SqlDbType.NVarChar, 40);
                param[15].Value = talb.Doar;
                if (string.IsNullOrEmpty(talb.TotalGrade.ToString()))
                {
                    param[16] = new SqlParameter("@TotalGrade", SqlDbType.Float);
                    param[16].Value = DBNull.Value;
                }
                else
                {
                    param[16] = new SqlParameter("@TotalGrade", SqlDbType.Float);
                    param[16].Value = talb.TotalGrade;
                }
                if (string.IsNullOrEmpty(talb.SumE3tbary.ToString()))
                {
                    param[17] = new SqlParameter("@SumE3tbary", SqlDbType.Float);
                    param[17].Value = DBNull.Value;
                }
                else
                {
                    param[17] = new SqlParameter("@SumE3tbary", SqlDbType.Float);
                    param[17].Value = talb.SumE3tbary;
                }
                if (string.IsNullOrEmpty(talb.Grade.ToString()))
                {
                    param[18] = new SqlParameter("@Grade", SqlDbType.TinyInt);
                    param[18].Value = DBNull.Value;
                }
                else
                {
                    param[18] = new SqlParameter("@Grade", SqlDbType.TinyInt);
                    param[18].Value = talb.Grade;
                }
                param[19] = new SqlParameter("@TTID", SqlDbType.TinyInt);
                param[19].Value = talb.TTID;
                if (string.IsNullOrEmpty(talb.EditFrom))
                {
                    param[20] = new SqlParameter("@From", SqlDbType.NVarChar, int.MaxValue);
                    param[20].Value = "-";
                }
                else
                {
                    param[20] = new SqlParameter("@From", SqlDbType.NVarChar, int.MaxValue);
                    param[20].Value = talb.EditFrom;
                }

                if (string.IsNullOrEmpty(talb.EditTo))
                {
                    param[21] = new SqlParameter("@To", SqlDbType.NVarChar, int.MaxValue);
                    param[21].Value = "-";
                }
                else
                {
                    param[21] = new SqlParameter("@To", SqlDbType.NVarChar, int.MaxValue);
                    param[21].Value = talb.EditTo;
                }

                if (string.IsNullOrEmpty(talb.Reason))
                {
                    param[22] = new SqlParameter("@Reason", SqlDbType.NVarChar, int.MaxValue);
                    param[22].Value = "-";
                }
                else
                {
                    param[22] = new SqlParameter("@Reason", SqlDbType.NVarChar, int.MaxValue);
                    param[22].Value = talb.Reason;
                }

                if (string.IsNullOrEmpty(talb.ActuallDateOfWork))
                {
                    param[23] = new SqlParameter("@ActuallDateOfWork", SqlDbType.Date);
                    param[23].Value = DBNull.Value;
                }
                else
                {
                    param[23] = new SqlParameter("@ActuallDateOfWork", SqlDbType.Date);
                    param[23].Value = talb.ActuallDateOfWork;
                }

                if (string.IsNullOrEmpty(talb.QrarNo.ToString()))
                {
                    param[24] = new SqlParameter("@QrarNo", SqlDbType.Int);
                    param[24].Value = DBNull.Value;
                }
                else
                {
                    param[24] = new SqlParameter("@QrarNo", SqlDbType.Int);
                    param[24].Value = talb.QrarNo;
                }
                if (string.IsNullOrEmpty(talb.QrarDate))
                {
                    param[25] = new SqlParameter("@QrarDate", SqlDbType.Date);
                    param[25].Value = DBNull.Value;
                }
                else
                {
                    param[25] = new SqlParameter("@QrarDate", SqlDbType.Date);
                    param[25].Value = talb.QrarDate;
                }

                if (string.IsNullOrEmpty(talb.Sa7bQrarNo.ToString()))
                {
                    param[26] = new SqlParameter("@Sa7bQrarNo", SqlDbType.Int);
                    param[26].Value = DBNull.Value;
                }
                else
                {
                    param[26] = new SqlParameter("@Sa7bQrarNo", SqlDbType.Int);
                    param[26].Value = talb.Sa7bQrarNo;
                }
                if (string.IsNullOrEmpty(talb.Sa7bQrarYear.ToString()))
                {
                    param[27] = new SqlParameter("@Sa7bQrarYear", SqlDbType.SmallInt);
                    param[27].Value = DBNull.Value;
                }
                else
                {
                    param[27] = new SqlParameter("@Sa7bQrarYear", SqlDbType.SmallInt);
                    param[27].Value = talb.Sa7bQrarYear;
                }
                if (string.IsNullOrEmpty(talb.Sa7bQrarFrom))
                {
                    param[28] = new SqlParameter("@Sa7bQrarFrom", SqlDbType.NVarChar, int.MaxValue);
                    param[28].Value = "-";
                }
                else
                {
                    param[28] = new SqlParameter("@Sa7bQrarFrom", SqlDbType.NVarChar, int.MaxValue); ;
                    param[28].Value = talb.Sa7bQrarFrom;
                }
                if (string.IsNullOrEmpty(talb.Sa7bQrarTo))
                {
                    param[29] = new SqlParameter("@Sa7bQrarTo", SqlDbType.NVarChar, int.MaxValue);
                    param[29].Value = "-";
                }
                else
                {
                    param[29] = new SqlParameter("@Sa7bQrarTo", SqlDbType.NVarChar, int.MaxValue); ;
                    param[29].Value = talb.Sa7bQrarTo;
                }

                if (string.IsNullOrEmpty(talb.PreviousTaklefQrarNo.ToString()))
                {
                    param[30] = new SqlParameter("@PreviousTaklefQrarNo", SqlDbType.Int);
                    param[30].Value = DBNull.Value;
                }
                else
                {
                    param[30] = new SqlParameter("@PreviousTaklefQrarNo", SqlDbType.Int); ;
                    param[30].Value = talb.PreviousTaklefQrarNo;
                }
                if (string.IsNullOrEmpty(talb.PreviousTaklefQrarYear.ToString()))
                {
                    param[31] = new SqlParameter("@PreviousTaklefQrarYear", SqlDbType.SmallInt);
                    param[31].Value = DBNull.Value;
                }
                else
                {
                    param[31] = new SqlParameter("@PreviousTaklefQrarYear", SqlDbType.SmallInt); ;
                    param[31].Value = talb.PreviousTaklefQrarYear;
                }
                if (string.IsNullOrEmpty(talb.PreviousTaklefTo))
                {
                    param[32] = new SqlParameter("@PreviousTaklefTo", SqlDbType.NVarChar, int.MaxValue);
                    param[32].Value = "-";
                }
                else
                {
                    param[32] = new SqlParameter("@PreviousTaklefTo", SqlDbType.NVarChar, int.MaxValue); ;
                    param[32].Value = talb.PreviousTaklefTo;
                }


                param[33] = new SqlParameter("@AppointmentDate", SqlDbType.Date);
                param[33].Value = talb.AppointmentDate;
                param[34] = new SqlParameter("@IsLagna3lya", SqlDbType.Bit);
                param[34].Value = talb.Islagna3lia;
                param[35] = new SqlParameter("@UPID", SqlDbType.Int);
                param[35].Value = talb.UPID;

                f = dal.ExecuteCommand("InsertTalbOnline", param);
                dal.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }

        public DataTable SelectTalbOnlineByTalbCode(string TalbCode)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@TalbCode", SqlDbType.VarChar, 10);
                param[0].Value = TalbCode;
                dt = dal.SelectData("SelectTalbOnlineByTalbCode", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public DataTable SelectTalbOnlineBySSD(string SSD)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@SSD", SqlDbType.Char, 14);
                param[0].Value = SSD;
                dt = dal.SelectData("SelectOnlineDataBySSD", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
        public DataTable SelectOnlineDataByName(string Name)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@NameAR", SqlDbType.NVarChar, 60);
                param[0].Value = Name;
                dt = dal.SelectData("SelectOnlineDataByName", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
        public DataTable SelectDataFromUniPharmacistBySSN(string SSN)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@SSD", SqlDbType.NVarChar, 14);
                param[0].Value = SSN;
                dt = dal.SelectData("SelectUniBySSD", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public DataTable SelectReceivedTalabtByTalbCode(string TalbCode)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@TalbCode", SqlDbType.VarChar, 10);
                param[0].Value = TalbCode;
                dt = dal.SelectData("SelectReceivedTalabtByTalbCode", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
        public DataTable SelectReceivedTalabtBySSD(string SSD)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@SSD", SqlDbType.Char, 14);
                param[0].Value = SSD;
                dt = dal.SelectData("SelectReceivedTalabtBySSD", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
        public DataTable SelectReceivedTalabtByName(string Name)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@NameAR", SqlDbType.NVarChar, 60);
                param[0].Value = Name;
                dt = dal.SelectData("SelectReceivedTalabtByName", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public DataTable SelectEndTaklefDateBySSN(string SSN)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@SSD", SqlDbType.Char, 14);
                param[0].Value = SSN;
                dt = dal.SelectData("SelectEndTaklefDate", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public bool UpdateIsReceived(int ID)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;
                f = dal.ExecuteCommand("UpdateIsRecieved", param);
                dal.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }

        public bool UpdateIsNotReceived(int ID)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@ID", SqlDbType.Int);
                param[0].Value = ID;
                f = dal.ExecuteCommand("UpdateIsNotRecieved", param);
                dal.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }

        public DataTable CheckLastMkanTaklef(string SSN)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@SSN", SqlDbType.NVarChar, 14);
                param[0].Value = SSN;
                dt = dal.SelectData("CheckLastMkanTaklef", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public DataTable SelectLastInsertedTalbCode()
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = dal.SelectData("SelectLastInsertedTalbCode", null);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }
    }
}