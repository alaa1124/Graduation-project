using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GradProjectAPI.Models;
using static GradProjectAPI.Models.JasonHolidays;

namespace GradProjectAPI.Controllers
{
    public class AppointmentDateController : ApiController
    {
        AppointmentDateMethods methods = new AppointmentDateMethods();

        [HttpGet]
        public DataTable SelectMaxCapacity()
        {
            return methods.SelectMaxCapacity();
        }

        [HttpGet]
        public DataTable SelectDateCapacity(string Date)
        {
            return methods.SelectDateCapacity(Date);
        }

        [HttpGet]
        public List<string> Generate7Days()
        {
            return methods.Generate7Days();
        }
        
        [HttpGet]
        public Root ReturnHolidays()
        {
            return methods.ReturnHolidays();
        }

        [HttpPost]
        public bool IncreaseCapacity([FromUri] string Date)
        {
            return methods.IncreaseCapacity(Date);
        }

        [HttpPut]
        public bool UpdateMaxCapacity([FromUri] int Val)
        {
            return methods.UpdateMaxCapacity(Val);
        }
    }
}