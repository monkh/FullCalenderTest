using BusinessLayer.Calendar;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Script.Serialization;
using static BusinessLayer.Calendar.ICalendarEnums;

namespace FullCalendarTestAPI.Controllers
{
    [Authorize]
    public class ValuesController : ApiController
    {
        // Get() is sample to return some random events for last 14 days
        // GET api/values
        public RootObject Get()
        {
            // Create Bussiness Hours object
            var days_of_week = new List<DayOfTheWeek>
            {
                DayOfTheWeek.Monday,
                DayOfTheWeek.Tuesday,
                DayOfTheWeek.Wednesday,
                DayOfTheWeek.Thursday,
                DayOfTheWeek.Friday
            };
            string event_start = "09:00";
            string event_end = "17:00"; //DateTime.Now.AddDays(-3).AddHours(+5).ToUniversalTime().ToString();
            var business_hours = new BusinessHours
            {
                dow = days_of_week,
                start = event_start,
                end = event_end
            };

            // create RootObject
            var calendar = new RootObject
            {
                businessHours = business_hours,
                
            };

            return calendar;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
