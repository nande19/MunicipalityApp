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
        public string RequestId { get; set; } // Unique identifier
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<string> Attachments { get; set; } // List of file paths for attached images/documents

        public IssueDetails(string location, string category, string description, List<string> attachments)
        {
            RequestId = Guid.NewGuid().ToString(); // Generate a unique ID
            Location = location;
            Category = category;
            Description = description;
            Attachments = attachments;
        }
        public void GenerateRequestId(Random random)
        {
            char letter = (char)('A' + random.Next(0, 26)); // Random letter A-Z
            int number = random.Next(10, 100);             // Random number 10-99
            RequestId = $"{letter}{number}";              // Format: Letter + Two Numbers
        }

        // Implementing the IComparable<IssueDetails> interface
        public int CompareTo(IssueDetails other)
        {
            if (other == null) return 1;
            return string.Compare(this.RequestId, other.RequestId, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"RequestId: {RequestId}, Location: {Location}, Category: {Category}, Description: {Description}, Attachments: {Attachments.Count}";
        }
    }
}
//---------------------------------------- END OF FILE -------------------------------------------------------//

