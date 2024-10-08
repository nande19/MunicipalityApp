using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MunicipalityApp
{
    public partial class ReportIssues : Form
    {
        // List to store the reported issues
        private List<IssueDetails> issueList = new List<IssueDetails>();

        // List to store attached files
        private List<string> attachments = new List<string>();

        private Start startForm;  // Reference to the Start form


        //--------------------------------------------------------------------------------------------------------//
        /// <summary>
        /// Constructor that accepts the Start form reference
        /// </summary>

        public ReportIssues(Start startForm)
        {
            InitializeComponent();
            this.startForm = startForm;  // Save the Start form reference

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

                if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(category) || string.IsNullOrEmpty(description))
                {
                    MessageBox.Show("Please fill in all required fields: Location, Category, and Description.",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if all attachments exist
                foreach (var attachment in attachments)
                {
                    if (!System.IO.File.Exists(attachment))
                    {
                        MessageBox.Show($"File does not exist: {attachment}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;  // Exit the method if any file is not found
                    }
                }

              
                progressBar.Value = 0;

                progressBar.Value += 30;

                if (attachments.Count > 0)
                {
                    progressBar.Value += 30;
                }

                IssueDetails newIssue = new IssueDetails(location, category, description, attachments);
                issueList.Add(newIssue);

                progressBar.Value = 100;

                MessageBox.Show("Your issue has been successfully reported!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearForm();

                ViewingIssues viewingIssuesForm = new ViewingIssues(issueList);

                this.Hide();

                viewingIssuesForm.FormClosed += (s, args) => this.Close();

                viewingIssuesForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the issue: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            attachments.Clear();
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
        /// progress bar
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
    }
}


        //---------------------------------------- END OF FILE -------------------------------------------------------//