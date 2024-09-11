using System;
using System.Collections.Generic;
using System.Drawing;
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

            // Initialize and configure the ImageList
            attachmentsImageList = new ImageList
            {
                ImageSize = new Size(100, 100),  // Set the size of the images in the ImageList
                ColorDepth = ColorDepth.Depth24Bit
            };

            // Set up ListView with columns
            viewLstVw.View = View.Details;  // Set view to Details
            viewLstVw.Columns.Add("Issues", 800);  // Add a single column for displaying issues
            viewLstVw.Columns.Add("Attachments", 200);  // Add column for image attachments
            viewLstVw.SmallImageList = attachmentsImageList;  // Assign the ImageList to the ListView

            PopulateIssuesGrid();  // Call the method to populate the grid
        }

        // Method to populate the ListView with issue details
        private void PopulateIssuesGrid()
{
    // Clear existing items and images
    viewLstVw.Items.Clear();
    attachmentsImageList.Images.Clear();

    foreach (var issue in issueList)
    {
        string issueDetails = $"Location: {issue.Location}, " +
                              $"Category: {issue.Category}, " +
                              $"Description: {issue.Description}";

        ListViewItem item = new ListViewItem(issueDetails);

        // Add attachment details to ListView item
        if (issue.Attachments.Count > 0)
        {
            string attachmentDetails = string.Join(", ", issue.Attachments);
            item.SubItems.Add(attachmentDetails);

            foreach (string attachment in issue.Attachments)
            {
                try
                {
                    // Load image and add to ImageList
                    Image image = Image.FromFile(attachment);
                    string imageKey = System.IO.Path.GetFileName(attachment);

                    // Debugging: Verify image and key
                    MessageBox.Show($"Adding image: {attachment} with key: {imageKey}", "Attachment", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    attachmentsImageList.Images.Add(imageKey, image);

                    // Set image index in ListViewItem
                    item.ImageKey = imageKey;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image {attachment}: {ex.Message}",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

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
