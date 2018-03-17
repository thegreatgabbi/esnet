namespace ex1_2
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
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 25;
            this.MovieListBox.Location = new System.Drawing.Point(64, 32);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(560, 429);
            this.MovieListBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "Retrieve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MovieListBox);
            this.Name = "Form1";
            this.Text = "List of Movies";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.Button button1;
    }
}

