
namespace Away_Day_Planner.Views
{
    partial class ClientDepartmentSelectionView
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
            this.labelSelectClient = new System.Windows.Forms.Label();
            this.labelSelectDepartment = new System.Windows.Forms.Label();
            this.listBoxClient = new System.Windows.Forms.ListBox();
            this.listBoxDepartment = new System.Windows.Forms.ListBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelOrChoice = new System.Windows.Forms.Label();
            this.buttonCreateClient = new System.Windows.Forms.Button();
            this.buttonCreateDepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSelectClient
            // 
            this.labelSelectClient.AutoSize = true;
            this.labelSelectClient.Location = new System.Drawing.Point(48, 66);
            this.labelSelectClient.Name = "labelSelectClient";
            this.labelSelectClient.Size = new System.Drawing.Size(75, 13);
            this.labelSelectClient.TabIndex = 0;
            this.labelSelectClient.Text = "Select Client : ";
            // 
            // labelSelectDepartment
            // 
            this.labelSelectDepartment.AutoSize = true;
            this.labelSelectDepartment.Location = new System.Drawing.Point(245, 66);
            this.labelSelectDepartment.Name = "labelSelectDepartment";
            this.labelSelectDepartment.Size = new System.Drawing.Size(104, 13);
            this.labelSelectDepartment.TabIndex = 1;
            this.labelSelectDepartment.Text = "Select Department : ";
            // 
            // listBoxClient
            // 
            this.listBoxClient.FormattingEnabled = true;
            this.listBoxClient.Location = new System.Drawing.Point(51, 106);
            this.listBoxClient.Name = "listBoxClient";
            this.listBoxClient.Size = new System.Drawing.Size(179, 238);
            this.listBoxClient.TabIndex = 2;
            // 
            // listBoxDepartment
            // 
            this.listBoxDepartment.FormattingEnabled = true;
            this.listBoxDepartment.Location = new System.Drawing.Point(248, 106);
            this.listBoxDepartment.Name = "listBoxDepartment";
            this.listBoxDepartment.Size = new System.Drawing.Size(179, 238);
            this.listBoxDepartment.TabIndex = 3;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(327, 350);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(100, 32);
            this.buttonConfirm.TabIndex = 4;
            this.buttonConfirm.Text = "Confirm Selection";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // labelOrChoice
            // 
            this.labelOrChoice.AutoSize = true;
            this.labelOrChoice.Location = new System.Drawing.Point(482, 199);
            this.labelOrChoice.Name = "labelOrChoice";
            this.labelOrChoice.Size = new System.Drawing.Size(35, 13);
            this.labelOrChoice.TabIndex = 5;
            this.labelOrChoice.Text = "- OR -";
            // 
            // buttonCreateClient
            // 
            this.buttonCreateClient.Location = new System.Drawing.Point(597, 149);
            this.buttonCreateClient.Name = "buttonCreateClient";
            this.buttonCreateClient.Size = new System.Drawing.Size(138, 45);
            this.buttonCreateClient.TabIndex = 6;
            this.buttonCreateClient.Text = "Create New Client";
            this.buttonCreateClient.UseVisualStyleBackColor = true;
            this.buttonCreateClient.Click += new System.EventHandler(this.buttonCreateClient_Click);
            // 
            // buttonCreateDepartment
            // 
            this.buttonCreateDepartment.Location = new System.Drawing.Point(597, 226);
            this.buttonCreateDepartment.Name = "buttonCreateDepartment";
            this.buttonCreateDepartment.Size = new System.Drawing.Size(138, 45);
            this.buttonCreateDepartment.TabIndex = 7;
            this.buttonCreateDepartment.Text = "Create New Department";
            this.buttonCreateDepartment.UseVisualStyleBackColor = true;
            this.buttonCreateDepartment.Click += new System.EventHandler(this.buttonCreateDepartment_Click);
            // 
            // ClientDepartmentSelectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreateDepartment);
            this.Controls.Add(this.buttonCreateClient);
            this.Controls.Add(this.labelOrChoice);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.listBoxDepartment);
            this.Controls.Add(this.listBoxClient);
            this.Controls.Add(this.labelSelectDepartment);
            this.Controls.Add(this.labelSelectClient);
            this.Name = "ClientDepartmentSelectionView";
            this.Text = "Away Day Planner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectClient;
        private System.Windows.Forms.Label labelSelectDepartment;
        private System.Windows.Forms.ListBox listBoxClient;
        private System.Windows.Forms.ListBox listBoxDepartment;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelOrChoice;
        private System.Windows.Forms.Button buttonCreateClient;
        private System.Windows.Forms.Button buttonCreateDepartment;
    }
}