using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class ServiceRequests : Form
    {
        private BinarySearchTree<IssueDetails> reportTree; // BST to manage service requests
        private string[] statuses = { "Processing", "Pending", "Complete" };
        private Random random = new Random();
        public ServiceRequests(List<IssueDetails> issues)
        {
            InitializeComponent();
            reportTree = new BinarySearchTree<IssueDetails>();

            // Insert issues into the BST
            foreach (var issue in issues)
            {
                issue.GenerateRequestId(random); // Generate formatted RequestId
                reportTree.Insert(issue);
            }

            LoadIssueIds();
        }

        private void LoadIssueIds()
        {
            statusLst.Items.Clear(); // Clear previous items

            // Perform an in-order traversal to fetch issues in sorted order
            List<IssueDetails> sortedIssues = new List<IssueDetails>();
            reportTree.InOrderTraversal(issue => sortedIssues.Add(issue));

            foreach (var issue in sortedIssues)
            {
                // Create a new ListViewItem with the RequestId as the text
                ListViewItem item = new ListViewItem(issue.RequestId);
                // Add the Category as a subitem
                item.SubItems.Add(issue.Category);
                // Add the Description as a subitem
                item.SubItems.Add(issue.Description);
                // Add a random status as a subitem
                string randomStatus = statuses[random.Next(statuses.Length)];
                item.SubItems.Add(randomStatus); // Request Status column

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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string searchId = searchTxt.Text.Trim(); // Input from TextBox

                // Validate input
                if (string.IsNullOrEmpty(searchId))
                {
                    MessageBox.Show("Please enter a valid Request ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                IssueDetails foundIssue = null;

                // Perform BST search
                reportTree.InOrderTraversal(issue =>
                {
                    if (issue.RequestId.Equals(searchId, StringComparison.OrdinalIgnoreCase))
                    {
                        foundIssue = issue;
                    }
                });

                // Display result in ListView
                statusLst.Items.Clear();

                if (foundIssue != null)
                {
                    ListViewItem item = new ListViewItem(foundIssue.RequestId);
                    item.SubItems.Add(foundIssue.Category);
                    item.SubItems.Add(foundIssue.Description);
                    item.SubItems.Add(statuses[random.Next(statuses.Length)]); // Random status
                    statusLst.Items.Add(item);
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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the search TextBox
                searchTxt.Clear();

                // Clear the ListView
                statusLst.Items.Clear();

                // Optionally, reload all issues from the BST to display them again
                LoadIssueIds();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the clear process
                MessageBox.Show($"An error occurred while clearing the search: {ex.Message}", "Clear Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
