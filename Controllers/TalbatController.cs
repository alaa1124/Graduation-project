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
    public class TalbatController : ApiController
    {
        TalbatMethods talbMethod = new TalbatMethods();
        TalbatOnlineMethods talbOnlineMethod = new TalbatOnlineMethods();

        [HttpGet]
        public DataTable SearchByTalbCode([FromUri] string TalbCode)
        {
            return talbMethod.SearchByTalbCode(TalbCode);
        }

        [HttpGet]
        public DataTable SearchBySSN([FromUri] string SSN)
        {
            return talbMethod.SearchDataBySSD(SSN);
        }

        [HttpGet]
        public DataTable SearchByName([FromUri] string Name)
        {
            return talbMethod.SearchDataByName(Name);
        }

        [HttpGet]
        public DataTable SearchDataByTalbTypeAndDate([FromUri] int TalbID, [FromUri] string DateFrom, [FromUri] string DateTo)
        {
            return talbMethod.SearchDataByTalbTypeAndData(TalbID, DateFrom, DateTo);
        }

        [HttpGet]
        public DataTable SearchAcceptedE3adtTaklefTalbByDate([FromUri] string DateFrom, [FromUri] string DateTo)
        {
            return talbMethod.SearchAcceptedE3adtTaklefTalbByDate(DateFrom, DateTo);
        }

        [HttpGet]
        public DataTable SearchNotAcceptedE3adtTaklefTalbByDate([FromUri] string DateFrom, [FromUri] string DateTo)
        {
            return talbMethod.SearchNotAcceptedE3adtTaklefTalbByDate(DateFrom, DateTo);
        }

        [HttpGet]
        public DataTable SearchAcceptedEst5ragBayan7alaTalbByDate([FromUri] string DateFrom, [FromUri] string DateTo)
        {
            return talbMethod.SearchAcceptedEst5ragBayan7alaTalbByDate(DateFrom, DateTo);
        }

        [HttpGet]
        public DataTable SearchNotAcceptedEst5ragBayan7alaTalbByDate([FromUri] string DateFrom, [FromUri] string DateTo)
        {
            return talbMethod.SearchNotAcceptedEst5ragBayan7alaTalbByDate(DateFrom, DateTo);
        }

        [HttpGet]
        public DataTable SearchAcceptedSa7bQrarT3delTalbByDate([FromUri] string DateFrom, [FromUri] string DateTo)
        {
            return talbMethod.SearchAcceptedSa7bQrarT3delTalbByDate(DateFrom, DateTo);
        }

        [HttpGet]
        public DataTable SearchNotAcceptedSa7bQrarT3delTalbByDate([FromUri] string DateFrom, [FromUri] string DateTo)
        {
            return talbMethod.SearchNotAcceptedSa7bQrarT3delTalbByDate(DateFrom, DateTo);
        }

        [HttpGet]
        public DataTable SearchTalbatByDate([FromUri] string DateFrom, [FromUri] string DateTo)
        {
            return talbMethod.SearchTalbatByDate(DateFrom, DateTo);
        }

        [HttpGet]
        public DataTable SearchByTalbTypeAndNotAcceptedResultByDate([FromUri] string DateFrom, [FromUri] string DateTo, [FromUri] int TalbID)
        {
            return talbMethod.SearchByTalbTypeAndNotAcceptedResultByDate(DateFrom, DateTo, TalbID);
        }

        [HttpGet]
        public DataTable SearchByTalbTypeAndAcceptedResultByDate([FromUri] string DateFrom, [FromUri] string DateTo, [FromUri] int TalbID)
        {
            return talbMethod.SearchByTalbTypeAndAcceptedResultByDate(DateFrom, DateTo, TalbID);
        }

        [HttpGet]
        public DataTable SearchByAcceptedResultByDate([FromUri] string DateFrom, [FromUri] string DateTo)
        {
            return talbMethod.SearchByAcceptedResultByDate(DateFrom, DateTo);
        }

        [HttpGet]
        public DataTable SearchByNotAcceptedResultByDate([FromUri] string DateFrom, [FromUri] string DateTo)
        {
            return talbMethod.SearchByNotAcceptedResultByDate(DateFrom, DateTo);
        }

        [HttpGet]
        public DataTable SearchDataByTalbType([FromUri] int TalbID)
        {
            return talbMethod.SearchDataByTalbType(TalbID);
        }

        [HttpGet]
        public DataTable SearchNotAcceptedTa3delTalbByDate([FromUri] string DateFrom, string DateTo)
        {
            return talbMethod.SearchNotAcceptedTa3delTalbByDate(DateFrom, DateTo);
        }

        [HttpGet]
        public DataTable SearchAcceptedTa3delTalbByDate([FromUri] string DateFrom, string DateTo)
        {
            return talbMethod.SearchAcceptedT3delTalbByDate(DateFrom, DateTo);
        }

        [HttpGet]
        public DataTable SearchNotAcceptedEl8aaTalbByDate([FromUri] string DateFrom, string DateTo)
        {
            return talbMethod.SearchNotAcceptedEl8aaTalbByDate(DateFrom, DateTo);
        }

        [HttpGet]
        public DataTable SearchAcceptedEl8aaTalbByDate([FromUri] string DateFrom, string DateTo)
        {
            return talbMethod.SearchAcceptedEl8aaTalbByDate(DateFrom, DateTo);
        }

        [HttpGet]
        public DataTable SearchNotAcceptedE3faaTalbByDate([FromUri] string DateFrom, string DateTo)
        {
            return talbMethod.SearchNotAcceptedE3faaTalbByDate(DateFrom, DateTo);
        }

        [HttpGet]
        public DataTable SearchAcceptedE3faaTalbByDate([FromUri] string DateFrom, string DateTo)
        {
            return talbMethod.SearchAcceptedE3faaTalbByDate(DateFrom, DateTo);
        }

        [HttpGet]
        public DataTable SearchByLagnaNo([FromUri] string LagnaNo)
        {
            return talbMethod.SearchByLagnaNo(LagnaNo);
        }

        [HttpGet]
        public DataTable SearchDataByLagnaNoAndNotAcceptedResult([FromUri] string LagnaNo)
        {
            return talbMethod.SearchDataByLagnaNoAndNotAcceptedResult(LagnaNo);
        }

        [HttpGet]
        public DataTable SearchDataByLagnaNoAndAcceptedResult([FromUri] string LagnaNo)
        {
            return talbMethod.SearchDataByLagnaNoAndAcceptedResult(LagnaNo);
        }

        [HttpGet]
        public DataTable SelectResultForPharmacist([FromUri] string TalbCode)
        {
            return talbMethod.SelectResultForPharmacist(TalbCode);
        }

        [HttpGet]
        public DataTable SelectResultForEmployee([FromUri] string TalbCode)
        {
            return talbMethod.SelectResultForEmployee(TalbCode);
        }

        [HttpGet]
        public DataTable SelectTalbOnlineByTalbCode([FromUri] string TalbCode)
        {
            return talbOnlineMethod.SelectTalbOnlineByTalbCode(TalbCode);
        }

        [HttpGet]
        public DataTable SelectTodayAttachments()
        {
            return talbMethod.SelectTodayAttachments();
        }

        [HttpGet]
        public DataTable SelectAttachmentsByTalbCode([FromUri] string TalbCode)
        {
            return talbMethod.SelectAttachmentsByTalbCode(TalbCode);
        }

        [HttpPost]
        public bool InsertTalb([FromBody] TalbatVarialbes talb)
        {
            return talbMethod.InsertTalb(talb);
        }

        [HttpPut]
        public bool ApproveAttachments([FromUri] string TalbCode)
        {
            return talbMethod.ApproveAttachment(TalbCode);
        }

        [HttpPut]
        public bool NotApproveAttachments([FromUri] string TalbCode)
        {
            return talbMethod.NotApproveAttachment(TalbCode);
        }

        [HttpPut]
        public bool InsertResult([FromUri] string TalbCode, [FromUri] string Result, [FromUri] string Notes, [FromUri] int UserID)
        {
            return talbMethod.InsertResult(TalbCode, Result, Notes, UserID);
        }

        [HttpPut]
        public bool InsertLagnaNo([FromUri] string TalbCode, [FromUri] string LagnaNo, [FromUri] int UserID)
        {
            return talbMethod.InsertLagnaNo(TalbCode, LagnaNo, UserID);
        }

        [HttpPut]
        public bool UpdateTalb([FromBody] TalbatVarialbes talb)
        {
            return talbMethod.UpdateTalb(talb);
        }

        [HttpGet]
        public DataTable CheckResultWithSSN([FromUri] string SSN)
        {
            return talbMethod.CheckResultWithSSN(SSN);
        }

        [HttpGet]
        public DataTable SelectDataByName([FromUri] string Name)
        {
            return talbMethod.SelectDataByName(Name);
        }

        [HttpGet]
        public DataTable SelectTop5AssignedDate([FromUri] int UserID)
        {
            return talbMethod.SelectTop5AssignedDate(UserID);
        }
    }
}