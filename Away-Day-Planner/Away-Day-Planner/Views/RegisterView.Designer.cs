
namespace Away_Day_Planner.Views
{
    partial class RegisterView
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
            this.registerHeading = new System.Windows.Forms.Label();
            this.registerTitle = new System.Windows.Forms.Label();
            this.registerNewUserButton = new System.Windows.Forms.Button();
            this.backRegisterButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.staffFirstName = new System.Windows.Forms.TextBox();
            this.staffLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.staffEmail = new System.Windows.Forms.TextBox();
            this.staffUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roleDropDown = new System.Windows.Forms.ComboBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerHeading
            // 
            this.registerHeading.AutoSize = true;
            this.registerHeading.Location = new System.Drawing.Point(318, 128);
            this.registerHeading.Name = "registerHeading";
            this.registerHeading.Size = new System.Drawing.Size(187, 13);
            this.registerHeading.TabIndex = 9;
            this.registerHeading.Text = "Register New Staff to Booking System";
            // 
            // registerTitle
            // 
            this.registerTitle.AutoSize = true;
            this.registerTitle.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerTitle.Location = new System.Drawing.Point(251, 82);
            this.registerTitle.Name = "registerTitle";
            this.registerTitle.Size = new System.Drawing.Size(318, 46);
            this.registerTitle.TabIndex = 8;
            this.registerTitle.Text = "Away-Day-Planner";
            // 
            // registerNewUserButton
            // 
            this.registerNewUserButton.Location = new System.Drawing.Point(344, 316);
            this.registerNewUserButton.Name = "registerNewUserButton";
            this.registerNewUserButton.Size = new System.Drawing.Size(126, 23);
            this.registerNewUserButton.TabIndex = 10;
            this.registerNewUserButton.Text = "Register New User";
            this.registerNewUserButton.UseVisualStyleBackColor = true;
            // 
            // backRegisterButton
            // 
            this.backRegisterButton.Location = new System.Drawing.Point(12, 12);
            this.backRegisterButton.Name = "backRegisterButton";
            this.backRegisterButton.Size = new System.Drawing.Size(75, 23);
            this.backRegisterButton.TabIndex = 11;
            this.backRegisterButton.Text = "Back";
            this.backRegisterButton.UseVisualStyleBackColor = true;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(188, 180);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(63, 13);
            this.firstNameLabel.TabIndex = 12;
            this.firstNameLabel.Text = "First Name: ";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(187, 214);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(64, 13);
            this.lastNameLabel.TabIndex = 13;
            this.lastNameLabel.Text = "Last Name: ";
            // 
            // staffFirstName
            // 
            this.staffFirstName.Location = new System.Drawing.Point(257, 177);
            this.staffFirstName.Name = "staffFirstName";
            this.staffFirstName.Size = new System.Drawing.Size(111, 20);
            this.staffFirstName.TabIndex = 14;
            // 
            // staffLastName
            // 
            this.staffLastName.Location = new System.Drawing.Point(258, 211);
            this.staffLastName.Name = "staffLastName";
            this.staffLastName.Size = new System.Drawing.Size(111, 20);
            this.staffLastName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "E-mail: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Username:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // staffEmail
            // 
            this.staffEmail.Location = new System.Drawing.Point(257, 280);
            this.staffEmail.Name = "staffEmail";
            this.staffEmail.Size = new System.Drawing.Size(328, 20);
            this.staffEmail.TabIndex = 18;
            // 
            // staffUsername
            // 
            this.staffUsername.Location = new System.Drawing.Point(473, 177);
            this.staffUsername.Name = "staffUsername";
            this.staffUsername.Size = new System.Drawing.Size(111, 20);
            this.staffUsername.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Role: ";
            // 
            // roleDropDown
            // 
            this.roleDropDown.FormattingEnabled = true;
            this.roleDropDown.Items.AddRange(new object[] {
            "Staff",
            ""});
            this.roleDropDown.Location = new System.Drawing.Point(473, 211);
            this.roleDropDown.Name = "roleDropDown";
            this.roleDropDown.Size = new System.Drawing.Size(111, 21);
            this.roleDropDown.TabIndex = 21;
            this.roleDropDown.SelectedIndexChanged += new System.EventHandler(this.roleDropDown_SelectedIndexChanged);
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(258, 245);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(111, 20);
            this.userPassword.TabIndex = 22;
            this.userPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Password:";
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.roleDropDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.staffUsername);
            this.Controls.Add(this.staffEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.staffLastName);
            this.Controls.Add(this.staffFirstName);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.backRegisterButton);
            this.Controls.Add(this.registerNewUserButton);
            this.Controls.Add(this.registerHeading);
            this.Controls.Add(this.registerTitle);
            this.Name = "RegisterView";
            this.Text = "RegisterView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerHeading;
        private System.Windows.Forms.Label registerTitle;
        private System.Windows.Forms.Button registerNewUserButton;
        private System.Windows.Forms.Button backRegisterButton;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox staffFirstName;
        private System.Windows.Forms.TextBox staffLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox staffEmail;
        private System.Windows.Forms.TextBox staffUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox roleDropDown;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label label4;
    }
}