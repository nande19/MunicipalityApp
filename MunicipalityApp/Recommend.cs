using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    public class Recommend
    {
       
        public EventDetails RecommendedEvent { get; set; }
        public string Reason { get; set; } // Explanation for the recommendation
        public DateTime RecommendedDate { get; set; } // When it was recommended
 
        public Recommend(EventDetails recommendedEvent, string reason, DateTime recommendedDate)
        {
            RecommendedEvent = recommendedEvent;
            Reason = reason;
            RecommendedDate = recommendedDate;
        }

    }


}
