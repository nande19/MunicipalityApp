using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class ServiceRequests : Form
    {
        private BinarySearchTree<IssueDetails> reportTree; // Binary Search Tree to manage service requests
        private string[] statuses = { 
            "PROCESSING - INVESTIGATION UNDERWAY", 
            "PENDING - INVESTIGATION NOT STARTED", 
            "COMPLETE - INVESTIGATION COMPLETED" }; // Array of possible statuses for issues
        private Random random = new Random(); // Random object to generate random statuses

        //--------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Constructor that accepts a list of issues and initializes the form.
        /// </summary>
        public ServiceRequests(List<IssueDetails> issues)
        {
            InitializeComponent();
            reportTree = new BinarySearchTree<IssueDetails>(); // Initialize the Binary Search Tree

            // Insert issues into the BST and generate RequestIds
            foreach (var issue in issues)
            {
                issue.GenerateRequestId(random); // Generate formatted RequestId
                reportTree.Insert(issue); // Insert issue into the tree
            }

            LoadIssueIds(); // Load and display the issues in the ListView
        }

        //--------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Loads and displays all the issues into the ListView.
        /// </summary>
        private void LoadIssueIds()
        {
            statusLst.Items.Clear(); // Clear the ListView before adding new items

            // Perform an in-order traversal to fetch issues in sorted order
            List<IssueDetails> sortedIssues = new List<IssueDetails>();
            reportTree.InOrderTraversal(issue => sortedIssues.Add(issue)); // Get sorted issues using in-order traversal

            // Add each issue to the ListView
            foreach (var issue in sortedIssues)
            {
                ListViewItem item = new ListViewItem(issue.RequestId); // Create ListView item with RequestId
                item.SubItems.Add(issue.Category); // Add the Category as a subitem
                item.SubItems.Add(issue.Description); // Add the Description as a subitem

                // Check if the status is "COMPLETE", otherwise assign a random status
                if (!issue.Status.Contains("COMPLETE"))
                {
                    issue.Status = statuses[random.Next(statuses.Length)];
                }

                item.SubItems.Add(issue.Status); // Add the current status of the issue

                // Set the color of the status based on the value
                switch (issue.Status.Split(' ')[0])  // Get the first part of the status (e.g., "PROCESSING", "PENDING", "COMPLETE")
                {
                    case "COMPLETE":
                        item.ForeColor = System.Drawing.Color.Green; // Green for "COMPLETE"
                        break;
                    case "PENDING":
                        item.ForeColor = System.Drawing.Color.Red; // Red for "PENDING"
                        break;
                    case "PROCESSING":
                        item.ForeColor = System.Drawing.Color.Orange; // Orange for "PROCESSING"
                        break;
                    default:
                        item.ForeColor = System.Drawing.Color.Black; // Default color (black) for any other status
                        break;
                }

                statusLst.Items.Add(item); // Add the item to the ListView
            }
        }

        private void UpdateIssueStatus(string requestId)
        {
            // Find the issue by RequestId
            IssueDetails issueToUpdate = reportTree.Find(requestId);
            if (issueToUpdate != null)
            {
                // Check if the status is already COMPLETE
                if (issueToUpdate.Status.Contains("COMPLETE"))
                {
                    // If it's complete, don't change it
                    return;
                }

                // Otherwise, assign a new random status from the statuses array
                issueToUpdate.Status = statuses[random.Next(statuses.Length)];

                // Reload the ListView to reflect the new status
                LoadIssueIds();
            }
            else
            {
                MessageBox.Show("Issue not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //--------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Event handler for the back button click event.
        /// </summary>
        private void backBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Show the Start form and close the current form
                if (Application.OpenForms.OfType<Start>().Any())
                {
                    Application.OpenForms.OfType<Start>().First().Show(); // Show the Start form
                }

                this.Close(); // Close the current form
            }
            catch (Exception ex)
            {
                // Handle errors when trying to close the form
                MessageBox.Show($"Error while closing the form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //--------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Event handler for the search button click event.
        /// </summary>
        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string searchId = searchTxt.Text.Trim(); // Get the search ID from the TextBox

                // Validate input
                if (string.IsNullOrEmpty(searchId))
                {
                    MessageBox.Show("Please enter a valid Request ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit if no search ID is entered
                }

                IssueDetails foundIssue = null; // Variable to store the found issue

                // Perform BST search to find the issue by RequestId
                reportTree.InOrderTraversal(issue =>
                {
                    if (issue.RequestId.Equals(searchId, StringComparison.OrdinalIgnoreCase))
                    {
                        foundIssue = issue; // If the RequestId matches, store the issue
                    }
                });

                // Clear the ListView before showing the search result
                statusLst.Items.Clear();

                // If the issue is found, display it in the ListView
                if (foundIssue != null)
                {
                    ListViewItem item = new ListViewItem(foundIssue.RequestId); // Create ListView item with RequestId
                    item.SubItems.Add(foundIssue.Category); // Add the Category as a subitem
                    item.SubItems.Add(foundIssue.Description); // Add the Description as a subitem
                    item.SubItems.Add(statuses[random.Next(statuses.Length)]); // Add a random status
                    statusLst.Items.Add(item); // Add the item to the ListView
                }
                else
                {
                    MessageBox.Show("No results found for the given Request ID.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (NullReferenceException nullEx)
            {
                MessageBox.Show($"An error occurred while accessing the data: {nullEx.Message}", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException formatEx)
            {
                MessageBox.Show($"The input format is incorrect: {formatEx.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //--------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Event handler for the clear button click event.
        /// </summary>
        private void clearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                searchTxt.Clear(); // Clear the search TextBox
                statusLst.Items.Clear(); // Clear the ListView

                // Optionally, reload all issues from the BST to display them again
                LoadIssueIds();
            }
            catch (Exception ex)
            {
                // Handle errors during the clear process
                MessageBox.Show($"An error occurred while clearing the search: {ex.Message}", "Clear Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
//---------------------------------------- END OF FILE -------------------------------------------------------//
