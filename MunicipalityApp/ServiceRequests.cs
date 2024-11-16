using System;
using System.Collections.Generic;
using System.Drawing;
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

            List<IssueDetails> sortedIssues = new List<IssueDetails>();
            reportTree.InOrderTraversal(issue => sortedIssues.Add(issue)); // Get sorted issues using in-order traversal

            foreach (var issue in sortedIssues)
            {
                // Update the status logically
                if (issue.Status == "PENDING - INVESTIGATION NOT STARTED")
                {
                    issue.Status = "PROCESSING - INVESTIGATION UNDERWAY"; // Move to "PROCESSING"
                }
                else if (issue.Status == "PROCESSING - INVESTIGATION UNDERWAY")
                {
                    if (random.Next(0, 3) == 0) // 1/3 chance to mark as "COMPLETE"
                    {
                        issue.Status = "COMPLETE - INVESTIGATION COMPLETED";
                    }
                }

                // Create ListView item
                ListViewItem item = new ListViewItem(issue.RequestId);
                item.SubItems.Add(issue.Category);
                item.SubItems.Add(issue.Description);
                item.SubItems.Add(issue.Status);

                // Set color based on status
                switch (issue.Status.Split(' ')[0])
                {
                    case "COMPLETE":
                        item.ForeColor = Color.Green;
                        break;
                    case "PROCESSING":
                        item.ForeColor = Color.Orange;
                        break;
                    case "PENDING":
                        item.ForeColor = Color.Red;
                        break;
                }

                statusLst.Items.Add(item);
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
                    item.SubItems.Add(foundIssue.Status); // Preserve the original status
                    statusLst.Items.Add(item); // Add the item to the ListView

                    // Set color based on status
                    switch (foundIssue.Status.Split(' ')[0])
                    {
                        case "COMPLETE":
                            item.ForeColor = Color.Green;
                            break;
                        case "PROCESSING":
                            item.ForeColor = Color.Orange;
                            break;
                        case "PENDING":
                            item.ForeColor = Color.Red;
                            break;
                    }
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