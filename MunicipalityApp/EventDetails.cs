using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    //--------------------------------------------------------------------------------------------------------//

    /// <summary>
    /// Class to store event details.
    /// </summary>
    /// 
    public class EventDetails
    {
        public DateTime Date { get; set; }
        public string EventName { get; set; }
        public string Duration { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }

        public EventDetails(DateTime date, string eventName, string duration, string category, string location)
        {
            Date = date;
            EventName = eventName;
            Duration = duration;
            Category = category;
            Location = location;
        }
    }
}
        //---------------------------------------- END OF FILE -------------------------------------------------------//
