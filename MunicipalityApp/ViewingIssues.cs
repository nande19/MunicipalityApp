using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class ViewingIssues : Form
    {
        private List<IssueDetails> issueList; // List to store the details of reported issues

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Constructor that accepts a list of issues and initializes the form
        /// </summary>
        public ViewingIssues(List<IssueDetails> issues)
        {
            InitializeComponent();
            issueList = issues;  // Assign the issue list

            // Initialize and configure the ImageList
            attachmentsImageList = new ImageList
            {
                ImageSize = new Size(50, 50),  // Set the size of the images in the ImageList for better visibility
                ColorDepth = ColorDepth.Depth24Bit
            };

            // Set up ListView with columns
            viewLstVw.View = View.Details;  // Set view to Details
            viewLstVw.FullRowSelect = true;  // Select full row when an item is clicked
            viewLstVw.SmallImageList = attachmentsImageList;  // Assign the ImageList to the ListView

            // Populate the ListView with data
            PopulateIssuesGrid();

            // Attach the MouseClick event handler
            viewLstVw.MouseClick += ViewingIssues_MouseClick;
        }

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Method to populate the ListView with issue details
        /// </summary>
        private void PopulateIssuesGrid()
        {
            viewLstVw.Items.Clear();
            attachmentsImageList.Images.Clear();

            foreach (var issue in issueList)
            {
                // Create a ListViewItem with the location as the main text
                ListViewItem item = new ListViewItem(issue.Location)
                {
                    SubItems = {
                issue.Category,
                issue.Description
            }
                };

                // Check if there are attachments
                if (issue.Attachments.Count > 0)
                {
                    string firstAttachment = issue.Attachments.First();
                    try
                    {
                        // Load the image and add it to the ImageList
                        Image image = Image.FromFile(firstAttachment);
                        string imageKey = System.IO.Path.GetFileName(firstAttachment);
                        attachmentsImageList.Images.Add(imageKey, image);

                        // Set the image key for the ListViewItem
                        item.ImageKey = imageKey; // Set the image key to show in the ListView
                        item.SubItems.Add(firstAttachment); // Add the file path in the attachments column
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image {firstAttachment}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        item.SubItems.Add("Error loading image"); // Indicate error in loading image
                    }
                }
                else
                {
                    item.SubItems.Add("No attachments");  // Indicate no attachments
                }

                viewLstVw.Items.Add(item); // Add the item to the ListView
            }

           
       
        }


        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Event handler for the back button click event
        /// </summary>
        private void backBtn_Click(object sender, EventArgs e)
        {
            // Show the Start form and close the current form
            if (Application.OpenForms.OfType<Start>().Any())
            {
                Application.OpenForms.OfType<Start>().First().Show();
            }

            this.Close(); // Close the form
        }

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Event handler for ListView item click
        /// </summary>
        private void ViewingIssues_MouseClick(object sender, MouseEventArgs e)
        {
            if (viewLstVw.SelectedItems.Count > 0)
            {
                // Get the selected item
                var selectedItem = viewLstVw.SelectedItems[0];

                // Get details from the selected item
                string location = selectedItem.Text;
                string category = selectedItem.SubItems[1].Text;
                string description = selectedItem.SubItems[2].Text;

                // Show a message box with the details and options to delete
                var result = MessageBox.Show(
                    $"Location: {location}\nCategory: {category}\nDescription: {description}\n\nDo you want to delete this issue?",
                    "Issue Details",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information
                );

                if (result == DialogResult.Yes)
                {
                    // Ask for confirmation
                    var confirmationResult = MessageBox.Show(
                        "Are you sure you want to delete this issue?",
                        "Confirm Deletion",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirmationResult == DialogResult.Yes)
                    {
                        // Remove the selected issue from the issueList
                        var issueToRemove = issueList.FirstOrDefault(i => i.Location == location && i.Category == category && i.Description == description);
                        if (issueToRemove != null)
                        {
                            issueList.Remove(issueToRemove);
                        }

                        // Refresh the ListView
                        PopulateIssuesGrid();
                    }
                }
            }
        }
    }
}
//---------------------------------------- END OF FILE -------------------------------------------------------//
