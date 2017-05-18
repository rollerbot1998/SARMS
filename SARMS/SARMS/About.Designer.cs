namespace SARMS
{
    partial class About
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
            this.AboutTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AboutTextBox
            // 
            this.AboutTextBox.Location = new System.Drawing.Point(12, 14);
            this.AboutTextBox.Multiline = true;
            this.AboutTextBox.Name = "AboutTextBox";
            this.AboutTextBox.Size = new System.Drawing.Size(260, 235);
            this.AboutTextBox.TabIndex = 0;
            this.AboutTextBox.Text = "Deakin University\r\nStudent At Risk Management System\r\nSARMS " + Version.GetVersionNumber() + "\r\n\r\nAll Code (C) " +
    "2017 SIT321 \'Geelong Group 10\'\r\n-Jared Ryan\r\n-Lachlan Johnson\r\n-Tim Hinrichsen\r\n" +
    "-Matthew Joselin";
            this.AboutTextBox.TextChanged += new System.EventHandler(this.AboutTextBox_TextChanged);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AboutTextBox);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "About";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AboutTextBox;
    }
}