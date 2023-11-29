using GradProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GradProjectAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeesMethods employeeMethod = new EmployeesMethods();
        AssignedTalbatMethods assigned = new AssignedTalbatMethods();

        [HttpPost]
        public bool InsertEmployee([FromBody] EmployeesVariables Emp)
        {
            return employeeMethod.InsertEmployee(Emp);
        }
        [HttpPost]
        public bool InsertRole([FromUri] String Name, int RoleID)
        {
            return employeeMethod.InsertRole(Name, RoleID);
        }
        [HttpPut]
        public bool UpdateEmployee([FromBody] EmployeesVariables Emp)
        {
            return employeeMethod.UpdateEmployee(Emp);
        }
        [HttpPut]
        public bool UpdateDeleteEmployee([FromUri] int empID)
        {

            return employeeMethod.UpdateDeleteEmp(empID);
        }

        [HttpGet]
        public DataTable SelectAllEmployeesByRole([FromUri] string RoleName)
        {
            return employeeMethod.SelectAllEmpByRole(RoleName);
        }

        [HttpGet]
        public DataTable SelectEmployeeByName([FromUri] string empName)
        {
            return employeeMethod.SelectEmpByName(empName);
        }

        [HttpGet]
        public DataTable SelectEmployeeBySSD([FromUri] string SSN)
        {
            return employeeMethod.SelectEmpBySSD(SSN);
        }

        [HttpGet]
        public DataTable SelectAllEmployeesByName()
        {
            return employeeMethod.SelectAllEmpByName();
        }
        [HttpGet]
        public DataTable SelectAllEmployees()
        {
            return employeeMethod.SelectAllEmployees();
        }
        [HttpGet]
        public DataTable SelectRolesByName([FromUri] String Name)
        {
            return employeeMethod.SelectRolesByName(Name);
        }
        [HttpGet]
        public DataTable SelectUserRoles([FromUri] int ID)
        {
            return employeeMethod.SelectUserRoles(ID);
        }
        [HttpPost]
        public bool InsertAssignedTalbat([FromUri] int NumOfTasks, [FromUri] string EmpName)
        {
            return assigned.InsertAssignedTalbat(NumOfTasks, EmpName);
        }

        [HttpPut]
        public bool UpdateAssignedTalbat([FromUri] int NumOfTasks, [FromUri] string EmpName, [FromUri] int ID)
        {
            return assigned.UpdateAssignedTalbat(NumOfTasks, EmpName, ID);
        }

        [HttpGet]
        public DataTable SelectAssignedTalbat([FromUri] string EmpName)
        {
            return assigned.SelectAssignedTalbat(EmpName);
        }

        [HttpDelete]
        public bool DeleteAssignedTalbat([FromUri] int ID)
        {
            return assigned.DeleteAssignedTalbat(ID);
        }

        [HttpDelete]
        public bool DeleteRole([FromUri] String Name, int RoleID)
        {
            return employeeMethod.DeleteRole(Name, RoleID);
        }
    }
}
