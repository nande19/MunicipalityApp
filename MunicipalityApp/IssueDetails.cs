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

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Constructor to initialize a new IssueDetails object with given values.
        /// </summary>
        public IssueDetails(string location, string category, string description, List<string> attachments)
        {
            RequestId = Guid.NewGuid().ToString(); // Generate a unique ID
            Location = location;
            Category = category;
            Description = description;
            Attachments = attachments;
        }

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Generates a custom RequestId using a random letter and a random number between 10 and 99.
        /// </summary>
        public void GenerateRequestId(Random random)
        {
            char letter = (char)('A' + random.Next(0, 26)); // Random letter A-Z
            int number = random.Next(10, 100);             // Random number 10-99
            RequestId = $"{letter}{number}";              // Format: Letter + Two Numbers
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

