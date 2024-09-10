using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class ViewingIssues : Form
    {
        // Reference to the list of reported issues (passed from another form, e.g., ReportIssues form)
        private List<IssueDetails> issueList;

        public ViewingIssues(List<IssueDetails> issues)
        {
            InitializeComponent();
            issueList = issues;  // Assign the issue list

            // Set up ListView columns
            viewLstVw.Columns.Add("Location", 150);  // Adjust the width as needed
            viewLstVw.Columns.Add("Category", 120);
            viewLstVw.Columns.Add("Description", 250);
            viewLstVw.Columns.Add("Attachments", 200);

            PopulateIssuesGrid();  // Call the method to populate the grid
        }
        // Method to populate the ListView with issue details
        private void PopulateIssuesGrid()
        {
            // Clear existing items (in case of refresh)
            viewLstVw.Items.Clear();

            // Iterate over the issue list and add items to the ListView
            foreach (var issue in issueList)
            {
                // Combine the attachment paths into a single string
                string attachments = string.Join(", ", issue.Attachments);

                // Create a new ListViewItem
                ListViewItem item = new ListViewItem(issue.Location);   // First column: Location
                item.SubItems.Add(issue.Category);                      // Second column: Category
                item.SubItems.Add(issue.Description);                   // Third column: Description
                item.SubItems.Add(attachments);                         // Fourth column: Attachments

                // Add the ListViewItem to the ListView
                viewLstVw.Items.Add(item);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the current form and go back to the main menu
        }
    }
}