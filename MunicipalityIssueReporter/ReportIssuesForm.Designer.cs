namespace MunicipalityIssueReporter
{
    partial class ReportIssuesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttachMedia = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tnBackToMenu = new System.Windows.Forms.Button();
            this.progressBarEngagement = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.IBIEngagment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Location:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.SystemColors.Window;
            this.txtLocation.Location = new System.Drawing.Point(103, 67);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 22);
            this.txtLocation.TabIndex = 3;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities"});
            this.cmbCategory.Location = new System.Drawing.Point(103, 131);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(121, 24);
            this.cmbCategory.TabIndex = 4;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(126, 220);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(406, 65);
            this.rtbDescription.TabIndex = 5;
            this.rtbDescription.Text = "";
            // 
            // btnAttachMedia
            // 
            this.btnAttachMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttachMedia.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnAttachMedia.Location = new System.Drawing.Point(12, 379);
            this.btnAttachMedia.Name = "btnAttachMedia";
            this.btnAttachMedia.Size = new System.Drawing.Size(121, 60);
            this.btnAttachMedia.TabIndex = 6;
            this.btnAttachMedia.Text = "Attach Media";
            this.btnAttachMedia.UseVisualStyleBackColor = true;
            this.btnAttachMedia.Click += new System.EventHandler(this.btnAttachMedia_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(397, 488);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(135, 46);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tnBackToMenu
            // 
            this.tnBackToMenu.BackColor = System.Drawing.SystemColors.Menu;
            this.tnBackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnBackToMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tnBackToMenu.Location = new System.Drawing.Point(569, 488);
            this.tnBackToMenu.Name = "tnBackToMenu";
            this.tnBackToMenu.Size = new System.Drawing.Size(194, 46);
            this.tnBackToMenu.TabIndex = 8;
            this.tnBackToMenu.Text = "Back to Main Menu";
            this.tnBackToMenu.UseVisualStyleBackColor = false;
            this.tnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // progressBarEngagement
            // 
            this.progressBarEngagement.ForeColor = System.Drawing.Color.Lime;
            this.progressBarEngagement.Location = new System.Drawing.Point(412, 70);
            this.progressBarEngagement.Name = "progressBarEngagement";
            this.progressBarEngagement.Size = new System.Drawing.Size(519, 44);
            this.progressBarEngagement.TabIndex = 9;
            this.progressBarEngagement.Click += new System.EventHandler(this.progressBarEngagement_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Click below to :";
            // 
            // IBIEngagment
            // 
            this.IBIEngagment.AutoSize = true;
            this.IBIEngagment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBIEngagment.Location = new System.Drawing.Point(659, 37);
            this.IBIEngagment.Name = "IBIEngagment";
            this.IBIEngagment.Size = new System.Drawing.Size(120, 20);
            this.IBIEngagment.TabIndex = 11;
            this.IBIEngagment.Text = "0% Complete";
            this.IBIEngagment.Click += new System.EventHandler(this.IBIEngagment_Click);
            // 
            // ReportIssuesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(958, 584);
            this.Controls.Add(this.IBIEngagment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBarEngagement);
            this.Controls.Add(this.tnBackToMenu);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAttachMedia);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReportIssuesForm";
            this.Text = "ReportIssuesForm";
            this.Load += new System.EventHandler(this.ReportIssuesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttachMedia;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button tnBackToMenu;
        private System.Windows.Forms.ProgressBar progressBarEngagement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IBIEngagment;
    }
}