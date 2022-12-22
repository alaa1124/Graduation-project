using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using Newtonsoft.Json;
using static GradProjectAPI.Models.JasonHolidays;

namespace GradProjectAPI.Models
{
    public class AppointmentDateMethods
    {
        DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

        public DataTable SelectMaxCapacity()
        {
            DataTable dt = null;
            try
            {
                DAL.Open();
                dt = new DataTable();
                dt = DAL.SelectData("SelectMaxCapacity", null);
                DAL.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public DataTable SelectDateCapacity(string Date)
        {
            DataTable dt = null;
            try
            {
                DAL.Open();
                dt = new DataTable();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@Date", SqlDbType.Date);
                param[0].Value = Date;
                dt = DAL.SelectData("SelectDateCapacity", param);
                DAL.Close();
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        public List<string> Generate7Days()
        {
            List<string> days = new List<string>();
            try
            {

                DateTime date = DateTime.Parse(DateTime.Now.ToShortDateString());
                //DateTime date = DateTime.Parse("2022/07/13");
                int i = 1;
                while (days.Count != 7)
                {
                    DateTime d = date.AddDays(i);
                    //First Check friday
                    if (d.DayOfWeek.ToString() != "Friday" && d.DayOfWeek.ToString() != "Saturday")
                    {
                        //Check if capacity day is full
                        DataTable MaxCapacity = SelectMaxCapacity();
                        DataTable Capacity = SelectDateCapacity(d.ToShortDateString());
                        if (Capacity.Rows.Count > 0)
                        {
                            if (int.Parse(Capacity.Rows[0][0].ToString()) < int.Parse(MaxCapacity.Rows[0][0].ToString()))
                            {
                                days.Add(d.ToShortDateString());
                            }
                        }
                        else
                        {
                            days.Add(d.ToShortDateString());
                        }
                    }
                    i++;
                }
                return days;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool IncreaseCapacity(string Date)
        {
            bool f = false;
            try
            {
                DAL.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@Date", SqlDbType.Date);
                param[0].Value = Date;
                f = DAL.ExecuteCommand("InsertOrUpdateCapacity", param);
                DAL.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }

        public Root ReturnHolidays()
        {
            WebClient w = new WebClient();
            w.Encoding = Encoding.UTF8;
            string startDate = "" + DateTime.Now.Year + "-01-01T10%3A00%3A00-07%3A00";
            string endDate = "" + DateTime.Now.AddYears(1).Year + "-01-01T10%3A00%3A00-07%3A00";
            string jsonString = w.DownloadString("https://www.googleapis.com/calendar/v3/calendars/ar.eg%23holiday%40group.v.calendar.google.com/events?timeMax=" + endDate + "&timeMin=" + startDate + "&key=AIzaSyDPXhf56Y9uNXnf0N61lwyPRiYyQs0TMcI");
            Root listTest = JsonConvert.DeserializeObject<Root>(jsonString);
            return listTest;
        }

        public bool UpdateMaxCapacity(int Val)
        {
            bool f = false;
            try
            {
                DAL.Open();
                SqlParameter[] param = new SqlParameter[1];
                param[0] = new SqlParameter("@Val", SqlDbType.Int);
                param[0].Value = Val;
                f = DAL.ExecuteCommand("UpdateMaxCapacity", param);
                DAL.Close();
                return f;
            }
            catch (Exception ex)
            {
                return f;
            }
        }
    }
}