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
    public class IssueDetails : IComparable<IssueDetails>
    {
        public string RequestId { get; set; }         // Unique identifier for each issue

        public string Location { get; set; }        // The location where the issue was reported

        public string Category { get; set; }        // The category of the issue (e.g., electrical, plumbing, etc.)

        public string Description { get; set; }        // A detailed description of the issue

        public List<string> Attachments { get; set; } // List of file paths for attached images/documents
        public int Priority { get; set; }      // Priority level of the issue (e.g., 1 = high priority)

        public string Status { get; set; } // Status can change

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Constructor to initialize a new IssueDetails object with given values.
        /// </summary>
        public IssueDetails(string location, string category, string description, List<string> attachments, int priority)
        {
           // RequestId = Guid.NewGuid().ToString(); // Generate a unique ID
            Location = location;
            Category = category;
            Description = description;
            Attachments = attachments;
            Priority = priority;

            Status = "PENDING - INVESTIGATION NOT STARTED"; // Default status

            // Generate RequestId only once
            GenerateRequestId(new Random());
        }

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Generates a custom RequestId using a random letter and a random number between 10 and 99.
        /// </summary>
        public void GenerateRequestId(Random random)
        {
            if (string.IsNullOrEmpty(RequestId)) // Only generate if not already set
            {
                RequestId = "REQ" + random.Next(1000, 9999).ToString(); // Example ID generation logic
            }         
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Compares two IssueDetails objects based on the RequestId for sorting or ordering issues in a collection.
        /// </summary>
        public int CompareTo(IssueDetails other)
        {
            if (other == null) return 1;
            return string.Compare(this.RequestId, other.RequestId, StringComparison.Ordinal);
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Override the ToString method to provide a readable string representation of the IssueDetails.
        /// </summary>
        public override string ToString()
        {
            return $"RequestId: {RequestId}, Location: {Location}, Category: {Category}, Description: {Description}, Attachments: {Attachments.Count}";
        }
    }
}
//---------------------------------------- END OF FILE -------------------------------------------------------//

