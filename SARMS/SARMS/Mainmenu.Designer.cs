﻿namespace SARMS
{
    partial class MainMenu_Admin
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
            this.About_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // About_Button
            // 
            this.About_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_Button.Location = new System.Drawing.Point(951, 12);
            this.About_Button.Name = "About_Button";
            this.About_Button.Size = new System.Drawing.Size(45, 22);
            this.About_Button.TabIndex = 0;
            this.About_Button.Text = "About";
            this.About_Button.UseVisualStyleBackColor = true;
            this.About_Button.Click += new System.EventHandler(this.About_Button_Click);
            // 
            // MainMenu_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.About_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu_Admin";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SARMS Administrator";
            this.Load += new System.EventHandler(this.MainMenu_Admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button About_Button;
    }
}