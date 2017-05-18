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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.generateButton = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.GroupBox();
            this.percentageDisplay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.unitBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSuspended = new System.Windows.Forms.Label();
            this.labelDob = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelFname = new System.Windows.Forms.Label();
            this.textboxID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.classesDisplay = new System.Windows.Forms.Label();
            this.displayPercentage = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.report.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.generateButton);
            this.groupBox2.Controls.Add(this.report);
            this.groupBox2.Controls.Add(this.unitBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PasswordBox);
            this.groupBox2.Controls.Add(this.usernameBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(23, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 600);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "generate report";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(273, 94);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(137, 26);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(306, 34);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(82, 26);
            this.generateButton.TabIndex = 7;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // report
            // 
            this.report.Controls.Add(this.displayPercentage);
            this.report.Controls.Add(this.classesDisplay);
            this.report.Controls.Add(this.percentageDisplay);
            this.report.Controls.Add(this.label5);
            this.report.Controls.Add(this.label4);
            this.report.Location = new System.Drawing.Point(0, 126);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(429, 473);
            this.report.TabIndex = 6;
            this.report.TabStop = false;
            this.report.Text = "Report";
            // 
            // percentageDisplay
            // 
            this.percentageDisplay.AutoSize = true;
            this.percentageDisplay.Location = new System.Drawing.Point(183, 61);
            this.percentageDisplay.Name = "percentageDisplay";
            this.percentageDisplay.Size = new System.Drawing.Size(0, 13);
            this.percentageDisplay.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Classes attended";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Percentage";
            // 
            // unitBox
            // 
            this.unitBox.Location = new System.Drawing.Point(94, 94);
            this.unitBox.MaxLength = 6;
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(145, 20);
            this.unitBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unit Code";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(95, 59);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(144, 20);
            this.PasswordBox.TabIndex = 3;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(94, 31);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(146, 20);
            this.usernameBox.TabIndex = 2;
            this.usernameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSuspended);
            this.groupBox1.Controls.Add(this.labelDob);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.labelLname);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.labelFname);
            this.groupBox1.Controls.Add(this.textboxID);
            this.groupBox1.Location = new System.Drawing.Point(562, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 262);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "get user data test";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelSuspended
            // 
            this.labelSuspended.AutoSize = true;
            this.labelSuspended.Location = new System.Drawing.Point(192, 187);
            this.labelSuspended.Name = "labelSuspended";
            this.labelSuspended.Size = new System.Drawing.Size(83, 13);
            this.labelSuspended.TabIndex = 6;
            this.labelSuspended.Text = "labelSuspended";
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Location = new System.Drawing.Point(192, 165);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(49, 13);
            this.labelDob.TabIndex = 5;
            this.labelDob.Text = "labelDob";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(192, 140);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(54, 13);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "labelEmail";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Location = new System.Drawing.Point(192, 116);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(61, 13);
            this.labelLname.TabIndex = 3;
            this.labelLname.Text = "labelLname";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 34);
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
            this.labelFname.Location = new System.Drawing.Point(192, 93);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(61, 13);
            this.labelFname.TabIndex = 1;
            this.labelFname.Text = "labelFname";
            // 
            // textboxID
            // 
            this.textboxID.Location = new System.Drawing.Point(32, 33);
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
            // classesDisplay
            // 
            this.classesDisplay.AutoSize = true;
            this.classesDisplay.Location = new System.Drawing.Point(179, 94);
            this.classesDisplay.Name = "classesDisplay";
            this.classesDisplay.Size = new System.Drawing.Size(10, 13);
            this.classesDisplay.TabIndex = 3;
            this.classesDisplay.Text = "-";
            // 
            // displayPercentage
            // 
            this.displayPercentage.AutoSize = true;
            this.displayPercentage.Location = new System.Drawing.Point(181, 68);
            this.displayPercentage.Name = "displayPercentage";
            this.displayPercentage.Size = new System.Drawing.Size(10, 13);
            this.displayPercentage.TabIndex = 4;
            this.displayPercentage.Text = "-";
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.report.ResumeLayout(false);
            this.report.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.GroupBox report;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox unitBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label percentageDisplay;
        private System.Windows.Forms.Label displayPercentage;
        private System.Windows.Forms.Label classesDisplay;
    }
}