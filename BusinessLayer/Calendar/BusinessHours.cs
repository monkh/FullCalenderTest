using System.Collections.Generic;

namespace BusinessLayer.Calendar
{

    public class BusinessHours
    {
        /// <summary>
        /// Days of the week that the business operators.
        /// </summary>
        public List<ICalendarEnums.DayOfTheWeek> dow { get; set; }

        /// <summary>
        /// Business shift start time
        /// </summary>
        public string start { get; set; }

        /// <summary>
        /// Business shift end time
        /// </summary>
        public string end { get; set; }


    }
}
