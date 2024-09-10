using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class ViewingIssues : Form
    {
        private List<IssueDetails> issueList;

        public ViewingIssues(List<IssueDetails> issues)
        {
            InitializeComponent();
            issueList = issues;  // Assign the issue list

            // Set up ListView with a single column
            viewLstVw.View = View.Details;  // Set view to Details
            viewLstVw.Columns.Add("Issues", 800);  // Add a single column for displaying issues

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
                // Combine the issue details into a single formatted string with commas and spaces
                string issueDetails = $"Location: {issue.Location}, " +
                                      $"Category: {issue.Category}, " +
                                      $"Description: {issue.Description}, " +
                                      $"Attachments: {string.Join(", ", issue.Attachments)}";

                // Create a new ListViewItem with the formatted string
                ListViewItem item = new ListViewItem(issueDetails);

                // Add the ListViewItem to the ListView
                viewLstVw.Items.Add(item);
            }
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            // Show the Start form and close the current form
            if (Application.OpenForms.OfType<Start>().Any())
            {
                Application.OpenForms.OfType<Start>().First().Show();
            }

            this.Close(); // Close the current form
        }

    }
}