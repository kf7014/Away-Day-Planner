
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
            this.firstNameText = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.Label();
            this.staffFirstName = new System.Windows.Forms.TextBox();
            this.staffLastName = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.Label();
            this.staffEmail = new System.Windows.Forms.TextBox();
            this.staffUsername = new System.Windows.Forms.TextBox();
            this.staffPassword = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.Label();
            this.errorMessageFirstName = new System.Windows.Forms.Label();
            this.errorMessageLastName = new System.Windows.Forms.Label();
            this.errorMessagePassword = new System.Windows.Forms.Label();
            this.errorMessageEmail = new System.Windows.Forms.Label();
            this.errorMessageUsername = new System.Windows.Forms.Label();
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
            this.registerNewUserButton.Location = new System.Drawing.Point(342, 311);
            this.registerNewUserButton.Name = "registerNewUserButton";
            this.registerNewUserButton.Size = new System.Drawing.Size(126, 23);
            this.registerNewUserButton.TabIndex = 10;
            this.registerNewUserButton.Text = "Register New User";
            this.registerNewUserButton.UseVisualStyleBackColor = true;
            this.registerNewUserButton.Click += new System.EventHandler(this.registerNewUserButton_Click);
            // 
            // backRegisterButton
            // 
            this.backRegisterButton.Location = new System.Drawing.Point(12, 12);
            this.backRegisterButton.Name = "backRegisterButton";
            this.backRegisterButton.Size = new System.Drawing.Size(75, 23);
            this.backRegisterButton.TabIndex = 11;
            this.backRegisterButton.Text = "Back";
            this.backRegisterButton.UseVisualStyleBackColor = true;
            this.backRegisterButton.Click += new System.EventHandler(this.backRegisterButton_Click);
            // 
            // firstNameText
            // 
            this.firstNameText.AutoSize = true;
            this.firstNameText.Location = new System.Drawing.Point(188, 200);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(63, 13);
            this.firstNameText.TabIndex = 12;
            this.firstNameText.Text = "First Name: ";
            // 
            // lastNameText
            // 
            this.lastNameText.AutoSize = true;
            this.lastNameText.Location = new System.Drawing.Point(187, 242);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(64, 13);
            this.lastNameText.TabIndex = 13;
            this.lastNameText.Text = "Last Name: ";
            // 
            // staffFirstName
            // 
            this.staffFirstName.Location = new System.Drawing.Point(257, 197);
            this.staffFirstName.Name = "staffFirstName";
            this.staffFirstName.Size = new System.Drawing.Size(111, 20);
            this.staffFirstName.TabIndex = 14;
            // 
            // staffLastName
            // 
            this.staffLastName.Location = new System.Drawing.Point(258, 239);
            this.staffLastName.Name = "staffLastName";
            this.staffLastName.Size = new System.Drawing.Size(111, 20);
            this.staffLastName.TabIndex = 15;
            // 
            // emailText
            // 
            this.emailText.AutoSize = true;
            this.emailText.Location = new System.Drawing.Point(202, 283);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(41, 13);
            this.emailText.TabIndex = 16;
            this.emailText.Text = "E-mail: ";
            // 
            // usernameText
            // 
            this.usernameText.AutoSize = true;
            this.usernameText.Location = new System.Drawing.Point(410, 197);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(58, 13);
            this.usernameText.TabIndex = 17;
            this.usernameText.Text = "Username:";
            // 
            // staffEmail
            // 
            this.staffEmail.Location = new System.Drawing.Point(256, 280);
            this.staffEmail.Name = "staffEmail";
            this.staffEmail.Size = new System.Drawing.Size(328, 20);
            this.staffEmail.TabIndex = 18;
            // 
            // staffUsername
            // 
            this.staffUsername.Location = new System.Drawing.Point(473, 197);
            this.staffUsername.Name = "staffUsername";
            this.staffUsername.Size = new System.Drawing.Size(111, 20);
            this.staffUsername.TabIndex = 19;
            // 
            // staffPassword
            // 
            this.staffPassword.Location = new System.Drawing.Point(473, 239);
            this.staffPassword.Name = "staffPassword";
            this.staffPassword.PasswordChar = '*';
            this.staffPassword.Size = new System.Drawing.Size(111, 20);
            this.staffPassword.TabIndex = 22;
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.Location = new System.Drawing.Point(405, 242);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(56, 13);
            this.passwordText.TabIndex = 23;
            this.passwordText.Text = "Password:";
            // 
            // errorMessageFirstName
            // 
            this.errorMessageFirstName.AutoSize = true;
            this.errorMessageFirstName.ForeColor = System.Drawing.Color.Red;
            this.errorMessageFirstName.Location = new System.Drawing.Point(258, 181);
            this.errorMessageFirstName.Name = "errorMessageFirstName";
            this.errorMessageFirstName.Size = new System.Drawing.Size(0, 13);
            this.errorMessageFirstName.TabIndex = 24;
            // 
            // errorMessageLastName
            // 
            this.errorMessageLastName.AutoSize = true;
            this.errorMessageLastName.ForeColor = System.Drawing.Color.Red;
            this.errorMessageLastName.Location = new System.Drawing.Point(258, 220);
            this.errorMessageLastName.Name = "errorMessageLastName";
            this.errorMessageLastName.Size = new System.Drawing.Size(0, 13);
            this.errorMessageLastName.TabIndex = 25;
            // 
            // errorMessagePassword
            // 
            this.errorMessagePassword.AutoSize = true;
            this.errorMessagePassword.ForeColor = System.Drawing.Color.Red;
            this.errorMessagePassword.Location = new System.Drawing.Point(475, 223);
            this.errorMessagePassword.Name = "errorMessagePassword";
            this.errorMessagePassword.Size = new System.Drawing.Size(0, 13);
            this.errorMessagePassword.TabIndex = 26;
            // 
            // errorMessageEmail
            // 
            this.errorMessageEmail.AutoSize = true;
            this.errorMessageEmail.ForeColor = System.Drawing.Color.Red;
            this.errorMessageEmail.Location = new System.Drawing.Point(258, 264);
            this.errorMessageEmail.Name = "errorMessageEmail";
            this.errorMessageEmail.Size = new System.Drawing.Size(0, 13);
            this.errorMessageEmail.TabIndex = 27;
            // 
            // errorMessageUsername
            // 
            this.errorMessageUsername.AutoSize = true;
            this.errorMessageUsername.ForeColor = System.Drawing.Color.Red;
            this.errorMessageUsername.Location = new System.Drawing.Point(473, 181);
            this.errorMessageUsername.Name = "errorMessageUsername";
            this.errorMessageUsername.Size = new System.Drawing.Size(0, 13);
            this.errorMessageUsername.TabIndex = 28;
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorMessageUsername);
            this.Controls.Add(this.errorMessageEmail);
            this.Controls.Add(this.errorMessagePassword);
            this.Controls.Add(this.errorMessageLastName);
            this.Controls.Add(this.errorMessageFirstName);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.staffPassword);
            this.Controls.Add(this.staffUsername);
            this.Controls.Add(this.staffEmail);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.staffLastName);
            this.Controls.Add(this.staffFirstName);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.backRegisterButton);
            this.Controls.Add(this.registerNewUserButton);
            this.Controls.Add(this.registerHeading);
            this.Controls.Add(this.registerTitle);
            this.Name = "RegisterView";
            this.Text = "RegisterView";
            this.Load += new System.EventHandler(this.RegisterView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerHeading;
        private System.Windows.Forms.Label registerTitle;
        private System.Windows.Forms.Button registerNewUserButton;
        private System.Windows.Forms.Button backRegisterButton;
        private System.Windows.Forms.Label firstNameText;
        private System.Windows.Forms.Label lastNameText;
        private System.Windows.Forms.TextBox staffFirstName;
        private System.Windows.Forms.TextBox staffLastName;
        private System.Windows.Forms.Label emailText;
        private System.Windows.Forms.Label usernameText;
        private System.Windows.Forms.TextBox staffEmail;
        private System.Windows.Forms.TextBox staffUsername;
        private System.Windows.Forms.TextBox staffPassword;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.Label errorMessageFirstName;
        private System.Windows.Forms.Label errorMessageLastName;
        private System.Windows.Forms.Label errorMessagePassword;
        private System.Windows.Forms.Label errorMessageEmail;
        private System.Windows.Forms.Label errorMessageUsername;
    }
}