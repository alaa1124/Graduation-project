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
    public class StatisticsController : ApiController
    {
        DBOperationmethods report = new DBOperationmethods();

        [HttpGet]
        public DataTable SelectByInsertedOperation()
        {
            return report.SelectByInsertedOperation();
        }

        [HttpGet]
        public DataTable SelectInsertedOperationByDate([FromUri] string from, [FromUri] string to)
        {
            return report.SelectInsertedOperationByDate(from, to);
        }

        [HttpGet]
        public DataTable SelectByUpdatedOperation()
        {
            return report.SelectByUpdatedOperation();
        }

        [HttpGet]
        public DataTable SelectUpdatedOperationByDate([FromUri] string from, [FromUri] string to)
        {
            return report.SelectUpdatedOperationByDate(from, to);
        }

        [HttpGet]
        public DataTable SelectByDeletedOperation()
        {
            return report.SelectByDeletedOperation();
        }

        [HttpGet]
        public DataTable SelectDeletedOperationByDate([FromUri] string from, [FromUri] string to)
        {
            return report.SelectDeletedOperationByDate(from, to);
        }

        [HttpGet]
        public DataTable SelectOperationsOfEmpByDate([FromUri] string from, [FromUri] string to, [FromUri] int EmpID)
        {
            return report.SelectOperationsOfEmpByDate(from, to, EmpID);
        }
    }
}