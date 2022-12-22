using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using GradProjectAPI.Models;

namespace GradProjectAPI.Controllers
{
    public class LockUpController : ApiController
    {
        LockUpMethods lockUpMethods = new LockUpMethods();
        [HttpGet]
        public DataTable SelectAttachments()
        {
            return lockUpMethods.SelectAttachments();
        }

        [HttpGet]
        public DataTable SelectGender()
        {
            return lockUpMethods.SelectGender();
        }

        [HttpGet]
        public DataTable SelectGovernments()
        {
            return lockUpMethods.SelectGovernments();
        }

        [HttpGet]
        public DataTable SelectGrades()
        {
            return lockUpMethods.SelectGrades();
        }

        [HttpGet]
        public DataTable SelectRoles()
        {
            return lockUpMethods.SelectRoles();
        }

        [HttpGet]
        public DataTable SelectSection()
        {
            return lockUpMethods.SelectSection();
        }

        [HttpGet]
        public DataTable SelectStatus()
        {
            return lockUpMethods.SelectStatus();
        }

        [HttpGet]
        public DataTable SelectTalbatTypes()
        {
            return lockUpMethods.SelectTalbatTypes();
        }
    }
}