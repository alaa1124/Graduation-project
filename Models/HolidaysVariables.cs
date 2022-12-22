using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GradProjectAPI.Models
{
    public class HolidaysVariables
    {
        public string StartHolidayDate { set; get; }
        public string EndHolidayDate { set; get; }
        public int UniID { set; get; }
        public int UserID { set; get; }
    }
}