namespace SARMS
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.labelFname = new System.Windows.Forms.Label();
            this.textboxID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDob = new System.Windows.Forms.Label();
            this.labelSuspended = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 657);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelSuspended);
            this.tabPage1.Controls.Add(this.labelDob);
            this.tabPage1.Controls.Add(this.labelEmail);
            this.tabPage1.Controls.Add(this.labelLname);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.labelFname);
            this.tabPage1.Controls.Add(this.textboxID);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(757, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "buttonSearch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Location = new System.Drawing.Point(754, 118);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(61, 13);
            this.labelFname.TabIndex = 1;
            this.labelFname.Text = "labelFname";
            // 
            // textboxID
            // 
            this.textboxID.Location = new System.Drawing.Point(594, 58);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(123, 20);
            this.textboxID.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Location = new System.Drawing.Point(754, 141);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(61, 13);
            this.labelLname.TabIndex = 3;
            this.labelLname.Text = "labelLname";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(754, 165);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(54, 13);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "labelEmail";
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Location = new System.Drawing.Point(754, 190);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(49, 13);
            this.labelDob.TabIndex = 5;
            this.labelDob.Text = "labelDob";
            // 
            // labelSuspended
            // 
            this.labelSuspended.AutoSize = true;
            this.labelSuspended.Location = new System.Drawing.Point(754, 212);
            this.labelSuspended.Name = "labelSuspended";
            this.labelSuspended.Size = new System.Drawing.Size(83, 13);
            this.labelSuspended.TabIndex = 6;
            this.labelSuspended.Text = "labelSuspended";
            // 
            // MainMenu_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.About_Button);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu_Admin";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SARMS Administrator";
            this.Load += new System.EventHandler(this.MainMenu_Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button About_Button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.TextBox textboxID;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label labelSuspended;
    }
}