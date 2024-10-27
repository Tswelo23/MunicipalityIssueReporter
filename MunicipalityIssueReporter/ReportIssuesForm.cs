using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalityIssueReporter
{
    public partial class ReportIssuesForm : Form
    {
        // Class-level variable to store the selected file path
        private string selectedFilePath = null;

        // List to store reported issues
        List<Issue> issues = new List<Issue>();

        // Constructor
        public ReportIssuesForm()
        {
            InitializeComponent();

            // Initialize ProgressBar settings
            progressBarEngagement.Minimum = 0;
            progressBarEngagement.Maximum = 100;
            progressBarEngagement.Value = 0;

            IBIEngagment.Text = "0% Complete";
        }

        // Define the Issue class to store issue details
        public class Issue
        {
            public string Location { get; set; }
            public string Category { get; set; }
            public string Description { get; set; }
            public string MediaPath { get; set; }
        }

        // Handle the Submit button click
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Ensure all required fields are filled before submitting
            if (string.IsNullOrWhiteSpace(txtLocation.Text) ||
                cmbCategory.SelectedItem == null ||
                string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please fill out all fields before submitting.");
                return; // Stop execution if fields are missing
            }

            // Check if a category is selected before accessing it
            string selectedCategory = cmbCategory.SelectedItem != null ? cmbCategory.SelectedItem.ToString() : "Unknown";

            // Create a new issue based on user input
            Issue newIssue = new Issue
            {
                Location = txtLocation.Text,
                Category = selectedCategory,
                Description = rtbDescription.Text,
                MediaPath = selectedFilePath // Attach media path if available
            };

            // Add the new issue to the list
            issues.Add(newIssue);

            // Display a confirmation message
            MessageBox.Show("Issue submitted successfully!");

            // Clear the form for new entries
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1; // Reset category selection
            rtbDescription.Clear();
            selectedFilePath = null; // Reset attached file path

            // Reset the progress bar after submission
            UpdateEngagementProgress();
        }

        // Handle the Attach Media button click
        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            // Open a dialog to select a file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save the selected file path
                selectedFilePath = openFileDialog.FileName;

                // Show a message confirming the attachment
                MessageBox.Show("File attached: " + selectedFilePath);

                // Update engagement progress after attaching media
                UpdateEngagementProgress();
            }
        }

        // Navigate back to the main menu
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            // Check if Form1 (Main Menu) is open and show it
            Form1 mainMenu = (Form1)Application.OpenForms["Form1"];
            if (mainMenu != null)
            {
                mainMenu.Show();  // Show the main menu
            }
            this.Close();  // Close the current form
        }

        // Method to update the engagement progress based on form completion
        private void UpdateEngagementProgress()
        {
            int progress = 0;

            // Check each field and update progress accordingly
            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                progress += 25; // Location filled
            }

            if (cmbCategory.SelectedItem != null)
            {
                progress += 25; // Category selected
            }

            if (!string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                progress += 25; // Description filled
            }

            if (!string.IsNullOrWhiteSpace(selectedFilePath))
            {
                progress += 25; // Media attached
            }

            // Update ProgressBar and Label with the calculated progress
            progressBarEngagement.Value = progress;
            IBIEngagment.Text = progress + "% Complete";
        }

        // Event handlers for form fields to update engagement
        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            UpdateEngagementProgress(); // Trigger progress update when location is entered
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEngagementProgress(); // Trigger progress update when category is selected
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            UpdateEngagementProgress(); // Trigger progress update when description is changed
        }

        // Remove unnecessary empty event handlers if not needed
        private void IBIEngagment_Click(object sender, EventArgs e)
        {
            // Empty handler, can be removed
        }

        private void progressBarEngagement_Click(object sender, EventArgs e)
        {
            // Empty handler, can be removed
        }

        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {
            // No specific actions needed on form load for now
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Empty handler, can be removed
        }
    }
}
