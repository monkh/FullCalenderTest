using System.Collections.Generic;

namespace BusinessLayer.Calendar
{

    public class BusinessHours
    {
// Supressed name style warnings because object serialized 
#pragma warning disable IDE1006 // Naming Styles
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
#pragma warning restore IDE1006 // Naming Styles
    }
}
