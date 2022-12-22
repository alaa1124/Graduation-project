using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GradProjectAPI.Models
{
    public class LoginVariables
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string RoleName { get; set; }
        public string EmpName { get; set; }
        public int UserID { get; set; }
    }
}