using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class ReportIssues : Form
    {
        // List to store the reported issues
        private List<IssueDetails> issueList;

        // List to store attached files
        private List<string> attachments = new List<string>();

        private Start startForm;  // Reference to the Start form
        private ViewingIssues viewForm;
        private readonly ResizeHandler resizeHandler;

        //--------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Constructor that accepts the Start form reference
        /// </summary>

        public ReportIssues(Start startForm)
        {
            InitializeComponent();
            this.startForm = startForm;  // Save the Start form reference
            this.issueList = startForm.issueList; // Use the shared issueList from the Start form
            resizeHandler = new ResizeHandler();  // Initialize ResizeHandler

        }
//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// 
        /// </summary>
        private void ReportIssues_Load(object sender, EventArgs e)
        {
            // Add controls to ResizeHandler for resizing
            resizeHandler.AddControl(locationTxt);
            resizeHandler.AddControl(categoryBox);
            resizeHandler.AddControl(descriptionTxt);
            resizeHandler.AddControl(imagePicture);
            resizeHandler.AddControl(saveBtn);
            resizeHandler.AddControl(backBtn);
            resizeHandler.AddControl(attachBtn);
            resizeHandler.AddControl(progressBar);
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Back button to return to the main form
        /// </summary>

        private void backBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if startForm is not null before attempting to show it
                if (startForm != null)
                {
                    startForm.Show();  // Show the Start form when the back button is clicked
                }
                this.Close();  // Close the form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while navigating back: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        ///   Event handler for attaching files
        /// </summary>
        private void attachBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDialog = new OpenFileDialog
                {
                    Filter = "Image files | *.bmp;*.jpg;*.png",
                    FilterIndex = 1,
                    Multiselect = false // Allow only one file selection
                };

                if (openDialog.ShowDialog() == DialogResult.OK) // Correct comparison
                {
                    // Add the file path to the attachments list
                    attachments.Add(openDialog.FileName);

                    // Display the attached image in a PictureBox
                    // Ensure you have a PictureBox control named 'imagePicture'
                    imagePicture.Image = ResizeImage(Image.FromFile(openDialog.FileName), new Size(280, 95)); // Resize and set the image

                    MessageBox.Show("File has been successfully selected.", "File Attached", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateProgressBar(); // Update progress bar after attachment
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while attaching the file: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Save button event handler
        /// </summary>
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string location = locationTxt.Text;
                string category = categoryBox.SelectedItem?.ToString();
                string description = descriptionTxt.Text;

                // Get selected priority from the ComboBox, and set it to null if not selected
                string selectedPriority = priorityLevel.SelectedItem?.ToString();

                int priority = 0; // Default priority if not selected

                // Handle priority conversion
                if (!string.IsNullOrEmpty(selectedPriority))
                {
                    // You can use a mapping approach or manually handle it
                    switch (selectedPriority.ToLower())
                    {
                        case "low":
                            priority = 1; // Low priority
                            break;
                        case "medium":
                            priority = 2; // Medium priority
                            break;
                        case "high":
                            priority = 3; // High priority
                            break;
                        default:
                            MessageBox.Show("Invalid priority value. Please select a valid priority.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                }
                else
                {
                    MessageBox.Show("Please select a priority.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  // Exit if no priority is selected
                }

                // Check if required fields are filled
                if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(description))
                {
                    MessageBox.Show("Please fill in all required fields: Location, Category, and Description.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate attachment
                if (attachments.Count == 0)
                {
                    MessageBox.Show("Adding an image is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  // Exit the method if no attachment is added
                }

                // Create a new issue with the selected priority
                IssueDetails newIssue = new IssueDetails(location, category, description, attachments, priority);
                issueList.Add(newIssue);  // Add the new issue to the shared issueList

                // Sort the issue list by priority (high to low)
                issueList = issueList.OrderBy(i => i.Priority).ToList();  // Assuming lower values mean higher priority

                progressBar.Value = 100;

                MessageBox.Show("Your issue has been successfully reported!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();

                // Navigate to ViewingIssues form
                ViewingIssues viewingIssuesForm = new ViewingIssues(issueList);
                this.Hide();
                viewingIssuesForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the issue: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// This method clears all the input fields on the form.
        /// </summary>
        private void ClearForm()
        {
            locationTxt.Clear();
            categoryBox.SelectedIndex = -1;
            descriptionTxt.Clear();
            imagePicture.Image = null; // Clear the PictureBox

        }

        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Update the progress bar based on the input fields and attachments.
        /// </summary>
        private void UpdateProgressBar()
        {
            progressBar.Value = 0; // Reset progress bar

            // Increment the progress bar based on filled fields
            int filledFieldsCount = 0;

            if (!string.IsNullOrEmpty(locationTxt.Text))
            {
                filledFieldsCount++;
            }
            if (categoryBox.SelectedIndex >= 0)
            {
                filledFieldsCount++;
            }
            if (!string.IsNullOrEmpty(descriptionTxt.Text))
            {
                filledFieldsCount++;
            }
            if (attachments.Count > 0)
            {
                filledFieldsCount++;
            }

            // Calculate the progress percentage
            progressBar.Value = (filledFieldsCount * 100) / 4; // Divide by 4 for four potential fields
        }
        //--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Resizes the given image to fit within the specified size.
        /// </summary>

        private Image ResizeImage(Image image, Size size)
        {
            Bitmap resizedImage = new Bitmap(size.Width, size.Height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, size.Width, size.Height);
            }
            return resizedImage;
        }
//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// progress bar updates
        /// </summary>

        private void locationTxt_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar(); // Update the progress bar when the location text changes

        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgressBar(); // Update the progress bar when the category selection changes

        }

        private void descriptionTxt_TextChanged(object sender, EventArgs e)
        {
            UpdateProgressBar(); // Update the progress bar when the description text changes

        }

        private void imagePicture_Click(object sender, EventArgs e)
        {
            UpdateProgressBar(); // Update the progress bar when the description text changes
        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }
//--------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// viewing issues button
        /// </summary>
        private void viewBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize the ViewingIssues form if it is null
                if (viewForm == null || viewForm.IsDisposed)
                {
                    viewForm = new ViewingIssues(issueList); // Pass the issue list to the ViewingIssues form
                }

                // Show the ViewingIssues form
                viewForm.Show();
                this.Hide();  // Hide the current form to display the ViewingIssues form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while navigating to the Viewing Issues page: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}


        //---------------------------------------- END OF FILE -------------------------------------------------------//