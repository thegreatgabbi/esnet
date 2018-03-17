namespace ex1_1
{
    partial class Form1
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
            this.VideoCodeTextBox = new System.Windows.Forms.TextBox();
            this.RentalPriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VideoCodeTextBox
            // 
            this.VideoCodeTextBox.Location = new System.Drawing.Point(224, 112);
            this.VideoCodeTextBox.Name = "VideoCodeTextBox";
            this.VideoCodeTextBox.Size = new System.Drawing.Size(336, 31);
            this.VideoCodeTextBox.TabIndex = 0;
            // 
            // RentalPriceTextBox
            // 
            this.RentalPriceTextBox.Location = new System.Drawing.Point(224, 176);
            this.RentalPriceTextBox.Name = "RentalPriceTextBox";
            this.RentalPriceTextBox.Size = new System.Drawing.Size(336, 31);
            this.RentalPriceTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Video Code: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rental Price:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 659);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RentalPriceTextBox);
            this.Controls.Add(this.VideoCodeTextBox);
            this.Name = "Form1";
            this.Text = "Change Video Rental Price";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VideoCodeTextBox;
        private System.Windows.Forms.TextBox RentalPriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

