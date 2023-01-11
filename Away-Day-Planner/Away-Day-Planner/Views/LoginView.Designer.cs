
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
            this.SuspendLayout();
            // 
            // userLogin
            // 
            this.userLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userLogin.Location = new System.Drawing.Point(315, 195);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(180, 20);
            this.userLogin.TabIndex = 0;
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(315, 256);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(180, 20);
            this.userPassword.TabIndex = 1;
            this.userPassword.Visible = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(251, 90);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(281, 37);
            this.title.TabIndex = 2;
            this.title.Text = "Away-Day-Planner";
            this.title.Click += new System.EventHandler(this.label1_Click);
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
            this.usernameLabel.Location = new System.Drawing.Point(248, 198);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(61, 13);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username: ";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(250, 259);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(59, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password: ";
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}