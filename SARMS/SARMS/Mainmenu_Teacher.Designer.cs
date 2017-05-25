namespace SARMS
{
    partial class MainMenu_Teacher
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Assnum = new System.Windows.Forms.Label();
            this.assresult = new System.Windows.Forms.Label();
            this.Assignment_number = new System.Windows.Forms.TextBox();
            this.Assignment_result = new System.Windows.Forms.TextBox();
            this.Submit_result = new System.Windows.Forms.Button();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.labal_calss_num = new System.Windows.Forms.Label();
            this.Class_number = new System.Windows.Forms.TextBox();
            this.checkBoxAttended = new System.Windows.Forms.CheckBox();
            this.Submit_attendance = new System.Windows.Forms.Button();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.Students_username = new System.Windows.Forms.TextBox();
            this.unitcodelabel = new System.Windows.Forms.Label();
            this.sun = new System.Windows.Forms.Label();
            this.Unit_code = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.teacherGenerateReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.teacherAttendance = new System.Windows.Forms.Label();
            this.teacherPerformance = new System.Windows.Forms.Label();
            this.progressBarTeacher = new System.Windows.Forms.ProgressBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelFname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelLname = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDob = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.classesDisplay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.displayPercentage = new System.Windows.Forms.Label();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.unitBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.unit_label = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // About_Button
            // 
            this.About_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About_Button.Location = new System.Drawing.Point(649, 6);
            this.About_Button.Name = "About_Button";
            this.About_Button.Size = new System.Drawing.Size(45, 22);
            this.About_Button.TabIndex = 0;
            this.About_Button.Text = "About";
            this.About_Button.UseVisualStyleBackColor = true;
            this.About_Button.Click += new System.EventHandler(this.About_Button_Click);
            // 
            // backgroundWorker1
            // 
            
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox12);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.groupBox11);
            this.tabPage2.Controls.Add(this.groupBox10);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(681, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Teacher";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.progressBar4);
            this.groupBox6.Controls.Add(this.Submit_result);
            this.groupBox6.Controls.Add(this.Assignment_result);
            this.groupBox6.Controls.Add(this.Assignment_number);
            this.groupBox6.Controls.Add(this.assresult);
            this.groupBox6.Controls.Add(this.Assnum);
            this.groupBox6.Location = new System.Drawing.Point(337, 299);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(341, 326);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Input assignment results";
            // 
            // Assnum
            // 
            this.Assnum.AutoSize = true;
            this.Assnum.Location = new System.Drawing.Point(13, 43);
            this.Assnum.Name = "Assnum";
            this.Assnum.Size = new System.Drawing.Size(99, 13);
            this.Assnum.TabIndex = 1;
            this.Assnum.Text = "Assignment number";
            // 
            // assresult
            // 
            this.assresult.AutoSize = true;
            this.assresult.Location = new System.Drawing.Point(13, 78);
            this.assresult.Name = "assresult";
            this.assresult.Size = new System.Drawing.Size(89, 13);
            this.assresult.TabIndex = 3;
            this.assresult.Text = "Assignment result";
            // 
            // Assignment_number
            // 
            this.Assignment_number.Location = new System.Drawing.Point(141, 36);
            this.Assignment_number.Name = "Assignment_number";
            this.Assignment_number.Size = new System.Drawing.Size(161, 20);
            this.Assignment_number.TabIndex = 5;
            // 
            // Assignment_result
            // 
            this.Assignment_result.Location = new System.Drawing.Point(141, 71);
            this.Assignment_result.Name = "Assignment_result";
            this.Assignment_result.Size = new System.Drawing.Size(161, 20);
            this.Assignment_result.TabIndex = 7;
            // 
            // Submit_result
            // 
            this.Submit_result.Location = new System.Drawing.Point(6, 256);
            this.Submit_result.Name = "Submit_result";
            this.Submit_result.Size = new System.Drawing.Size(326, 38);
            this.Submit_result.TabIndex = 8;
            this.Submit_result.Text = "Submit";
            this.Submit_result.UseVisualStyleBackColor = true;
            this.Submit_result.Click += new System.EventHandler(this.Submit_result_Click);
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(6, 300);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(329, 20);
            this.progressBar4.TabIndex = 10;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.progressBar3);
            this.groupBox10.Controls.Add(this.Submit_attendance);
            this.groupBox10.Controls.Add(this.checkBoxAttended);
            this.groupBox10.Controls.Add(this.Class_number);
            this.groupBox10.Controls.Add(this.labal_calss_num);
            this.groupBox10.Location = new System.Drawing.Point(337, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(338, 287);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Input class attendance";
            // 
            // labal_calss_num
            // 
            this.labal_calss_num.AutoSize = true;
            this.labal_calss_num.Location = new System.Drawing.Point(13, 36);
            this.labal_calss_num.Name = "labal_calss_num";
            this.labal_calss_num.Size = new System.Drawing.Size(70, 13);
            this.labal_calss_num.TabIndex = 0;
            this.labal_calss_num.Text = "Class number";
            // 
            // Class_number
            // 
            this.Class_number.Location = new System.Drawing.Point(141, 33);
            this.Class_number.Name = "Class_number";
            this.Class_number.Size = new System.Drawing.Size(161, 20);
            this.Class_number.TabIndex = 1;
            // 
            // checkBoxAttended
            // 
            this.checkBoxAttended.AutoSize = true;
            this.checkBoxAttended.Location = new System.Drawing.Point(124, 71);
            this.checkBoxAttended.Name = "checkBoxAttended";
            this.checkBoxAttended.Size = new System.Drawing.Size(75, 17);
            this.checkBoxAttended.TabIndex = 3;
            this.checkBoxAttended.Text = "Attended?";
            this.checkBoxAttended.UseVisualStyleBackColor = true;
            // 
            // Submit_attendance
            // 
            this.Submit_attendance.Location = new System.Drawing.Point(6, 219);
            this.Submit_attendance.Name = "Submit_attendance";
            this.Submit_attendance.Size = new System.Drawing.Size(326, 38);
            this.Submit_attendance.TabIndex = 4;
            this.Submit_attendance.Text = "Submit";
            this.Submit_attendance.UseVisualStyleBackColor = true;
            this.Submit_attendance.Click += new System.EventHandler(this.Submit_attendance_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(6, 261);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(326, 20);
            this.progressBar3.TabIndex = 9;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.Unit_code);
            this.groupBox11.Controls.Add(this.sun);
            this.groupBox11.Controls.Add(this.unitcodelabel);
            this.groupBox11.Controls.Add(this.Students_username);
            this.groupBox11.Location = new System.Drawing.Point(11, 130);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(320, 160);
            this.groupBox11.TabIndex = 7;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Student Credentials";
            // 
            // Students_username
            // 
            this.Students_username.Location = new System.Drawing.Point(131, 23);
            this.Students_username.Name = "Students_username";
            this.Students_username.Size = new System.Drawing.Size(161, 20);
            this.Students_username.TabIndex = 4;
            // 
            // unitcodelabel
            // 
            this.unitcodelabel.AutoSize = true;
            this.unitcodelabel.Location = new System.Drawing.Point(1, 68);
            this.unitcodelabel.Name = "unitcodelabel";
            this.unitcodelabel.Size = new System.Drawing.Size(53, 13);
            this.unitcodelabel.TabIndex = 2;
            this.unitcodelabel.Text = "Unit code";
            // 
            // sun
            // 
            this.sun.AutoSize = true;
            this.sun.Location = new System.Drawing.Point(1, 26);
            this.sun.Name = "sun";
            this.sun.Size = new System.Drawing.Size(100, 13);
            this.sun.TabIndex = 0;
            this.sun.Text = "Student\'s username";
            // 
            // Unit_code
            // 
            this.Unit_code.Location = new System.Drawing.Point(131, 68);
            this.Unit_code.Name = "Unit_code";
            this.Unit_code.Size = new System.Drawing.Size(161, 20);
            this.Unit_code.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 118);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Please enter student details below.\r\nOnce entered, data may be added to their acc" +
    "ounts using the controls to the right.\r\n";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.progressBarTeacher);
            this.groupBox12.Controls.Add(this.teacherPerformance);
            this.groupBox12.Controls.Add(this.teacherAttendance);
            this.groupBox12.Controls.Add(this.label10);
            this.groupBox12.Controls.Add(this.label1);
            this.groupBox12.Controls.Add(this.teacherGenerateReport);
            this.groupBox12.Location = new System.Drawing.Point(13, 299);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(317, 326);
            this.groupBox12.TabIndex = 9;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "report of student progress";
            // 
            // teacherGenerateReport
            // 
            this.teacherGenerateReport.Location = new System.Drawing.Point(6, 256);
            this.teacherGenerateReport.Name = "teacherGenerateReport";
            this.teacherGenerateReport.Size = new System.Drawing.Size(305, 38);
            this.teacherGenerateReport.TabIndex = 0;
            this.teacherGenerateReport.Text = "Generate report";
            this.teacherGenerateReport.UseVisualStyleBackColor = true;
            this.teacherGenerateReport.Click += new System.EventHandler(this.teacherGenerateReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attendance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Percentage";
            // 
            // teacherAttendance
            // 
            this.teacherAttendance.AutoSize = true;
            this.teacherAttendance.Location = new System.Drawing.Point(145, 103);
            this.teacherAttendance.Name = "teacherAttendance";
            this.teacherAttendance.Size = new System.Drawing.Size(10, 13);
            this.teacherAttendance.TabIndex = 3;
            this.teacherAttendance.Text = "-";
            // 
            // teacherPerformance
            // 
            this.teacherPerformance.AutoSize = true;
            this.teacherPerformance.Location = new System.Drawing.Point(145, 147);
            this.teacherPerformance.Name = "teacherPerformance";
            this.teacherPerformance.Size = new System.Drawing.Size(10, 13);
            this.teacherPerformance.TabIndex = 4;
            this.teacherPerformance.Text = "-";
            // 
            // progressBarTeacher
            // 
            this.progressBarTeacher.Location = new System.Drawing.Point(6, 300);
            this.progressBarTeacher.Name = "progressBarTeacher";
            this.progressBarTeacher.Size = new System.Drawing.Size(305, 20);
            this.progressBarTeacher.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(681, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Controls.Add(this.labelDob);
            this.groupBox5.Controls.Add(this.labelEmail);
            this.groupBox5.Controls.Add(this.labelLname);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.labelFname);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.labelID);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(312, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(363, 621);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Account Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "User ID:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(230, 31);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(14, 20);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "-";
            this.labelID.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "First Name:";
            // 
            // labelFname
            // 
            this.labelFname.AutoSize = true;
            this.labelFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFname.Location = new System.Drawing.Point(230, 57);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(14, 20);
            this.labelFname.TabIndex = 1;
            this.labelFname.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Date of Birth:";
            // 
            // labelLname
            // 
            this.labelLname.AutoSize = true;
            this.labelLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLname.Location = new System.Drawing.Point(230, 87);
            this.labelLname.Name = "labelLname";
            this.labelLname.Size = new System.Drawing.Size(14, 20);
            this.labelLname.TabIndex = 3;
            this.labelLname.Text = "-";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(230, 120);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(14, 20);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "-";
            // 
            // labelDob
            // 
            this.labelDob.AutoSize = true;
            this.labelDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDob.Location = new System.Drawing.Point(230, 155);
            this.labelDob.Name = "labelDob";
            this.labelDob.Size = new System.Drawing.Size(14, 20);
            this.labelDob.TabIndex = 5;
            this.labelDob.Text = "-";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.percentageLabel);
            this.groupBox4.Controls.Add(this.displayPercentage);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.classesDisplay);
            this.groupBox4.Location = new System.Drawing.Point(6, 187);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 116);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Results";
            // 
            // classesDisplay
            // 
            this.classesDisplay.AutoSize = true;
            this.classesDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classesDisplay.Location = new System.Drawing.Point(224, 77);
            this.classesDisplay.Name = "classesDisplay";
            this.classesDisplay.Size = new System.Drawing.Size(16, 24);
            this.classesDisplay.TabIndex = 14;
            this.classesDisplay.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Classes Attended:";
            // 
            // displayPercentage
            // 
            this.displayPercentage.AutoSize = true;
            this.displayPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayPercentage.Location = new System.Drawing.Point(224, 26);
            this.displayPercentage.Name = "displayPercentage";
            this.displayPercentage.Size = new System.Drawing.Size(16, 24);
            this.displayPercentage.TabIndex = 17;
            this.displayPercentage.Text = "-";
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentageLabel.Location = new System.Drawing.Point(6, 26);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(112, 24);
            this.percentageLabel.TabIndex = 15;
            this.percentageLabel.Text = "Percentage:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 118);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Welcome.\r\nTo begin, enter valid credentials via the panel below to\r\nreturn relate" +
    "d user and course information on the right.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.generate);
            this.groupBox2.Controls.Add(this.unit_label);
            this.groupBox2.Controls.Add(this.passwordLabel);
            this.groupBox2.Controls.Add(this.usernameLabel);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.generateButton);
            this.groupBox2.Controls.Add(this.unitBox);
            this.groupBox2.Controls.Add(this.PasswordBox);
            this.groupBox2.Controls.Add(this.usernameBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 498);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generate Report";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(100, 34);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(146, 20);
            this.usernameBox.TabIndex = 2;
            this.usernameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(100, 72);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(146, 20);
            this.PasswordBox.TabIndex = 3;
            // 
            // unitBox
            // 
            this.unitBox.Location = new System.Drawing.Point(100, 113);
            this.unitBox.MaxLength = 6;
            this.unitBox.Name = "unitBox";
            this.unitBox.Size = new System.Drawing.Size(146, 20);
            this.unitBox.TabIndex = 5;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(306, 34);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(82, 26);
            this.generateButton.TabIndex = 7;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 472);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(274, 20);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(24, 37);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username:";
            this.usernameLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(24, 75);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password:";
            // 
            // unit_label
            // 
            this.unit_label.AutoSize = true;
            this.unit_label.Location = new System.Drawing.Point(23, 116);
            this.unit_label.Name = "unit_label";
            this.unit_label.Size = new System.Drawing.Size(57, 13);
            this.unit_label.TabIndex = 11;
            this.unit_label.Text = "Unit Code:";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(6, 411);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(274, 55);
            this.generate.TabIndex = 13;
            this.generate.Text = "Generate Report";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(689, 657);
            this.tabControl1.TabIndex = 1;
            // 
            // MainMenu_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.About_Button);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu_Teacher";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SARMS Teacher";
            this.Load += new System.EventHandler(this.MainMenu_Admin_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button About_Button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ProgressBar progressBarTeacher;
        private System.Windows.Forms.Label teacherPerformance;
        private System.Windows.Forms.Label teacherAttendance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button teacherGenerateReport;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox Unit_code;
        private System.Windows.Forms.Label sun;
        private System.Windows.Forms.Label unitcodelabel;
        private System.Windows.Forms.TextBox Students_username;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Button Submit_attendance;
        private System.Windows.Forms.CheckBox checkBoxAttended;
        private System.Windows.Forms.TextBox Class_number;
        private System.Windows.Forms.Label labal_calss_num;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.Button Submit_result;
        private System.Windows.Forms.TextBox Assignment_result;
        private System.Windows.Forms.TextBox Assignment_number;
        private System.Windows.Forms.Label assresult;
        private System.Windows.Forms.Label Assnum;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label unit_label;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox unitBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.Label displayPercentage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label classesDisplay;
        private System.Windows.Forms.Label labelDob;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
    }
}