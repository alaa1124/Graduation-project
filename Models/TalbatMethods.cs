using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace GradProjectAPI.Models
{
    public class TalbatMethods
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        //Done
        public bool InsertTalb(TalbatVarialbes talb)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[39];
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
                    param[8].Value = "-";
                }
                else
                {
                    param[8] = new SqlParameter("@Tele2", SqlDbType.Char, 11);
                    param[8].Value = talb.Tele2;
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
                    param[18].Value = 0;
                }
                else
                {
                    param[18] = new SqlParameter("@Grade", SqlDbType.TinyInt);
                    param[18].Value = talb.Grade;
                }
                param[19] = new SqlParameter("@TTID", SqlDbType.TinyInt);
                param[19].Value = talb.TTID;


                if (string.IsNullOrEmpty(talb.From))
                {
                    param[20] = new SqlParameter("@From", SqlDbType.NVarChar, int.MaxValue);
                    param[20].Value = "-";
                }
                else
                {
                    param[20] = new SqlParameter("@From", SqlDbType.NVarChar, int.MaxValue);
                    param[20].Value = talb.From;
                }
                if (string.IsNullOrEmpty(talb.To))
                {
                    param[21] = new SqlParameter("@To", SqlDbType.NVarChar, int.MaxValue);
                    param[21].Value = "-";
                }
                else
                {
                    param[21] = new SqlParameter("@To", SqlDbType.NVarChar, int.MaxValue);
                    param[21].Value = talb.To;
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
                param[33] = new SqlParameter("@TalbCode", SqlDbType.VarChar, 10);
                param[33].Value = talb.TalbCode;
                param[34] = new SqlParameter("@AssignedDate", SqlDbType.Date);
                param[34].Value = talb.AssignedDate;

                param[35] = new SqlParameter("@IsLagna3lya", SqlDbType.Bit);
                param[35].Value = talb.Islagna3lia;
                param[36] = new SqlParameter("@Attachments", SqlDbType.NVarChar, int.MaxValue);
                param[36].Value = talb.Attachments;
                param[37] = new SqlParameter("@UserID", SqlDbType.Int);
                param[37].Value = talb.UserID;
                param[38] = new SqlParameter("@UPID", SqlDbType.Int);
                param[38].Value = talb.UPID;
                f = dal.ExecuteCommand("InsertPharmcist3Tables", param);
                dal.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }
        //Done
        public bool UpdateTalb(TalbatVarialbes talb)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[39];
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
                    param[8].Value = "-";
                }
                else
                {
                    param[8] = new SqlParameter("@Tele2", SqlDbType.Char, 11);
                    param[8].Value = talb.Tele2;
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


                if (string.IsNullOrEmpty(talb.From))
                {
                    param[20] = new SqlParameter("@From", SqlDbType.NVarChar, int.MaxValue);
                    param[20].Value = "-";
                }
                else
                {
                    param[20] = new SqlParameter("@From", SqlDbType.NVarChar, int.MaxValue);
                    param[20].Value = talb.From;
                }
                if (string.IsNullOrEmpty(talb.To))
                {
                    param[21] = new SqlParameter("@To", SqlDbType.NVarChar, int.MaxValue);
                    param[21].Value = "-";
                }
                else
                {
                    param[21] = new SqlParameter("@To", SqlDbType.NVarChar, int.MaxValue);
                    param[21].Value = talb.To;
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
                param[33] = new SqlParameter("@TalbCode", SqlDbType.VarChar, 10);
                param[33].Value = talb.TalbCode;
                param[34] = new SqlParameter("@AssignedDate", SqlDbType.Date);
                param[34].Value = talb.AssignedDate;

                param[35] = new SqlParameter("@IsLagna3lya", SqlDbType.Bit);
                param[35].Value = talb.Islagna3lia;
                param[36] = new SqlParameter("@Attachments", SqlDbType.NVarChar, int.MaxValue);
                param[36].Value = talb.Attachments;
                param[37] = new SqlParameter("@UserID", SqlDbType.Int);
                param[37].Value = talb.UserID;
                param[38] = new SqlParameter("@PID", SqlDbType.Int);
                param[38].Value = talb.PID;
                f = dal.ExecuteCommand("UpdatePharmcist3Tables", param);
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }
        //Done
        public bool ApproveAttachment(string TalbCode)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@TalbCode", SqlDbType.NVarChar, 10);
                param[0].Value = TalbCode;
                f = dal.ExecuteCommand("AttachmentsApprove", param);
                dal.Close();
                return f;
            }
            catch (Exception)
            {
                return f;
            }
        }
        //Done
        public bool NotApproveAttachment(string TalbCode)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@TalbCode", SqlDbType.NVarChar, 10);
                param[0].Value = TalbCode;
                f = dal.ExecuteCommand("AttachmentsNotApprove", param);
                dal.Close();
                return f;
            }
            catch (Exception)
            {
                return f;
            }
        }
        //Done
        public bool InsertResult(string TalbCode, string Result, string Notes, int UserID)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[4];
                param[0] = new SqlParameter("@TalbCode", SqlDbType.NVarChar, int.MaxValue);
                param[0].Value = TalbCode;
                param[1] = new SqlParameter("@Result", SqlDbType.NVarChar, 30);
                param[1].Value = Result;
                if (string.IsNullOrEmpty(Notes))
                {
                    param[2] = new SqlParameter("@Notes", SqlDbType.NVarChar, int.MaxValue);
                    param[2].Value = "-";
                }
                else
                {
                    param[2] = new SqlParameter("@Notes", SqlDbType.NVarChar, int.MaxValue);
                    param[2].Value = Notes;
                }
                param[3] = new SqlParameter("@UserID", SqlDbType.Int);
                param[3].Value = UserID;
                f = dal.ExecuteCommand("InsertResult", param);
                dal.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }
        //Done
        public bool InsertLagnaNo(string TalbCode, string LagnaNo, int UserID)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@TalbCode", SqlDbType.NVarChar, int.MaxValue);
                param[0].Value = TalbCode;
                param[1] = new SqlParameter("@LagnaNo", SqlDbType.Date);
                param[1].Value = LagnaNo;
                param[2] = new SqlParameter("@UserID", SqlDbType.Int);
                param[2].Value = UserID;
                f = dal.ExecuteCommand("InsertUpdateLagnaNo", param);
                dal.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }
        //Done
        public DataTable SearchByTalbCode(string TalbCode)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@TalbCode", SqlDbType.NVarChar, 10);
                param[0].Value = TalbCode;
                dt = dal.SelectData("SelectDataByTalbCode", param);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }
        //Done
        public DataTable SearchDataBySSD(string SSD)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@SSD", SqlDbType.Char, 14);
                param[0].Value = SSD;

                dt = dal.SelectData("SelectDataBySSD", param);
                dal.Close();
                return dt;
            }
            catch (Exception e)
            {
                return dt;
            }
        }

        public DataTable SearchDataByName(string Name)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 60);
                param[0].Value = Name;

                dt = dal.SelectData("SelectDataByName", param);
                dal.Close();
                return dt;
            }
            catch (Exception e)
            {
                return dt;
            }
        }

        //Done
        public DataTable SearchDataByTalbTypeAndData(int TalbID, string DateFrom, string DateTo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@TalbID", SqlDbType.Int);
                param[0].Value = TalbID;
                param[1] = new SqlParameter("@DateFrom", SqlDbType.Date);
                param[1].Value = DateFrom;
                param[2] = new SqlParameter("@DateTo", SqlDbType.Date);
                param[2].Value = DateTo;
                dt = dal.SelectData("SelectDataByTalbTypeAndDate", param);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }
        //Done
        public DataTable SearchByTalbTypeAndNotAcceptedResultByDate(string DateFrom, string DateTo, int TalbID)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@DateFrom", SqlDbType.Date);
                param[0].Value = DateFrom;
                param[1] = new SqlParameter("@DateTo", SqlDbType.Date);
                param[1].Value = DateTo;
                param[2] = new SqlParameter("@TalbID", SqlDbType.Int);
                param[2].Value = TalbID;
                dt = dal.SelectData("SelectDataByTalbTypeAndNotAcceptedResult", param);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }
        //Done
        public DataTable SearchByTalbTypeAndAcceptedResultByDate(string DateFrom, string DateTo, int TalbID)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[3];
                param[0] = new SqlParameter("@DateFrom", SqlDbType.Date);
                param[0].Value = DateFrom;
                param[1] = new SqlParameter("@DateTo", SqlDbType.Date);
                param[1].Value = DateTo;
                param[2] = new SqlParameter("@TalbID", SqlDbType.Int);
                param[2].Value = TalbID;
                dt = dal.SelectData("SelectDataByTalbTypeAndAcceptedResult", param);
                dal.Close();
                return dt;
            }
            catch (Exception e)
            {
                return dt;
            }
        }
        //Done
        public DataTable SearchByAcceptedResultByDate(string DateFrom, string DateTo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@DateFrom", SqlDbType.Date);
                param[0].Value = DateFrom;
                param[1] = new SqlParameter("@DateTo", SqlDbType.Date);
                param[1].Value = DateTo;
                dt = dal.SelectData("SelectDataByAcceptedResult", param);
                dal.Close();
                return dt;
            }
            catch (Exception e)
            {
                return dt;
            }
        }
        //Done
        public DataTable SearchByNotAcceptedResultByDate(string DateFrom, string DateTo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@DateFrom", SqlDbType.Date);
                param[0].Value = DateFrom;
                param[1] = new SqlParameter("@DateTo", SqlDbType.Date);
                param[1].Value = DateTo;
                dt = dal.SelectData("SelectDataByNotAcceptedResult", param);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }
        //Done
        public DataTable SearchDataByTalbType(int TalbID)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@TalbID", SqlDbType.Int);
                param[0].Value = TalbID;
                dt = dal.SelectData("SelectDataByTalbType", param);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }

        public DataTable SearchAcceptedE3adtTaklefTalbByDate(string DateFrom, string DateTo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@DateFrom", SqlDbType.Date);
                param[0].Value = DateFrom;
                param[1] = new SqlParameter("@DateTo", SqlDbType.Date);
                param[1].Value = DateTo;
                dt = dal.SelectData("SelectAcceptedE3adetTaklefTalb", param);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }

        public DataTable SearchNotAcceptedE3adtTaklefTalbByDate(string DateFrom, string DateTo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@DateFrom", SqlDbType.Date);
                param[0].Value = DateFrom;
                param[1] = new SqlParameter("@DateTo", SqlDbType.Date);
                param[1].Value = DateTo;
                dt = dal.SelectData("SelectNotAcceptedE3adetTaklefTalb", param);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }

        public DataTable SearchAcceptedEst5ragBayan7alaTalbByDate(string DateFrom, string DateTo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@DateFrom", SqlDbType.Date);
                param[0].Value = DateFrom;
                param[1] = new SqlParameter("@DateTo", SqlDbType.Date);
                param[1].Value = DateTo;
                dt = dal.SelectData("SelectAcceptedEst5ragBayan7alaTalb", param);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }

        public DataTable SearchNotAcceptedEst5ragBayan7alaTalbByDate(string DateFrom, string DateTo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@DateFrom", SqlDbType.Date);
                param[0].Value = DateFrom;
                param[1] = new SqlParameter("@DateTo", SqlDbType.Date);
                param[1].Value = DateTo;
                dt = dal.SelectData("SelectNotAcceptedEst5ragBayan7alaTalb", param);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }

        public DataTable SearchAcceptedSa7bQrarT3delTalbByDate(string DateFrom, string DateTo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@DateFrom", SqlDbType.Date);
                param[0].Value = DateFrom;
                param[1] = new SqlParameter("@DateTo", SqlDbType.Date);
                param[1].Value = DateTo;
                dt = dal.SelectData("SelectAcceptedSa7bQrarT3delTaklef", param);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }

        public DataTable SearchNotAcceptedSa7bQrarT3delTalbByDate(string DateFrom, string DateTo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@DateFrom", SqlDbType.Date);
                param[0].Value = DateFrom;
                param[1] = new SqlParameter("@DateTo", SqlDbType.Date);
                param[1].Value = DateTo;
                dt = dal.SelectData("SelectNotAcceptedSa7bQrarT3delTaklef", param);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }

        public DataTable SearchTalbatByDate(string DateFrom, string DateTo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@DateFrom", SqlDbType.Date);
                param[0].Value = DateFrom;
                param[1] = new SqlParameter("@DateTo", SqlDbType.Date);
                param[1].Value = DateTo;
                dt = dal.SelectData("SelectTalbatByDate", param);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }

        //Done
        public DataTable SearchNotAcceptedTa3delTalbByDate(string DateFrom, string DateTo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@DateFrom", SqlDbType.Date);
                param[0].Value = DateFrom;
                param[1] = new SqlParameter("@DateTo", SqlDbType.Date);
                param[1].Value = DateTo;
                dt = dal.SelectData("SelectNotAcceptedT3del", param);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }
        //Done
        public DataTable SearchAcceptedT3delTalbByDate(string DateFrom, string DateTo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@DateFrom", SqlDbType.Date);
                param[0].Value = DateFrom;
                param[1] = new SqlParameter("@DateTo", SqlDbType.Date);
                param[1].Value = DateTo;
                dt = dal.SelectData("SelectAcceptedT3del", param);
                dal.Close();
                return dt;
            }
            catch (Exception e)
            {
                return dt;
            }
        }
        //Done
        public DataTable SearchNotAcceptedEl8aaTalbByDate(string DateFrom, string DateTo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@DateFrom", SqlDbType.Date);
                param[0].Value = DateFrom;
                param[1] = new SqlParameter("@DateTo", SqlDbType.Date);
                param[1].Value = DateTo;
                dt = dal.SelectData("SelectNotAcceptedEl8aa", param);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }
        //Done
        public DataTable SearchAcceptedEl8aaTalbByDate(string DateFrom, string DateTo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@DateFrom", SqlDbType.Date);
                param[0].Value = DateFrom;
                param[1] = new SqlParameter("@DateTo", SqlDbType.Date);
                param[1].Value = DateTo;
                dt = dal.SelectData("SelectAcceptedEl8aa", param);
                dal.Close();
                return dt;
            }
            catch (Exception e)
            {
                return dt;
            }
        }
        //Done
        public DataTable SearchNotAcceptedE3faaTalbByDate(string DateFrom, string DateTo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@DateFrom", SqlDbType.Date);
                param[0].Value = DateFrom;
                param[1] = new SqlParameter("@DateTo", SqlDbType.Date);
                param[1].Value = DateTo;
                dt = dal.SelectData("SelectNotAcceptedE3faa", param);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }
        //Done
        public DataTable SearchAcceptedE3faaTalbByDate(string DateFrom, string DateTo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@DateFrom", SqlDbType.Date);
                param[0].Value = DateFrom;
                param[1] = new SqlParameter("@DateTo", SqlDbType.Date);
                param[1].Value = DateTo;
                dt = dal.SelectData("SelectAcceptedE3faa", param);
                dal.Close();
                return dt;
            }
            catch (Exception e)
            {
                return dt;
            }
        }
        //Done
        public DataTable SearchByLagnaNo(string LagnaNo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@LagnaNo", SqlDbType.Date);
                param[0].Value = LagnaNo;
                dt = dal.SelectData("SelectByLagnaNo", param);
                dal.Close();
                return dt;
            }
            catch (Exception e)
            {
                return dt;
            }
        }
        //Done
        public DataTable SearchDataByLagnaNoAndNotAcceptedResult(string LagnaNo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@LagnaNo", SqlDbType.Date);
                param[0].Value = LagnaNo;
                dt = dal.SelectData("SelectDataByLagnaNoAndNotAcceptedResult", param);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }
        //Done
        public DataTable SearchDataByLagnaNoAndAcceptedResult(string LagnaNo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@LagnaNo", SqlDbType.Date);
                param[0].Value = LagnaNo;

                dt = dal.SelectData("SelectDataByLagnaNoAndAcceptedResult", param);
                dal.Close();
                return dt;
            }
            catch (Exception e)
            {
                return dt;
            }
        }
        //Done
        public DataTable SelectResultForPharmacist(string TalbCode)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@TalbCode", SqlDbType.NVarChar, 10);
                param[0].Value = TalbCode;
                dt = dal.SelectData("SelectResultForPharmacist", param);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }
        //Done
        public DataTable SelectResultForEmployee(string TalbCode)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@TalbCode", SqlDbType.NVarChar, 10);
                param[0].Value = TalbCode;
                dt = dal.SelectData("SelectResultForEmployee", param);
                dal.Close();
                return dt;
            }
            catch (Exception)
            {
                return dt;
            }
        }
        //Done
        public DataTable SelectTodayAttachments()
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = dal.SelectData("SelectTodayAttachments", null);
                dal.Close();
                return dt;
            }
            catch (Exception e)
            {
                return dt;
            }
        }
        //Done
        public DataTable SelectAttachmentsByTalbCode(string TalbCode)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@TalbCode", SqlDbType.NVarChar, 10);
                param[0].Value = TalbCode;
                dt = dal.SelectData("SelectAttachmentsByTalbCode", param);
                dal.Close();
                return dt;
            }
            catch (Exception e)
            {

                return dt;
            }
        }

        public DataTable CheckResultWithSSN(string SSN)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@SSN", SqlDbType.NVarChar, 14);
                param[0].Value = SSN;
                dt = dal.SelectData("CheckResultWithSSN", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public DataTable SelectDataByName(string Name)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@Name", SqlDbType.NVarChar, 60);
                param[0].Value = Name;
                dt = dal.SelectData("SelectDataByName", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public DataTable SelectTop5AssignedDate(int UserID)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@UserID", SqlDbType.Int);
                param[0].Value = UserID;
                dt = dal.SelectData("SelectTop5AssignedDate", param);
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