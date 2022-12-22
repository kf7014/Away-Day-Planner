
namespace Away_Day_Planner.Views
{
    partial class AddActivityView
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
            this.labelAddActivity = new System.Windows.Forms.Label();
            this.labelSelectActivity = new System.Windows.Forms.Label();
            this.comboBoxSelectActivity = new System.Windows.Forms.ComboBox();
            this.checkBoxFacilitator = new System.Windows.Forms.CheckBox();
            this.comboBoxRewardsRequired = new System.Windows.Forms.ComboBox();
            this.labelRewardsRequired = new System.Windows.Forms.Label();
            this.labelAdditions = new System.Windows.Forms.Label();
            this.comboBoxAdditions = new System.Windows.Forms.ComboBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelPriceValue = new System.Windows.Forms.Label();
            this.labelOrChoice = new System.Windows.Forms.Label();
            this.labelCustomActivityAdditions = new System.Windows.Forms.Label();
            this.comboBoxCustomActivityAdditions = new System.Windows.Forms.ComboBox();
            this.labelCustomActivityRewardsRequired = new System.Windows.Forms.Label();
            this.comboBoxCustomActivityRewardsRequired = new System.Windows.Forms.ComboBox();
            this.checkBoxCustomActivityFacilitator = new System.Windows.Forms.CheckBox();
            this.labelAddCustomActivity = new System.Windows.Forms.Label();
            this.labelActivityName = new System.Windows.Forms.Label();
            this.textBoxCustomActivityName = new System.Windows.Forms.TextBox();
            this.buttonAddActivity = new System.Windows.Forms.Button();
            this.buttonAddCustomActivity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddActivity
            // 
            this.labelAddActivity.AutoSize = true;
            this.labelAddActivity.Location = new System.Drawing.Point(349, 34);
            this.labelAddActivity.Name = "labelAddActivity";
            this.labelAddActivity.Size = new System.Drawing.Size(63, 13);
            this.labelAddActivity.TabIndex = 0;
            this.labelAddActivity.Text = "Add Activity";
            // 
            // labelSelectActivity
            // 
            this.labelSelectActivity.AutoSize = true;
            this.labelSelectActivity.Location = new System.Drawing.Point(172, 84);
            this.labelSelectActivity.Name = "labelSelectActivity";
            this.labelSelectActivity.Size = new System.Drawing.Size(83, 13);
            this.labelSelectActivity.TabIndex = 1;
            this.labelSelectActivity.Text = "Select Activity : ";
            // 
            // comboBoxSelectActivity
            // 
            this.comboBoxSelectActivity.FormattingEnabled = true;
            this.comboBoxSelectActivity.Location = new System.Drawing.Point(74, 110);
            this.comboBoxSelectActivity.Name = "comboBoxSelectActivity";
            this.comboBoxSelectActivity.Size = new System.Drawing.Size(278, 21);
            this.comboBoxSelectActivity.TabIndex = 2;
            // 
            // checkBoxFacilitator
            // 
            this.checkBoxFacilitator.AutoSize = true;
            this.checkBoxFacilitator.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxFacilitator.Location = new System.Drawing.Point(71, 151);
            this.checkBoxFacilitator.Name = "checkBoxFacilitator";
            this.checkBoxFacilitator.Size = new System.Drawing.Size(132, 17);
            this.checkBoxFacilitator.TabIndex = 4;
            this.checkBoxFacilitator.Text = "Facilitator Required? : ";
            this.checkBoxFacilitator.UseVisualStyleBackColor = true;
            this.checkBoxFacilitator.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBoxRewardsRequired
            // 
            this.comboBoxRewardsRequired.FormattingEnabled = true;
            this.comboBoxRewardsRequired.Location = new System.Drawing.Point(175, 183);
            this.comboBoxRewardsRequired.Name = "comboBoxRewardsRequired";
            this.comboBoxRewardsRequired.Size = new System.Drawing.Size(177, 21);
            this.comboBoxRewardsRequired.TabIndex = 5;
            this.comboBoxRewardsRequired.SelectedIndexChanged += new System.EventHandler(this.comboBoxRewardsRequired_SelectedIndexChanged);
            // 
            // labelRewardsRequired
            // 
            this.labelRewardsRequired.AutoSize = true;
            this.labelRewardsRequired.Location = new System.Drawing.Point(71, 187);
            this.labelRewardsRequired.Name = "labelRewardsRequired";
            this.labelRewardsRequired.Size = new System.Drawing.Size(101, 13);
            this.labelRewardsRequired.TabIndex = 6;
            this.labelRewardsRequired.Text = "Rewards Required: ";
            // 
            // labelAdditions
            // 
            this.labelAdditions.AutoSize = true;
            this.labelAdditions.Location = new System.Drawing.Point(71, 224);
            this.labelAdditions.Name = "labelAdditions";
            this.labelAdditions.Size = new System.Drawing.Size(56, 13);
            this.labelAdditions.TabIndex = 8;
            this.labelAdditions.Text = "Additions: ";
            // 
            // comboBoxAdditions
            // 
            this.comboBoxAdditions.FormattingEnabled = true;
            this.comboBoxAdditions.Location = new System.Drawing.Point(175, 220);
            this.comboBoxAdditions.Name = "comboBoxAdditions";
            this.comboBoxAdditions.Size = new System.Drawing.Size(177, 21);
            this.comboBoxAdditions.TabIndex = 7;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(71, 257);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(55, 13);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "Price (£) : ";
            // 
            // labelPriceValue
            // 
            this.labelPriceValue.AutoSize = true;
            this.labelPriceValue.Location = new System.Drawing.Point(172, 257);
            this.labelPriceValue.Name = "labelPriceValue";
            this.labelPriceValue.Size = new System.Drawing.Size(13, 13);
            this.labelPriceValue.TabIndex = 10;
            this.labelPriceValue.Text = "0";
            // 
            // labelOrChoice
            // 
            this.labelOrChoice.AutoSize = true;
            this.labelOrChoice.Location = new System.Drawing.Point(362, 84);
            this.labelOrChoice.Name = "labelOrChoice";
            this.labelOrChoice.Size = new System.Drawing.Size(35, 13);
            this.labelOrChoice.TabIndex = 11;
            this.labelOrChoice.Text = "<OR>";
            // 
            // labelCustomActivityAdditions
            // 
            this.labelCustomActivityAdditions.AutoSize = true;
            this.labelCustomActivityAdditions.Location = new System.Drawing.Point(412, 224);
            this.labelCustomActivityAdditions.Name = "labelCustomActivityAdditions";
            this.labelCustomActivityAdditions.Size = new System.Drawing.Size(56, 13);
            this.labelCustomActivityAdditions.TabIndex = 18;
            this.labelCustomActivityAdditions.Text = "Additions: ";
            // 
            // comboBoxCustomActivityAdditions
            // 
            this.comboBoxCustomActivityAdditions.FormattingEnabled = true;
            this.comboBoxCustomActivityAdditions.Location = new System.Drawing.Point(516, 220);
            this.comboBoxCustomActivityAdditions.Name = "comboBoxCustomActivityAdditions";
            this.comboBoxCustomActivityAdditions.Size = new System.Drawing.Size(177, 21);
            this.comboBoxCustomActivityAdditions.TabIndex = 17;
            // 
            // labelCustomActivityRewardsRequired
            // 
            this.labelCustomActivityRewardsRequired.AutoSize = true;
            this.labelCustomActivityRewardsRequired.Location = new System.Drawing.Point(412, 187);
            this.labelCustomActivityRewardsRequired.Name = "labelCustomActivityRewardsRequired";
            this.labelCustomActivityRewardsRequired.Size = new System.Drawing.Size(101, 13);
            this.labelCustomActivityRewardsRequired.TabIndex = 16;
            this.labelCustomActivityRewardsRequired.Text = "Rewards Required: ";
            // 
            // comboBoxCustomActivityRewardsRequired
            // 
            this.comboBoxCustomActivityRewardsRequired.FormattingEnabled = true;
            this.comboBoxCustomActivityRewardsRequired.Location = new System.Drawing.Point(516, 183);
            this.comboBoxCustomActivityRewardsRequired.Name = "comboBoxCustomActivityRewardsRequired";
            this.comboBoxCustomActivityRewardsRequired.Size = new System.Drawing.Size(177, 21);
            this.comboBoxCustomActivityRewardsRequired.TabIndex = 15;
            // 
            // checkBoxCustomActivityFacilitator
            // 
            this.checkBoxCustomActivityFacilitator.AutoSize = true;
            this.checkBoxCustomActivityFacilitator.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCustomActivityFacilitator.Location = new System.Drawing.Point(412, 151);
            this.checkBoxCustomActivityFacilitator.Name = "checkBoxCustomActivityFacilitator";
            this.checkBoxCustomActivityFacilitator.Size = new System.Drawing.Size(132, 17);
            this.checkBoxCustomActivityFacilitator.TabIndex = 14;
            this.checkBoxCustomActivityFacilitator.Text = "Facilitator Required? : ";
            this.checkBoxCustomActivityFacilitator.UseVisualStyleBackColor = true;
            // 
            // labelAddCustomActivity
            // 
            this.labelAddCustomActivity.AutoSize = true;
            this.labelAddCustomActivity.Location = new System.Drawing.Point(513, 84);
            this.labelAddCustomActivity.Name = "labelAddCustomActivity";
            this.labelAddCustomActivity.Size = new System.Drawing.Size(110, 13);
            this.labelAddCustomActivity.TabIndex = 12;
            this.labelAddCustomActivity.Text = "Add Custom Activity : ";
            // 
            // labelActivityName
            // 
            this.labelActivityName.AutoSize = true;
            this.labelActivityName.Location = new System.Drawing.Point(414, 113);
            this.labelActivityName.Name = "labelActivityName";
            this.labelActivityName.Size = new System.Drawing.Size(78, 13);
            this.labelActivityName.TabIndex = 19;
            this.labelActivityName.Text = "Activity Name :";
            // 
            // textBoxCustomActivityName
            // 
            this.textBoxCustomActivityName.Location = new System.Drawing.Point(499, 110);
            this.textBoxCustomActivityName.Name = "textBoxCustomActivityName";
            this.textBoxCustomActivityName.Size = new System.Drawing.Size(196, 20);
            this.textBoxCustomActivityName.TabIndex = 20;
            // 
            // buttonAddActivity
            // 
            this.buttonAddActivity.Location = new System.Drawing.Point(146, 316);
            this.buttonAddActivity.Name = "buttonAddActivity";
            this.buttonAddActivity.Size = new System.Drawing.Size(109, 39);
            this.buttonAddActivity.TabIndex = 21;
            this.buttonAddActivity.Text = "Add Activity";
            this.buttonAddActivity.UseVisualStyleBackColor = true;
            this.buttonAddActivity.Click += new System.EventHandler(this.buttonAddActivity_Click);
            // 
            // buttonAddCustomActivity
            // 
            this.buttonAddCustomActivity.Location = new System.Drawing.Point(514, 316);
            this.buttonAddCustomActivity.Name = "buttonAddCustomActivity";
            this.buttonAddCustomActivity.Size = new System.Drawing.Size(109, 39);
            this.buttonAddCustomActivity.TabIndex = 22;
            this.buttonAddCustomActivity.Text = "Add Custom Activity";
            this.buttonAddCustomActivity.UseVisualStyleBackColor = true;
            this.buttonAddCustomActivity.Click += new System.EventHandler(this.buttonAddCustomActivity_Click);
            // 
            // AddActivityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddCustomActivity);
            this.Controls.Add(this.buttonAddActivity);
            this.Controls.Add(this.textBoxCustomActivityName);
            this.Controls.Add(this.labelActivityName);
            this.Controls.Add(this.labelCustomActivityAdditions);
            this.Controls.Add(this.comboBoxCustomActivityAdditions);
            this.Controls.Add(this.labelCustomActivityRewardsRequired);
            this.Controls.Add(this.comboBoxCustomActivityRewardsRequired);
            this.Controls.Add(this.checkBoxCustomActivityFacilitator);
            this.Controls.Add(this.labelAddCustomActivity);
            this.Controls.Add(this.labelOrChoice);
            this.Controls.Add(this.labelPriceValue);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelAdditions);
            this.Controls.Add(this.comboBoxAdditions);
            this.Controls.Add(this.labelRewardsRequired);
            this.Controls.Add(this.comboBoxRewardsRequired);
            this.Controls.Add(this.checkBoxFacilitator);
            this.Controls.Add(this.comboBoxSelectActivity);
            this.Controls.Add(this.labelSelectActivity);
            this.Controls.Add(this.labelAddActivity);
            this.Name = "AddActivityView";
            this.Text = "Away Day Planner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddActivity;
        private System.Windows.Forms.Label labelSelectActivity;
        private System.Windows.Forms.ComboBox comboBoxSelectActivity;
        private System.Windows.Forms.CheckBox checkBoxFacilitator;
        private System.Windows.Forms.ComboBox comboBoxRewardsRequired;
        private System.Windows.Forms.Label labelRewardsRequired;
        private System.Windows.Forms.Label labelAdditions;
        private System.Windows.Forms.ComboBox comboBoxAdditions;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelPriceValue;
        private System.Windows.Forms.Label labelOrChoice;
        private System.Windows.Forms.Label labelCustomActivityAdditions;
        private System.Windows.Forms.ComboBox comboBoxCustomActivityAdditions;
        private System.Windows.Forms.Label labelCustomActivityRewardsRequired;
        private System.Windows.Forms.ComboBox comboBoxCustomActivityRewardsRequired;
        private System.Windows.Forms.CheckBox checkBoxCustomActivityFacilitator;
        private System.Windows.Forms.Label labelAddCustomActivity;
        private System.Windows.Forms.Label labelActivityName;
        private System.Windows.Forms.TextBox textBoxCustomActivityName;
        private System.Windows.Forms.Button buttonAddActivity;
        private System.Windows.Forms.Button buttonAddCustomActivity;
    }
}