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
    public class UniPharmacistController : ApiController
    {
        UnipharmacistMethods uniph = new UnipharmacistMethods();
        PharmacistTaklefMethods PhTakLefMethod = new PharmacistTaklefMethods();
        HolidaysMethods holiday = new HolidaysMethods();

        [HttpPost]
        public bool InsertUnipharmacist([FromBody] UnipharmacistVariables UniPhar)
        {
            return uniph.InsertUniPharmacist(UniPhar);
        }

        [HttpPut]
        public bool UpdateUnipharmacist([FromBody] UnipharmacistVariables UniPhar)
        {
            return uniph.UpdateUniPharmacist(UniPhar);
        }

        [HttpPost]
        public bool InsertPharmacistTaklef([FromBody] PharmacistTaklefVariables PhTaklef)
        {
            return PhTakLefMethod.InsertPharmacistTaklef(PhTaklef);
        }

        [HttpPost]
        public bool InsertDaysOff([FromBody] HolidaysVariables agaza)
        {
            return holiday.InsertDaysOff(agaza);
        }

        [HttpGet]
        public DataTable SelectUniPhByQrarNo([FromUri] int QrarNum)
        {
            return uniph.SelectUniPhByQrarNo(QrarNum);
        }

        [HttpGet]
        public DataTable SelectUniphBySSD([FromUri] string SSN)
        {
            return uniph.SelectUniPhBySSD(SSN);
        }

        [HttpGet]
        public DataTable CheckLastMkanTaklef([FromUri] string SSN)
        {
            return uniph.CheckLastMkanTaklef(SSN);
        }
    }
}