using System.Windows.Forms;
using System;
using MunicipalityIssueReporter;

namespace MunicipalityIssueReporter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Navigate to the Report Issues form (implemented in Part 1)
        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportForm = new ReportIssuesForm(); // Create instance of ReportIssuesForm
            reportForm.Show();  // Show Report Issues form
            this.Hide();  // Hide the main menu
        }

        // Navigate to the Local Events and Announcements form (to be implemented)
        private void btnLocalEvents_Click(object sender, EventArgs e)
        {
            LocalEventsForm localEventsForm = new LocalEventsForm();  // Create instance of LocalEventsForm
            localEventsForm.Show();  // Show Local Events form
            this.Hide();  // Hide the main menu
        }

        // Placeholder for future Service Request Status form
        private void btnServiceRequestStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Service Request Status feature is under development.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Code to run when the form loads, if needed
        }
    }
}

