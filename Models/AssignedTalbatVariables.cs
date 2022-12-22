using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GradProjectAPI.Models
{
    public class AssignedTalbatVariables
    {
        public int EmpID { get; set; }
        public int NumOfTasks { get; set; }
        public string AssignDate { get; set; }
        public int NumOfTasksDone { get; set; }
        public string DoneDate { get; set; }
    }
}