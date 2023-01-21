
namespace Away_Day_Planner.Views
{
    partial class LoginView
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
            this.components = new System.ComponentModel.Container();
            this.userLogin = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.usernameTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.passwordTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.loginHeading = new System.Windows.Forms.Label();
            this.loginErrorMessageUsername = new System.Windows.Forms.Label();
            this.loginErrorMessagePassword = new System.Windows.Forms.Label();
            this.labelErrorInvalidDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userLogin
            // 
            this.userLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userLogin.Location = new System.Drawing.Point(323, 177);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(180, 20);
            this.userLogin.TabIndex = 0;
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(323, 215);
            this.userPassword.Name = "userPassword";
            this.userPassword.PasswordChar = '*';
            this.userPassword.Size = new System.Drawing.Size(180, 20);
            this.userPassword.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(251, 82);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(318, 46);
            this.title.TabIndex = 2;
            this.title.Text = "Away-Day-Planner";
            // 
            // usernameTooltip
            // 
            this.usernameTooltip.ToolTipTitle = "Type in username here";
            // 
            // passwordTooltip
            // 
            this.passwordTooltip.ToolTipTitle = "Type in password here";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(256, 180);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(61, 13);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username: ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(258, 218);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password: ";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(369, 255);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginHeading
            // 
            this.loginHeading.AutoSize = true;
            this.loginHeading.Location = new System.Drawing.Point(341, 128);
            this.loginHeading.Name = "loginHeading";
            this.loginHeading.Size = new System.Drawing.Size(124, 13);
            this.loginHeading.TabIndex = 7;
            this.loginHeading.Text = "Login to Booking System";
            // 
            // loginErrorMessageUsername
            // 
            this.loginErrorMessageUsername.AutoSize = true;
            this.loginErrorMessageUsername.ForeColor = System.Drawing.Color.Red;
            this.loginErrorMessageUsername.Location = new System.Drawing.Point(330, 161);
            this.loginErrorMessageUsername.Name = "loginErrorMessageUsername";
            this.loginErrorMessageUsername.Size = new System.Drawing.Size(0, 13);
            this.loginErrorMessageUsername.TabIndex = 25;
            // 
            // loginErrorMessagePassword
            // 
            this.loginErrorMessagePassword.AutoSize = true;
            this.loginErrorMessagePassword.ForeColor = System.Drawing.Color.Red;
            this.loginErrorMessagePassword.Location = new System.Drawing.Point(330, 199);
            this.loginErrorMessagePassword.Name = "loginErrorMessagePassword";
            this.loginErrorMessagePassword.Size = new System.Drawing.Size(0, 13);
            this.loginErrorMessagePassword.TabIndex = 26;
            // 
            // labelErrorInvalidDetails
            // 
            this.labelErrorInvalidDetails.AutoSize = true;
            this.labelErrorInvalidDetails.ForeColor = System.Drawing.Color.Red;
            this.labelErrorInvalidDetails.Location = new System.Drawing.Point(295, 347);
            this.labelErrorInvalidDetails.Name = "labelErrorInvalidDetails";
            this.labelErrorInvalidDetails.Size = new System.Drawing.Size(0, 13);
            this.labelErrorInvalidDetails.TabIndex = 27;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelErrorInvalidDetails);
            this.Controls.Add(this.loginErrorMessagePassword);
            this.Controls.Add(this.loginErrorMessageUsername);
            this.Controls.Add(this.loginHeading);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.title);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userLogin);
            this.Name = "LoginView";
            this.Text = "LoginView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userLogin;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ToolTip usernameTooltip;
        private System.Windows.Forms.ToolTip passwordTooltip;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label loginHeading;
        private System.Windows.Forms.Label loginErrorMessageUsername;
        private System.Windows.Forms.Label loginErrorMessagePassword;
        private System.Windows.Forms.Label labelErrorInvalidDetails;
    }
}