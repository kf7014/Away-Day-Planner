
namespace Away_Day_Planner.Views
{
    partial class CreateClientView
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.labelNoOfHoursAway = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfHoursAway = new System.Windows.Forms.NumericUpDown();
            this.checkBoxHadClientDispute = new System.Windows.Forms.CheckBox();
            this.labelErrorClientName = new System.Windows.Forms.Label();
            this.labelErrorDistance = new System.Windows.Forms.Label();
            this.labelErrorDispute = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfHoursAway)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(159, 36);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(72, 17);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Add Client";
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(16, 117);
            this.labelClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(92, 17);
            this.labelClientName.TabIndex = 1;
            this.labelClientName.Text = "Client Name :";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(117, 113);
            this.textBoxClientName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(251, 22);
            this.textBoxClientName.TabIndex = 2;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(140, 405);
            this.buttonAddClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(127, 42);
            this.buttonAddClient.TabIndex = 3;
            this.buttonAddClient.Text = "Add Client";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // labelNoOfHoursAway
            // 
            this.labelNoOfHoursAway.AutoSize = true;
            this.labelNoOfHoursAway.Location = new System.Drawing.Point(16, 199);
            this.labelNoOfHoursAway.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoOfHoursAway.Name = "labelNoOfHoursAway";
            this.labelNoOfHoursAway.Size = new System.Drawing.Size(227, 17);
            this.labelNoOfHoursAway.TabIndex = 4;
            this.labelNoOfHoursAway.Text = "Distance (Number of hours away) :";
            // 
            // numericUpDownNumberOfHoursAway
            // 
            this.numericUpDownNumberOfHoursAway.Location = new System.Drawing.Point(251, 197);
            this.numericUpDownNumberOfHoursAway.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDownNumberOfHoursAway.Name = "numericUpDownNumberOfHoursAway";
            this.numericUpDownNumberOfHoursAway.Size = new System.Drawing.Size(87, 22);
            this.numericUpDownNumberOfHoursAway.TabIndex = 5;
            // 
            // checkBoxHadClientDispute
            // 
            this.checkBoxHadClientDispute.AutoSize = true;
            this.checkBoxHadClientDispute.Location = new System.Drawing.Point(16, 272);
            this.checkBoxHadClientDispute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxHadClientDispute.Name = "checkBoxHadClientDispute";
            this.checkBoxHadClientDispute.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxHadClientDispute.Size = new System.Drawing.Size(214, 21);
            this.checkBoxHadClientDispute.TabIndex = 7;
            this.checkBoxHadClientDispute.Text = "?Have had dispute with client";
            this.checkBoxHadClientDispute.UseVisualStyleBackColor = true;
            // 
            // labelErrorClientName
            // 
            this.labelErrorClientName.AutoSize = true;
            this.labelErrorClientName.ForeColor = System.Drawing.Color.Red;
            this.labelErrorClientName.Location = new System.Drawing.Point(60, 149);
            this.labelErrorClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorClientName.Name = "labelErrorClientName";
            this.labelErrorClientName.Size = new System.Drawing.Size(0, 17);
            this.labelErrorClientName.TabIndex = 8;
            // 
            // labelErrorDistance
            // 
            this.labelErrorDistance.AutoSize = true;
            this.labelErrorDistance.ForeColor = System.Drawing.Color.Red;
            this.labelErrorDistance.Location = new System.Drawing.Point(60, 233);
            this.labelErrorDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorDistance.Name = "labelErrorDistance";
            this.labelErrorDistance.Size = new System.Drawing.Size(0, 17);
            this.labelErrorDistance.TabIndex = 9;
            // 
            // labelErrorDispute
            // 
            this.labelErrorDispute.AutoSize = true;
            this.labelErrorDispute.ForeColor = System.Drawing.Color.Red;
            this.labelErrorDispute.Location = new System.Drawing.Point(60, 309);
            this.labelErrorDispute.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorDispute.Name = "labelErrorDispute";
            this.labelErrorDispute.Size = new System.Drawing.Size(0, 17);
            this.labelErrorDispute.TabIndex = 10;
            // 
            // CreateClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 554);
            this.Controls.Add(this.labelErrorDispute);
            this.Controls.Add(this.labelErrorDistance);
            this.Controls.Add(this.labelErrorClientName);
            this.Controls.Add(this.checkBoxHadClientDispute);
            this.Controls.Add(this.numericUpDownNumberOfHoursAway);
            this.Controls.Add(this.labelNoOfHoursAway);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.labelTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateClientView";
            this.Text = "Away Day Planner";
            this.Load += new System.EventHandler(this.CreateClientView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfHoursAway)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Label labelNoOfHoursAway;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfHoursAway;
        private System.Windows.Forms.CheckBox checkBoxHadClientDispute;
        private System.Windows.Forms.Label labelErrorClientName;
        private System.Windows.Forms.Label labelErrorDistance;
        private System.Windows.Forms.Label labelErrorDispute;
    }
}