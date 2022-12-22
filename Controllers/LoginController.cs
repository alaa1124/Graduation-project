using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GradProjectAPI.Models;
using System.Data;
using System.Data.SqlClient;

namespace GradProjectAPI.Controllers
{
    public class LoginController : ApiController
    {
        LoginMethods loginMethod = new LoginMethods();

        [HttpGet]
        public DataTable Login([FromUri] string username, [FromUri] string password)
        {
            return loginMethod.SelectLoginByUserNameAndPass(username, password);
        }
        [HttpGet]
        public DataTable SelectUserRoles([FromUri] int ID)
        {
            return loginMethod.SelectUserRoles(ID);
        }
        [HttpPost]
        public bool InsertLogin([FromBody] LoginVariables log)
        {
            return loginMethod.InsertLogin(log);
        }

        [HttpPut]
        public bool UpdateLogin([FromBody] LoginVariables log)
        {
            return loginMethod.UpdateLogin(log);
        }

        [HttpPut]
        public bool UpdateIsActive([FromUri] int ID)
        {
            return loginMethod.UpdateIsActive(ID);
        }

        [HttpPut]
        public bool UpdateIsNotActive([FromUri] int ID)
        {
            return loginMethod.UpdateIsNotActive(ID);
        }

        [HttpPut]
        public bool UpdateIsBlocked([FromUri] string EmpName)
        {
            return loginMethod.UpdateIsBlocked(EmpName);
        }

        [HttpPut]
        public bool UpdateIsNotBlocked([FromUri] string EmpName)
        {
            return loginMethod.UpdateIsNotBlocked(EmpName);
        }
    }
}