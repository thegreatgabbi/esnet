namespace issuetran_screen
{
    partial class IssueTranForm
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
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.MovieTitleTextBox = new System.Windows.Forms.TextBox();
            this.VideoCodeTextBox = new System.Windows.Forms.TextBox();
            this.VideoCodeLabel = new System.Windows.Forms.Label();
            this.IssueDateLabel = new System.Windows.Forms.Label();
            this.IssueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DueDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.RemarksLabel = new System.Windows.Forms.Label();
            this.RemarksTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CustomerLookupButton = new System.Windows.Forms.Button();
            this.VideoLookupButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(80, 96);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(124, 25);
            this.CustomerIDLabel.TabIndex = 0;
            this.CustomerIDLabel.Text = "CustomerID";
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(224, 96);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(160, 31);
            this.CustomerIDTextBox.TabIndex = 1;
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(224, 144);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.ReadOnly = true;
            this.CustomerNameTextBox.Size = new System.Drawing.Size(352, 31);
            this.CustomerNameTextBox.TabIndex = 2;
            // 
            // MovieTitleTextBox
            // 
            this.MovieTitleTextBox.Location = new System.Drawing.Point(224, 256);
            this.MovieTitleTextBox.Name = "MovieTitleTextBox";
            this.MovieTitleTextBox.ReadOnly = true;
            this.MovieTitleTextBox.Size = new System.Drawing.Size(352, 31);
            this.MovieTitleTextBox.TabIndex = 5;
            // 
            // VideoCodeTextBox
            // 
            this.VideoCodeTextBox.Location = new System.Drawing.Point(224, 208);
            this.VideoCodeTextBox.Name = "VideoCodeTextBox";
            this.VideoCodeTextBox.Size = new System.Drawing.Size(160, 31);
            this.VideoCodeTextBox.TabIndex = 4;
            // 
            // VideoCodeLabel
            // 
            this.VideoCodeLabel.AutoSize = true;
            this.VideoCodeLabel.Location = new System.Drawing.Point(80, 208);
            this.VideoCodeLabel.Name = "VideoCodeLabel";
            this.VideoCodeLabel.Size = new System.Drawing.Size(124, 25);
            this.VideoCodeLabel.TabIndex = 3;
            this.VideoCodeLabel.Text = "Video Code";
            // 
            // IssueDateLabel
            // 
            this.IssueDateLabel.AutoSize = true;
            this.IssueDateLabel.Location = new System.Drawing.Point(90, 320);
            this.IssueDateLabel.Name = "IssueDateLabel";
            this.IssueDateLabel.Size = new System.Drawing.Size(114, 25);
            this.IssueDateLabel.TabIndex = 6;
            this.IssueDateLabel.Text = "Issue Date";
            // 
            // IssueDateTimePicker
            // 
            this.IssueDateTimePicker.Location = new System.Drawing.Point(224, 320);
            this.IssueDateTimePicker.Name = "IssueDateTimePicker";
            this.IssueDateTimePicker.Size = new System.Drawing.Size(416, 31);
            this.IssueDateTimePicker.TabIndex = 7;
            // 
            // DueDateTimePicker
            // 
            this.DueDateTimePicker.Location = new System.Drawing.Point(224, 368);
            this.DueDateTimePicker.Name = "DueDateTimePicker";
            this.DueDateTimePicker.Size = new System.Drawing.Size(416, 31);
            this.DueDateTimePicker.TabIndex = 9;
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.Location = new System.Drawing.Point(102, 368);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(102, 25);
            this.DueDateLabel.TabIndex = 8;
            this.DueDateLabel.Text = "Due Date";
            // 
            // RemarksLabel
            // 
            this.RemarksLabel.AutoSize = true;
            this.RemarksLabel.Location = new System.Drawing.Point(107, 448);
            this.RemarksLabel.Name = "RemarksLabel";
            this.RemarksLabel.Size = new System.Drawing.Size(97, 25);
            this.RemarksLabel.TabIndex = 10;
            this.RemarksLabel.Text = "Remarks";
            // 
            // RemarksTextBox
            // 
            this.RemarksTextBox.Location = new System.Drawing.Point(224, 432);
            this.RemarksTextBox.Multiline = true;
            this.RemarksTextBox.Name = "RemarksTextBox";
            this.RemarksTextBox.Size = new System.Drawing.Size(368, 160);
            this.RemarksTextBox.TabIndex = 11;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(224, 624);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(128, 48);
            this.SubmitButton.TabIndex = 12;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CustomerLookupButton
            // 
            this.CustomerLookupButton.Location = new System.Drawing.Point(400, 80);
            this.CustomerLookupButton.Name = "CustomerLookupButton";
            this.CustomerLookupButton.Size = new System.Drawing.Size(64, 48);
            this.CustomerLookupButton.TabIndex = 13;
            this.CustomerLookupButton.Text = "...";
            this.CustomerLookupButton.UseVisualStyleBackColor = true;
            this.CustomerLookupButton.Click += new System.EventHandler(this.CustomerLookupButton_Click);
            // 
            // VideoLookupButton
            // 
            this.VideoLookupButton.Location = new System.Drawing.Point(400, 192);
            this.VideoLookupButton.Name = "VideoLookupButton";
            this.VideoLookupButton.Size = new System.Drawing.Size(64, 48);
            this.VideoLookupButton.TabIndex = 14;
            this.VideoLookupButton.Text = "...";
            this.VideoLookupButton.UseVisualStyleBackColor = true;
            this.VideoLookupButton.Click += new System.EventHandler(this.VideoLookupButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 750);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(874, 37);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(238, 32);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // IssueTranForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 787);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.VideoLookupButton);
            this.Controls.Add(this.CustomerLookupButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.RemarksTextBox);
            this.Controls.Add(this.RemarksLabel);
            this.Controls.Add(this.DueDateTimePicker);
            this.Controls.Add(this.DueDateLabel);
            this.Controls.Add(this.IssueDateTimePicker);
            this.Controls.Add(this.IssueDateLabel);
            this.Controls.Add(this.MovieTitleTextBox);
            this.Controls.Add(this.VideoCodeTextBox);
            this.Controls.Add(this.VideoCodeLabel);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(this.CustomerIDLabel);
            this.Name = "IssueTranForm";
            this.Text = "Issue Transaction";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.TextBox MovieTitleTextBox;
        private System.Windows.Forms.TextBox VideoCodeTextBox;
        private System.Windows.Forms.Label VideoCodeLabel;
        private System.Windows.Forms.Label IssueDateLabel;
        private System.Windows.Forms.DateTimePicker IssueDateTimePicker;
        private System.Windows.Forms.DateTimePicker DueDateTimePicker;
        private System.Windows.Forms.Label DueDateLabel;
        private System.Windows.Forms.Label RemarksLabel;
        private System.Windows.Forms.TextBox RemarksTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CustomerLookupButton;
        private System.Windows.Forms.Button VideoLookupButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

