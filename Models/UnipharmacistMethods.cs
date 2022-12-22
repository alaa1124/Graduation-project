using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GradProjectAPI.Models
{
    public class UnipharmacistMethods
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public bool InsertUniPharmacist(UnipharmacistVariables talb)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[24];
                param[0] = new SqlParameter("@SSD", SqlDbType.Char, 14);
                param[0].Value = talb.SSD;
                if (string.IsNullOrEmpty(talb.NameAR))
                {
                    param[1] = new SqlParameter("@NameAR", SqlDbType.NVarChar, 60);
                    param[1].Value = "-";
                }
                else
                {
                    param[1] = new SqlParameter("@NameAR", SqlDbType.NVarChar, 60);
                    param[1].Value = talb.NameAR;
                }
                if (string.IsNullOrEmpty(talb.NameEN))
                {
                    param[2] = new SqlParameter("@NameEN", SqlDbType.NVarChar, 60);
                    param[2].Value = "-";
                }
                else
                {
                    param[2] = new SqlParameter("@NameEN", SqlDbType.NVarChar, 60);
                    param[2].Value = talb.NameEN;
                }
                if (string.IsNullOrEmpty(talb.Address))
                {
                    param[3] = new SqlParameter("@Address", SqlDbType.NVarChar, int.MaxValue);
                    param[3].Value = "-";
                }
                else
                {
                    param[3] = new SqlParameter("@Address", SqlDbType.NVarChar, int.MaxValue);
                    param[3].Value = talb.Address;
                }
                if (string.IsNullOrEmpty(talb.EMail))
                {
                    param[4] = new SqlParameter("@EMail", SqlDbType.NVarChar, 60);
                    param[4].Value = "-";
                }
                else
                {
                    param[4] = new SqlParameter("@EMail", SqlDbType.NVarChar, 60);
                    param[4].Value = talb.EMail;
                }

                if (string.IsNullOrEmpty(talb.GovBirth.ToString()))
                {
                    param[5] = new SqlParameter("@GovBirth", SqlDbType.Int);
                    param[5].Value = DBNull.Value;
                }
                else
                {
                    param[5] = new SqlParameter("@GovBirth", SqlDbType.Int);
                    param[5].Value = talb.GovBirth;
                }
                if (string.IsNullOrEmpty(talb.GovStay.ToString()))
                {
                    param[6] = new SqlParameter("@GovStay", SqlDbType.Int);
                    param[6].Value = DBNull.Value;
                }
                else
                {
                    param[6] = new SqlParameter("@GovStay", SqlDbType.Int);
                    param[6].Value = talb.GovStay;
                }
                if (string.IsNullOrEmpty(talb.Tele1))
                {
                    param[7] = new SqlParameter("@Tele1", SqlDbType.Char, 11);
                    param[7].Value = "-";
                }
                else
                {
                    param[7] = new SqlParameter("@Tele1", SqlDbType.Char, 11);
                    param[7].Value = talb.Tele1;
                }
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

                if (string.IsNullOrEmpty(talb.Gender.ToString()))
                {
                    param[9] = new SqlParameter("@Gender", SqlDbType.Int);
                    param[9].Value = DBNull.Value;
                }
                else
                {
                    param[9] = new SqlParameter("@Gender", SqlDbType.Int);
                    param[9].Value = talb.Gender;
                }
                if (string.IsNullOrEmpty(talb.Nationality))
                {
                    param[10] = new SqlParameter("@Nationality", SqlDbType.NVarChar, 40);
                    param[10].Value = "-";
                }
                else
                {
                    param[10] = new SqlParameter("@Nationality", SqlDbType.NVarChar, 40);
                    param[10].Value = talb.Nationality;
                }
                if (string.IsNullOrEmpty(talb.DoB))
                {
                    param[11] = new SqlParameter("@DoB", SqlDbType.Date);
                    param[11].Value = DBNull.Value;
                }
                else
                {
                    param[11] = new SqlParameter("@DoB", SqlDbType.Date);
                    param[11].Value = talb.DoB;
                }
                if (string.IsNullOrEmpty(talb.Uni.ToString()))
                {
                    param[12] = new SqlParameter("@Uni", SqlDbType.Int);
                    param[12].Value = DBNull.Value;
                }
                else
                {
                    param[12] = new SqlParameter("@Uni", SqlDbType.Int);
                    param[12].Value = talb.Uni;
                }
                if (string.IsNullOrEmpty(talb.Section.ToString()))
                {
                    param[13] = new SqlParameter("@Section", SqlDbType.Int);
                    param[13].Value = DBNull.Value;
                }
                else
                {
                    param[13] = new SqlParameter("@Section", SqlDbType.Int);
                    param[13].Value = talb.Section;
                }

                if (string.IsNullOrEmpty(talb.Dof3a.ToString()))
                {
                    param[14] = new SqlParameter("@Dof3a", SqlDbType.Int);
                    param[14].Value = DBNull.Value;
                }
                else
                {
                    param[14] = new SqlParameter("@Dof3a", SqlDbType.Int);
                    param[14].Value = talb.Dof3a;
                }
                if (string.IsNullOrEmpty(talb.Doar))
                {
                    param[15] = new SqlParameter("@Doar", SqlDbType.NVarChar, 40);
                    param[15].Value = "-";
                }
                else
                {
                    param[15] = new SqlParameter("@Doar", SqlDbType.NVarChar, 40);
                    param[15].Value = talb.Doar;
                }
                if (string.IsNullOrEmpty(talb.Religion))
                {
                    param[16] = new SqlParameter("@Religion", SqlDbType.NVarChar, int.MaxValue);
                    param[16].Value = "-";
                }
                else
                {
                    param[16] = new SqlParameter("@Religion", SqlDbType.NVarChar, int.MaxValue);
                    param[16].Value = talb.Religion;
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
                if (string.IsNullOrEmpty(talb.TotalGrade.ToString()))
                {
                    param[18] = new SqlParameter("@TotalGrade", SqlDbType.Float);
                    param[18].Value = DBNull.Value;
                }
                else
                {
                    param[18] = new SqlParameter("@TotalGrade", SqlDbType.Float);
                    param[18].Value = talb.TotalGrade;
                }
                if (string.IsNullOrEmpty(talb.Grade.ToString()))
                {
                    param[19] = new SqlParameter("@StdGrade", SqlDbType.Float);
                    param[19].Value = DBNull.Value;
                }
                else
                {
                    param[19] = new SqlParameter("@StdGrade", SqlDbType.Float);
                    param[19].Value = talb.Grade;
                }

                if (string.IsNullOrEmpty(talb.Grade.ToString()))
                {
                    param[20] = new SqlParameter("@Grade", SqlDbType.Int);
                    param[20].Value = DBNull.Value;
                }
                else
                {
                    param[20] = new SqlParameter("@Grade", SqlDbType.Int);
                    param[20].Value = talb.Grade;
                }
                if (string.IsNullOrEmpty(talb.MkanTaklef))
                {
                    param[21] = new SqlParameter("@MkanTaKlef", SqlDbType.NVarChar, int.MaxValue);
                    param[21].Value = "-";
                }
                else
                {
                    param[21] = new SqlParameter("@MkanTaKlef", SqlDbType.NVarChar, int.MaxValue);
                    param[21].Value = talb.MkanTaklef;

                }
                if (string.IsNullOrEmpty(talb.NoOfQrar.ToString()))
                {
                    param[22] = new SqlParameter("@NoOfQrar", SqlDbType.Int);
                    param[22].Value = DBNull.Value;
                }
                else
                {
                    param[22] = new SqlParameter("@NoOfQrar", SqlDbType.Int);
                    param[22].Value = talb.NoOfQrar;
                }
                param[23] = new SqlParameter("@UserID", SqlDbType.Int);
                param[23].Value = talb.UserID;
                f = dal.ExecuteCommand("InsertUniPharmacists", param);
                dal.Close();

                return f;

            }
            catch (Exception ex)
            {
                return f;
            }
        }

        public bool UpdateUniPharmacist(UnipharmacistVariables talb)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[19];
                if (string.IsNullOrEmpty(talb.NameAR))
                {
                    param[0] = new SqlParameter("@NameAR", SqlDbType.NVarChar, 60);
                    param[0].Value = "-";
                }
                else
                {
                    param[0] = new SqlParameter("@NameAR", SqlDbType.NVarChar, 60);
                    param[0].Value = talb.NameAR;
                }
                if (string.IsNullOrEmpty(talb.NameEN))
                {
                    param[1] = new SqlParameter("@NameEN", SqlDbType.NVarChar, 60);
                    param[1].Value = "-";
                }
                else
                {
                    param[1] = new SqlParameter("@NameEN", SqlDbType.NVarChar, 60);
                    param[1].Value = talb.NameEN;
                }
                if (string.IsNullOrEmpty(talb.Address))
                {
                    param[2] = new SqlParameter("@Address", SqlDbType.NVarChar, int.MaxValue);
                    param[2].Value = "-";
                }
                else
                {
                    param[2] = new SqlParameter("@Address", SqlDbType.NVarChar, int.MaxValue);
                    param[2].Value = talb.Address;
                }
                if (string.IsNullOrEmpty(talb.EMail))
                {
                    param[3] = new SqlParameter("@EMail", SqlDbType.NVarChar, 60);
                    param[3].Value = "-";
                }
                else
                {
                    param[3] = new SqlParameter("@EMail", SqlDbType.NVarChar, 60);
                    param[3].Value = talb.EMail;
                }

                if (string.IsNullOrEmpty(talb.GovBirth.ToString()))
                {
                    param[4] = new SqlParameter("@GovBirth", SqlDbType.Int);
                    param[4].Value = DBNull.Value;
                }
                else
                {
                    param[4] = new SqlParameter("@GovBirth", SqlDbType.Int);
                    param[4].Value = talb.GovBirth;
                }
                if (string.IsNullOrEmpty(talb.GovStay.ToString()))
                {
                    param[5] = new SqlParameter("@GovStay", SqlDbType.Int);
                    param[5].Value = DBNull.Value;
                }
                else
                {
                    param[5] = new SqlParameter("@GovStay", SqlDbType.Int);
                    param[5].Value = talb.GovStay;
                }
                if (string.IsNullOrEmpty(talb.Tele1))
                {
                    param[6] = new SqlParameter("@Tele1", SqlDbType.Char, 11);
                    param[6].Value = "-";
                }
                else
                {
                    param[6] = new SqlParameter("@Tele1", SqlDbType.Char, 11);
                    param[6].Value = talb.Tele1;
                }
                if (string.IsNullOrEmpty(talb.Tele2))
                {
                    param[7] = new SqlParameter("@Tele2", SqlDbType.Char, 11);
                    param[7].Value = "-";
                }
                else
                {
                    param[7] = new SqlParameter("@Tele2", SqlDbType.Char, 11);
                    param[7].Value = talb.Tele2;
                }

                if (string.IsNullOrEmpty(talb.Gender.ToString()))
                {
                    param[8] = new SqlParameter("@Gender", SqlDbType.Int);
                    param[8].Value = DBNull.Value;
                }
                else
                {
                    param[8] = new SqlParameter("@Gender", SqlDbType.Int);
                    param[8].Value = talb.Gender;
                }

                if (string.IsNullOrEmpty(talb.Nationality))
                {
                    param[9] = new SqlParameter("@Nationality", SqlDbType.NVarChar, 40);
                    param[9].Value = "-";
                }
                else
                {
                    param[9] = new SqlParameter("@Nationality", SqlDbType.NVarChar, 40);
                    param[9].Value = talb.Nationality;
                }
                if (string.IsNullOrEmpty(talb.DoB))
                {
                    param[10] = new SqlParameter("@DoB", SqlDbType.Date);
                    param[10].Value = DBNull.Value;
                }
                else
                {
                    param[10] = new SqlParameter("@DoB", SqlDbType.Date);
                    param[10].Value = talb.DoB;
                }
                if (string.IsNullOrEmpty(talb.Uni.ToString()))
                {
                    param[11] = new SqlParameter("@Uni", SqlDbType.Int);
                    param[11].Value = DBNull.Value;
                }
                else
                {
                    param[11] = new SqlParameter("@Uni", SqlDbType.Int);
                    param[11].Value = talb.Uni;
                }
                if (string.IsNullOrEmpty(talb.Section.ToString()))
                {
                    param[12] = new SqlParameter("@Section", SqlDbType.Int);
                    param[12].Value = DBNull.Value;
                }
                else
                {
                    param[12] = new SqlParameter("@Section", SqlDbType.Int);
                    param[12].Value = talb.Section;
                }

                if (string.IsNullOrEmpty(talb.Dof3a.ToString()))
                {
                    param[13] = new SqlParameter("@Dof3a", SqlDbType.Int);
                    param[13].Value = DBNull.Value;
                }
                else
                {
                    param[13] = new SqlParameter("@Dof3a", SqlDbType.Int);
                    param[13].Value = talb.Dof3a;
                }
                if (string.IsNullOrEmpty(talb.Doar))
                {
                    param[14] = new SqlParameter("@Doar", SqlDbType.NVarChar, 40);
                    param[14].Value = "-";
                }
                else
                {
                    param[14] = new SqlParameter("@Doar", SqlDbType.NVarChar, 40);
                    param[14].Value = talb.Doar;
                }
                if (string.IsNullOrEmpty(talb.Religion))
                {
                    param[15] = new SqlParameter("@Religion", SqlDbType.NVarChar, int.MaxValue);
                    param[15].Value = "-";
                }
                else
                {
                    param[15] = new SqlParameter("@Religion", SqlDbType.NVarChar, int.MaxValue);
                    param[15].Value = talb.Religion;
                }

                if (string.IsNullOrEmpty(talb.MkanTaklef))
                {
                    param[16] = new SqlParameter("@MkanTaKlef", SqlDbType.NVarChar, int.MaxValue);
                    param[16].Value = "-";
                }
                else
                {
                    param[16] = new SqlParameter("@MkanTaKlef", SqlDbType.NVarChar, int.MaxValue);
                    param[16].Value = talb.MkanTaklef;

                }
                param[17] = new SqlParameter("@UserID", SqlDbType.Int);
                param[17].Value = talb.UserID;
                param[18] = new SqlParameter("@ID", SqlDbType.Int);
                param[18].Value = talb.ID;
                f = dal.ExecuteCommand("UpdateUniPharmacists", param);
                dal.Close();

                return f;

            }
            catch (Exception ex)
            {
                return f;
            }
        }

        public DataTable SelectUniPhByQrarNo(int QrarNo)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@QrarNo", SqlDbType.Int);
                param[0].Value = QrarNo;
                dt = dal.SelectData("SelectUniByQrarNo", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public DataTable SelectUniPhBySSD(string SSD)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@SSD", SqlDbType.NVarChar, 14);
                param[0].Value = SSD;
                dt = dal.SelectData("SelectUniBySSD", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
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
    }
}