using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GradProjectAPI.Models;
using System.Data;

namespace GradProjectAPI.Controllers
{
    public class TalbatOnlineController : ApiController
    {
        TalbatOnlineMethods talbOnlineMethod = new TalbatOnlineMethods();

        [HttpGet]
        public DataTable SelectTalbOnlineByTalbCode([FromUri] string TalbCode)
        {
            return talbOnlineMethod.SelectTalbOnlineByTalbCode(TalbCode);
        }

        [HttpGet]
        public DataTable SelectTalbOnlineBySSD([FromUri] string SSN)
        {
            return talbOnlineMethod.SelectTalbOnlineBySSD(SSN);
        }
        [HttpGet]
        public DataTable SelectOnlineDataByName([FromUri] string Name)
        {
            return talbOnlineMethod.SelectOnlineDataByName(Name);
        }
        [HttpGet]
        public DataTable SelectDataFromUniPharmacistBySSN([FromUri] string SSN)
        {
            return talbOnlineMethod.SelectDataFromUniPharmacistBySSN(SSN);
        }

        [HttpGet]
        public DataTable SelectEndTaklefDateBySSN([FromUri] string SSN)
        {
            return talbOnlineMethod.SelectEndTaklefDateBySSN(SSN);
        }

        [HttpGet]
        public DataTable SelectReceivedTalabtByTalbCode([FromUri] string TalbCode)
        {
            return talbOnlineMethod.SelectReceivedTalabtByTalbCode(TalbCode);
        }

        [HttpGet]
        public DataTable SelectReceivedTalabtBySSD([FromUri] string SSD)
        {
            return talbOnlineMethod.SelectReceivedTalabtBySSD(SSD);
        }
        [HttpGet]
        public DataTable SelectReceivedTalabtByName([FromUri] string NameAR)
        {
            return talbOnlineMethod.SelectReceivedTalabtByName(NameAR);
        }

        [HttpPost]
        public bool InsertOnlineTalb([FromBody] TalbatOnlineVariables talb)
        {
            return talbOnlineMethod.InsertOnlineTalb(talb);
        }

        [HttpPut]
        public bool UpdateIsReceived([FromUri] int ID)
        {
            return talbOnlineMethod.UpdateIsReceived(ID);
        }

        [HttpPut]
        public bool UpdateIsNotReceived([FromUri] int ID)
        {
            return talbOnlineMethod.UpdateIsNotReceived(ID);
        }

        [HttpGet]
        public DataTable CheckLastMkanTaklef([FromUri] string SSN)
        {
            return talbOnlineMethod.CheckLastMkanTaklef(SSN);
        }

        [HttpGet]
        public DataTable SelectLastInsertedTalbCode()
        {
            return talbOnlineMethod.SelectLastInsertedTalbCode();
        }
    }
}