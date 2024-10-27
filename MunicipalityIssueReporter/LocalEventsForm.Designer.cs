namespace MunicipalityIssueReporter
{
    partial class LocalEventsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBackToMenu;
        private System.Windows.Forms.ComboBox cmbSortOptions;  // Add this line for the sort ComboBox

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.cmbSortOptions = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 16;
            this.listBoxEvents.Location = new System.Drawing.Point(27, 107);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(534, 196);
            this.listBoxEvents.TabIndex = 0;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(27, 27);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(178, 24);
            this.cmbCategory.TabIndex = 1;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(231, 27);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(199, 22);
            this.dtpEventDate.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(449, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 27);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.Location = new System.Drawing.Point(231, 320);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(124, 27);
            this.btnBackToMenu.TabIndex = 4;
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = true;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // cmbSortOptions
            // 
            this.cmbSortOptions.FormattingEnabled = true;
            this.cmbSortOptions.Items.AddRange(new object[] {
            "Sort by Date",
            "Sort by Category",
            "Sort by Description"});
            this.cmbSortOptions.Location = new System.Drawing.Point(27, 62);
            this.cmbSortOptions.Name = "cmbSortOptions";
            this.cmbSortOptions.Size = new System.Drawing.Size(178, 24);
            this.cmbSortOptions.TabIndex = 5;
            // 
            // LocalEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 373);
            this.Controls.Add(this.cmbSortOptions);
            this.Controls.Add(this.btnBackToMenu);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.listBoxEvents);
            this.Name = "LocalEventsForm";
            this.Text = "Local Events and Announcements";
            this.ResumeLayout(false);

        }
    }
}
