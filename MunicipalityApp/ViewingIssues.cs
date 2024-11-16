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
            try
            {
                viewLstVw.Items.Clear(); // Clear existing items
                attachmentsImageList.Images.Clear(); // Clear existing images

                foreach (var issue in issueList)
                {
                    // Create a ListViewItem with the location as the main text
                    ListViewItem item = new ListViewItem(issue.Location)
                    {
                        SubItems =
                        {
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
                            // Handle errors in loading images
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
            catch (Exception ex)
            {
                // Handle any errors that occur during population of the ListView
                MessageBox.Show($"Error populating the issues grid: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //--------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Event handler for the back button click event
        /// </summary>
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

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Event handler for ListView item click
        /// </summary>
        private void ViewingIssues_MouseClick(object sender, MouseEventArgs e)
        {
            try
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
                                issueList.Remove(issueToRemove); // Remove the issue from the list
                            }

                            // Refresh the ListView
                            PopulateIssuesGrid();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during item click processing
                MessageBox.Show($"Error processing the selected issue: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Close the current ViewingIssues form immediately
                this.Close();

                // Create an instance of the Start form (or retrieve it if already instantiated)
                Start startForm = Application.OpenForms.OfType<Start>().FirstOrDefault();

                // Create an instance of the ReportIssues form and pass the Start form reference
                if (startForm != null)
                {
                    ReportIssues reportForm = new ReportIssues(startForm); // Pass Start form
                    reportForm.ShowDialog(); // Show the ReportIssues form as a modal dialog
                }
                else
                {
                    MessageBox.Show("Start form not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the button click processing
                MessageBox.Show($"Error while navigating to Report Issues: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
//---------------------------------------- END OF FILE -------------------------------------------------------//
