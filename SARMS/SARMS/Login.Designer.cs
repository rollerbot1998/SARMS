namespace SARMS
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
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(343, 177);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(296, 20);
            this.username.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(344, 239);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(295, 20);
            this.Password.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(485, 367);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(72, 47);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Login";
            this.login_button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.login_button.UseVisualStyleBackColor = true;
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(110, 367);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(87, 47);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "exit";
            this.exit_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 466);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SARMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button exit_button;
    }
}

