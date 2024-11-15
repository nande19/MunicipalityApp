using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class ServiceRequests : Form
    {
        private List<IssueDetails> issueList;

        public ServiceRequests(List<IssueDetails> issues)
        {
            InitializeComponent();
            issueList = issues;
            LoadIssueIds();
        }

        private void LoadIssueIds()
        {
            statusLst.Items.Clear(); // Clear previous items

            // Loop through each issue and add its details to the ListView
            foreach (var issue in issueList)
            {
                // Create a new ListViewItem with the RequestId as the text
                ListViewItem item = new ListViewItem(issue.RequestId);
                // Add the Category as a subitem
                item.SubItems.Add(issue.Category);
                // Add the Description as a subitem
                item.SubItems.Add(issue.Description);

                // Add the item to the ListView
                statusLst.Items.Add(item);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Show the Start form and close the current form
                if (Application.OpenForms.OfType<Start>().Any())
                {
                    Application.OpenForms.OfType<Start>().First().Show();
                }

                this.Close(); // Close the form
            }
            catch (Exception ex)
            {
                // Handle errors that occur when trying to close the form
                MessageBox.Show($"Error while closing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
