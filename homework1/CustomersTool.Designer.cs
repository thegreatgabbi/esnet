namespace homework1
{
    partial class CustomersTool
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
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.MemberCategoryTextBox = new System.Windows.Forms.TextBox();
            this.MemberCategoryLabel = new System.Windows.Forms.Label();
            this.LoadButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.InsertButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.FirstButton = new System.Windows.Forms.Button();
            this.SearchGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.SearchGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(112, 192);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(124, 25);
            this.CustomerIDLabel.TabIndex = 0;
            this.CustomerIDLabel.Text = "CustomerID";
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(288, 192);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(100, 31);
            this.CustomerIDTextBox.TabIndex = 1;
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(288, 240);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(368, 31);
            this.CustomerNameTextBox.TabIndex = 3;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(80, 240);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(160, 25);
            this.CustomerNameLabel.TabIndex = 2;
            this.CustomerNameLabel.Text = "CustomerName";
            // 
            // MemberCategoryTextBox
            // 
            this.MemberCategoryTextBox.Location = new System.Drawing.Point(288, 288);
            this.MemberCategoryTextBox.Name = "MemberCategoryTextBox";
            this.MemberCategoryTextBox.Size = new System.Drawing.Size(320, 31);
            this.MemberCategoryTextBox.TabIndex = 5;
            // 
            // MemberCategoryLabel
            // 
            this.MemberCategoryLabel.AutoSize = true;
            this.MemberCategoryLabel.Location = new System.Drawing.Point(64, 288);
            this.MemberCategoryLabel.Name = "MemberCategoryLabel";
            this.MemberCategoryLabel.Size = new System.Drawing.Size(177, 25);
            this.MemberCategoryLabel.TabIndex = 4;
            this.MemberCategoryLabel.Text = "MemberCategory";
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(144, 368);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(256, 80);
            this.LoadButton.TabIndex = 6;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(416, 368);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(256, 80);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.Location = new System.Drawing.Point(144, 464);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(256, 80);
            this.InsertButton.TabIndex = 8;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(416, 464);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(256, 80);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(64, 464);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(64, 80);
            this.PrevButton.TabIndex = 10;
            this.PrevButton.Text = "<";
            this.PrevButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(688, 464);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(64, 80);
            this.NextButton.TabIndex = 11;
            this.NextButton.Text = ">";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // LastButton
            // 
            this.LastButton.Location = new System.Drawing.Point(688, 368);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(64, 80);
            this.LastButton.TabIndex = 12;
            this.LastButton.Text = ">>";
            this.LastButton.UseVisualStyleBackColor = true;
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(64, 368);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(64, 80);
            this.FirstButton.TabIndex = 13;
            this.FirstButton.Text = "<<";
            this.FirstButton.UseVisualStyleBackColor = true;
            // 
            // SearchGroupBox
            // 
            this.SearchGroupBox.Controls.Add(this.SearchTextBox);
            this.SearchGroupBox.Controls.Add(this.FindButton);
            this.SearchGroupBox.Location = new System.Drawing.Point(144, 576);
            this.SearchGroupBox.Name = "SearchGroupBox";
            this.SearchGroupBox.Size = new System.Drawing.Size(528, 96);
            this.SearchGroupBox.TabIndex = 14;
            this.SearchGroupBox.TabStop = false;
            this.SearchGroupBox.Text = "Search Names";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(16, 32);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(320, 31);
            this.SearchTextBox.TabIndex = 15;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(352, 32);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(160, 48);
            this.FindButton.TabIndex = 0;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // CustomersTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 849);
            this.Controls.Add(this.SearchGroupBox);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.LastButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.MemberCategoryTextBox);
            this.Controls.Add(this.MemberCategoryLabel);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(this.CustomerIDLabel);
            this.Name = "CustomersTool";
            this.Text = "Form3";
            this.SearchGroupBox.ResumeLayout(false);
            this.SearchGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.TextBox MemberCategoryTextBox;
        private System.Windows.Forms.Label MemberCategoryLabel;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button LastButton;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.GroupBox SearchGroupBox;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button FindButton;
    }
}