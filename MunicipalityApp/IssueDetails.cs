using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalityApp
{
    //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// variables are here, this is where data is stored
        /// </summary>
    public class IssueDetails
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<string> Attachments { get; set; } // List of file paths for attached images/documents

        public IssueDetails(string location, string category, string description, List<string> attachments)
        {
            Location = location;
            Category = category;
            Description = description;
            Attachments = attachments;
        }

        // Method to display the issue details (optional for debugging or display purposes)
        public override string ToString()
        {
            return $"Location: {Location}, Category: {Category}, Description: {Description}, Attachments: {Attachments.Count}";
        }
    }
}
        //---------------------------------------- END OF FILE -------------------------------------------------------//

