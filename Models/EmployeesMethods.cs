using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GradProjectAPI.Models
{
    public class EmployeesMethods
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public bool InsertEmployee(EmployeesVariables Emp)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[9];
                param[0] = new SqlParameter("@SSD", SqlDbType.Char, 14);
                param[0].Value = Emp.SSD;
                param[1] = new SqlParameter("@NameAR", SqlDbType.NVarChar, 60);
                param[1].Value = Emp.NameAR;
                if (string.IsNullOrEmpty(Emp.Address))
                {
                    param[2] = new SqlParameter("@Address", SqlDbType.NVarChar, int.MaxValue);
                    param[2].Value = "-";
                }
                else
                {
                    param[2] = new SqlParameter("@Address", SqlDbType.NVarChar, int.MaxValue);
                    param[2].Value = Emp.Address;
                }
                param[3] = new SqlParameter("@Tele1", SqlDbType.Char, 11);
                param[3].Value = Emp.Tele1;
                if (string.IsNullOrEmpty(Emp.Tele2))
                {
                    param[4] = new SqlParameter("@Tele2", SqlDbType.Char, 11);
                    param[4].Value = "-";
                }
                else
                {
                    param[4] = new SqlParameter("@Tele2", SqlDbType.Char, 11);
                    param[4].Value = Emp.Tele2;
                }
                if (string.IsNullOrEmpty(Emp.Gender.ToString()))
                {
                    param[5] = new SqlParameter("@Gender", SqlDbType.NVarChar, 5);
                    param[5].Value = DBNull.Value;
                }
                else
                {
                    param[5] = new SqlParameter("@Gender", SqlDbType.NVarChar, 5);
                    param[5].Value = Emp.Gender;
                }
                if (string.IsNullOrEmpty(Emp.Status.ToString()))
                {
                    param[6] = new SqlParameter("@Status", SqlDbType.NVarChar, 10);
                    param[6].Value = DBNull.Value;
                }
                else
                {
                    param[6] = new SqlParameter("@Status", SqlDbType.NVarChar, 10);
                    param[6].Value = Emp.Status;
                }
                if (string.IsNullOrEmpty(Emp.DoB))
                {
                    param[7] = new SqlParameter("@DoB", SqlDbType.Date);
                    param[7].Value = DBNull.Value;
                }
                else
                {
                    param[7] = new SqlParameter("@DoB", SqlDbType.Date);
                    param[7].Value = Emp.DoB;
                }
                param[8] = new SqlParameter("@UserID", SqlDbType.Int);
                param[8].Value = Emp.UserID;
                f = dal.ExecuteCommand("InsertEmployee", param);
                dal.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }

        public bool InsertRole(String Name, int RoleID)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@EmpName", SqlDbType.NVarChar, 60);
                param[0].Value = Name;
                param[1] = new SqlParameter("@RoleID", SqlDbType.TinyInt);
                param[1].Value = RoleID;
                f = dal.ExecuteCommand("InsertRole", param);
                dal.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }

        }
        public bool DeleteRole(String Name, int RoleID)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[2];
                param[0] = new SqlParameter("@EmpName", SqlDbType.NVarChar, 60);
                param[0].Value = Name;
                param[1] = new SqlParameter("@RoleID", SqlDbType.TinyInt);
                param[1].Value = RoleID;
                f = dal.ExecuteCommand("DeleteRole", param);
                dal.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }
        public DataTable SelectRolesByName(String Name)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@EmpName", SqlDbType.NVarChar, 60);
                param[0].Value = Name;
                dt = dal.SelectData("SelectRolesByName", param);
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
        public DataTable SelectAllEmployees()
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable(); 
                dt = dal.SelectData("SelectAllEmployees", null);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
        public bool UpdateEmployee(EmployeesVariables Emp)
        {
            bool f = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[10];
                param[0] = new SqlParameter("@SSD", SqlDbType.Char, 14);
                param[0].Value = Emp.SSD;
                param[1] = new SqlParameter("@NameAR", SqlDbType.NVarChar, 60);
                param[1].Value = Emp.NameAR;
                if (string.IsNullOrEmpty(Emp.Address))
                {
                    param[2] = new SqlParameter("@Address", SqlDbType.NVarChar, int.MaxValue);
                    param[2].Value = "-";
                }
                else
                {
                    param[2] = new SqlParameter("@Address", SqlDbType.NVarChar, int.MaxValue);
                    param[2].Value = Emp.Address;
                }
                param[3] = new SqlParameter("@Tele1", SqlDbType.Char, 11);
                param[3].Value = Emp.Tele1;
                if (string.IsNullOrEmpty(Emp.Tele2))
                {
                    param[4] = new SqlParameter("@Tele2", SqlDbType.Char, 11);
                    param[4].Value = "-";
                }
                else
                {
                    param[4] = new SqlParameter("@Tele2", SqlDbType.Char, 11);
                    param[4].Value = Emp.Tele2;
                }
                if (string.IsNullOrEmpty(Emp.Gender.ToString()))
                {
                    param[5] = new SqlParameter("@Gender", SqlDbType.TinyInt);
                    param[5].Value = DBNull.Value;
                }
                else
                {
                    param[5] = new SqlParameter("@Gender", SqlDbType.TinyInt);
                    param[5].Value = Emp.Gender;
                }
                if (string.IsNullOrEmpty(Emp.Status.ToString()))
                {
                    param[6] = new SqlParameter("@Status", SqlDbType.TinyInt);
                    param[6].Value = DBNull.Value;
                }
                else
                {
                    param[6] = new SqlParameter("@Status", SqlDbType.TinyInt);
                    param[6].Value = Emp.Status;
                }
                if (string.IsNullOrEmpty(Emp.DoB))
                {
                    param[7] = new SqlParameter("@DoB", SqlDbType.Date);
                    param[7].Value = DBNull.Value;
                }
                else
                {
                    param[7] = new SqlParameter("@DoB", SqlDbType.Date);
                    param[7].Value = Emp.DoB;
                }
                param[8] = new SqlParameter("@UserID", SqlDbType.Int);
                param[8].Value = Emp.UserID;
                param[9] = new SqlParameter("@EmpID", SqlDbType.Int);
                param[9].Value = Emp.EID;
                f = dal.ExecuteCommand("UpdateEmployee", param);
                dal.Close();
                return f;

            }
            catch (Exception ex)
            {
                return f;
            }
        }
        public bool UpdateDeleteEmp(int empID)
        {
            bool f = false;
            bool b = false;
            try
            {
                dal.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@EmpID", SqlDbType.Int);
                param[0].Value = empID;
                f = dal.ExecuteCommand("UpdateDeleteEmp", param);
                SqlParameter[] param1 = new SqlParameter[1];
                param1[0] = new SqlParameter("@EmpID", SqlDbType.Int);
                param1[0].Value = empID;
                b = dal.ExecuteCommand("UpdateDeleteLogin", param1);
                dal.Close();
                return f && b;

            }
            catch (Exception ex)
            {
                return f && b;
            }

        }
        public DataTable SelectEmpByName(string empName)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@NameAR", SqlDbType.NVarChar, 60);
                param[0].Value = empName;
                dt = dal.SelectData("SelectEmpByName", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public DataTable SelectEmpBySSD(string SSN)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@SSN", SqlDbType.VarChar, 14);
                param[0].Value = SSN;
                dt = dal.SelectData("SelectEmpBySSD", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
        public DataTable SelectAllEmpByRole(string RoleName)
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@RoleName", SqlDbType.NVarChar, 50);
                param[0].Value = RoleName;
                dt = dal.SelectData("SelectAllEmpByRole", param);
                dal.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
        public DataTable SelectAllEmpByName()
        {
            DataTable dt = null;
            try
            {
                dal.Open();
                dt = new DataTable();
                dt = dal.SelectData("SelectNamesOfEmps", null);
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