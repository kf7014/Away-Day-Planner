
namespace Away_Day_Planner.Views
{
    partial class CreateDepartmentView
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
            this.labelClientSelection = new System.Windows.Forms.Label();
            this.comboBoxClientSelection = new System.Windows.Forms.ComboBox();
            this.labelDepartmentName = new System.Windows.Forms.Label();
            this.textBoxDepartmentName = new System.Windows.Forms.TextBox();
            this.buttonAddDepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(114, 29);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(84, 13);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Add Department";
            // 
            // labelClientSelection
            // 
            this.labelClientSelection.AutoSize = true;
            this.labelClientSelection.Location = new System.Drawing.Point(21, 91);
            this.labelClientSelection.Name = "labelClientSelection";
            this.labelClientSelection.Size = new System.Drawing.Size(89, 13);
            this.labelClientSelection.TabIndex = 2;
            this.labelClientSelection.Text = "Client Selection : ";
            // 
            // comboBoxClientSelection
            // 
            this.comboBoxClientSelection.FormattingEnabled = true;
            this.comboBoxClientSelection.Location = new System.Drawing.Point(116, 88);
            this.comboBoxClientSelection.Name = "comboBoxClientSelection";
            this.comboBoxClientSelection.Size = new System.Drawing.Size(171, 21);
            this.comboBoxClientSelection.TabIndex = 3;
            // 
            // labelDepartmentName
            // 
            this.labelDepartmentName.AutoSize = true;
            this.labelDepartmentName.Location = new System.Drawing.Point(8, 145);
            this.labelDepartmentName.Name = "labelDepartmentName";
            this.labelDepartmentName.Size = new System.Drawing.Size(102, 13);
            this.labelDepartmentName.TabIndex = 4;
            this.labelDepartmentName.Text = "Department Name : ";
            // 
            // textBoxDepartmentName
            // 
            this.textBoxDepartmentName.Location = new System.Drawing.Point(116, 145);
            this.textBoxDepartmentName.Name = "textBoxDepartmentName";
            this.textBoxDepartmentName.Size = new System.Drawing.Size(171, 20);
            this.textBoxDepartmentName.TabIndex = 5;
            // 
            // buttonAddDepartment
            // 
            this.buttonAddDepartment.Location = new System.Drawing.Point(105, 337);
            this.buttonAddDepartment.Name = "buttonAddDepartment";
            this.buttonAddDepartment.Size = new System.Drawing.Size(103, 33);
            this.buttonAddDepartment.TabIndex = 6;
            this.buttonAddDepartment.Text = "Add Department";
            this.buttonAddDepartment.UseVisualStyleBackColor = true;
            // 
            // CreateDepartmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.buttonAddDepartment);
            this.Controls.Add(this.textBoxDepartmentName);
            this.Controls.Add(this.labelDepartmentName);
            this.Controls.Add(this.comboBoxClientSelection);
            this.Controls.Add(this.labelClientSelection);
            this.Controls.Add(this.labelTitle);
            this.Name = "CreateDepartmentView";
            this.Text = "Away Day Planner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelClientSelection;
        private System.Windows.Forms.ComboBox comboBoxClientSelection;
        private System.Windows.Forms.Label labelDepartmentName;
        private System.Windows.Forms.TextBox textBoxDepartmentName;
        private System.Windows.Forms.Button buttonAddDepartment;
    }
}