
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
            this.labelCustomPriceValue = new System.Windows.Forms.Label();
            this.labelCustomPrice = new System.Windows.Forms.Label();
            this.labelErrorSelectActivity = new System.Windows.Forms.Label();
            this.labelErrorFacilitatorRequired = new System.Windows.Forms.Label();
            this.labelErrorRewardsRequired = new System.Windows.Forms.Label();
            this.labelErrorAdditions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAddActivity
            // 
            this.labelAddActivity.AutoSize = true;
            this.labelAddActivity.Location = new System.Drawing.Point(465, 42);
            this.labelAddActivity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddActivity.Name = "labelAddActivity";
            this.labelAddActivity.Size = new System.Drawing.Size(81, 17);
            this.labelAddActivity.TabIndex = 0;
            this.labelAddActivity.Text = "Add Activity";
            // 
            // labelSelectActivity
            // 
            this.labelSelectActivity.AutoSize = true;
            this.labelSelectActivity.Location = new System.Drawing.Point(229, 103);
            this.labelSelectActivity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSelectActivity.Name = "labelSelectActivity";
            this.labelSelectActivity.Size = new System.Drawing.Size(107, 17);
            this.labelSelectActivity.TabIndex = 1;
            this.labelSelectActivity.Text = "Select Activity : ";
            // 
            // comboBoxSelectActivity
            // 
            this.comboBoxSelectActivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectActivity.FormattingEnabled = true;
            this.comboBoxSelectActivity.Location = new System.Drawing.Point(99, 135);
            this.comboBoxSelectActivity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSelectActivity.Name = "comboBoxSelectActivity";
            this.comboBoxSelectActivity.Size = new System.Drawing.Size(369, 24);
            this.comboBoxSelectActivity.TabIndex = 2;
            this.comboBoxSelectActivity.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectActivity_SelectedIndexChanged);
            // 
            // checkBoxFacilitator
            // 
            this.checkBoxFacilitator.AutoSize = true;
            this.checkBoxFacilitator.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxFacilitator.Location = new System.Drawing.Point(95, 186);
            this.checkBoxFacilitator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxFacilitator.Name = "checkBoxFacilitator";
            this.checkBoxFacilitator.Size = new System.Drawing.Size(173, 21);
            this.checkBoxFacilitator.TabIndex = 4;
            this.checkBoxFacilitator.Text = "Facilitator Required? : ";
            this.checkBoxFacilitator.UseVisualStyleBackColor = true;
            // 
            // comboBoxRewardsRequired
            // 
            this.comboBoxRewardsRequired.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRewardsRequired.FormattingEnabled = true;
            this.comboBoxRewardsRequired.Location = new System.Drawing.Point(233, 225);
            this.comboBoxRewardsRequired.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxRewardsRequired.Name = "comboBoxRewardsRequired";
            this.comboBoxRewardsRequired.Size = new System.Drawing.Size(235, 24);
            this.comboBoxRewardsRequired.TabIndex = 5;
            this.comboBoxRewardsRequired.SelectedIndexChanged += new System.EventHandler(this.comboBoxRewardsRequired_SelectedIndexChanged);
            // 
            // labelRewardsRequired
            // 
            this.labelRewardsRequired.AutoSize = true;
            this.labelRewardsRequired.Location = new System.Drawing.Point(95, 230);
            this.labelRewardsRequired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRewardsRequired.Name = "labelRewardsRequired";
            this.labelRewardsRequired.Size = new System.Drawing.Size(133, 17);
            this.labelRewardsRequired.TabIndex = 6;
            this.labelRewardsRequired.Text = "Rewards Required: ";
            // 
            // labelAdditions
            // 
            this.labelAdditions.AutoSize = true;
            this.labelAdditions.Location = new System.Drawing.Point(95, 276);
            this.labelAdditions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdditions.Name = "labelAdditions";
            this.labelAdditions.Size = new System.Drawing.Size(74, 17);
            this.labelAdditions.TabIndex = 8;
            this.labelAdditions.Text = "Additions: ";
            // 
            // comboBoxAdditions
            // 
            this.comboBoxAdditions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAdditions.FormattingEnabled = true;
            this.comboBoxAdditions.Location = new System.Drawing.Point(233, 271);
            this.comboBoxAdditions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxAdditions.Name = "comboBoxAdditions";
            this.comboBoxAdditions.Size = new System.Drawing.Size(235, 24);
            this.comboBoxAdditions.TabIndex = 7;
            this.comboBoxAdditions.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdditions_SelectedIndexChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(95, 316);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(74, 17);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "Price (£) : ";
            // 
            // labelPriceValue
            // 
            this.labelPriceValue.AutoSize = true;
            this.labelPriceValue.Location = new System.Drawing.Point(229, 316);
            this.labelPriceValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPriceValue.Name = "labelPriceValue";
            this.labelPriceValue.Size = new System.Drawing.Size(16, 17);
            this.labelPriceValue.TabIndex = 10;
            this.labelPriceValue.Text = "0";
            // 
            // labelOrChoice
            // 
            this.labelOrChoice.AutoSize = true;
            this.labelOrChoice.Location = new System.Drawing.Point(483, 103);
            this.labelOrChoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOrChoice.Name = "labelOrChoice";
            this.labelOrChoice.Size = new System.Drawing.Size(45, 17);
            this.labelOrChoice.TabIndex = 11;
            this.labelOrChoice.Text = "<OR>";
            // 
            // labelCustomActivityAdditions
            // 
            this.labelCustomActivityAdditions.AutoSize = true;
            this.labelCustomActivityAdditions.Location = new System.Drawing.Point(549, 276);
            this.labelCustomActivityAdditions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomActivityAdditions.Name = "labelCustomActivityAdditions";
            this.labelCustomActivityAdditions.Size = new System.Drawing.Size(74, 17);
            this.labelCustomActivityAdditions.TabIndex = 18;
            this.labelCustomActivityAdditions.Text = "Additions: ";
            // 
            // comboBoxCustomActivityAdditions
            // 
            this.comboBoxCustomActivityAdditions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomActivityAdditions.FormattingEnabled = true;
            this.comboBoxCustomActivityAdditions.Location = new System.Drawing.Point(688, 271);
            this.comboBoxCustomActivityAdditions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCustomActivityAdditions.Name = "comboBoxCustomActivityAdditions";
            this.comboBoxCustomActivityAdditions.Size = new System.Drawing.Size(235, 24);
            this.comboBoxCustomActivityAdditions.TabIndex = 17;
            // 
            // labelCustomActivityRewardsRequired
            // 
            this.labelCustomActivityRewardsRequired.AutoSize = true;
            this.labelCustomActivityRewardsRequired.Location = new System.Drawing.Point(549, 230);
            this.labelCustomActivityRewardsRequired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomActivityRewardsRequired.Name = "labelCustomActivityRewardsRequired";
            this.labelCustomActivityRewardsRequired.Size = new System.Drawing.Size(133, 17);
            this.labelCustomActivityRewardsRequired.TabIndex = 16;
            this.labelCustomActivityRewardsRequired.Text = "Rewards Required: ";
            // 
            // comboBoxCustomActivityRewardsRequired
            // 
            this.comboBoxCustomActivityRewardsRequired.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomActivityRewardsRequired.FormattingEnabled = true;
            this.comboBoxCustomActivityRewardsRequired.Location = new System.Drawing.Point(688, 225);
            this.comboBoxCustomActivityRewardsRequired.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxCustomActivityRewardsRequired.Name = "comboBoxCustomActivityRewardsRequired";
            this.comboBoxCustomActivityRewardsRequired.Size = new System.Drawing.Size(235, 24);
            this.comboBoxCustomActivityRewardsRequired.TabIndex = 15;
            // 
            // checkBoxCustomActivityFacilitator
            // 
            this.checkBoxCustomActivityFacilitator.AutoSize = true;
            this.checkBoxCustomActivityFacilitator.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCustomActivityFacilitator.Location = new System.Drawing.Point(549, 186);
            this.checkBoxCustomActivityFacilitator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxCustomActivityFacilitator.Name = "checkBoxCustomActivityFacilitator";
            this.checkBoxCustomActivityFacilitator.Size = new System.Drawing.Size(173, 21);
            this.checkBoxCustomActivityFacilitator.TabIndex = 14;
            this.checkBoxCustomActivityFacilitator.Text = "Facilitator Required? : ";
            this.checkBoxCustomActivityFacilitator.UseVisualStyleBackColor = true;
            // 
            // labelAddCustomActivity
            // 
            this.labelAddCustomActivity.AutoSize = true;
            this.labelAddCustomActivity.Location = new System.Drawing.Point(684, 103);
            this.labelAddCustomActivity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddCustomActivity.Name = "labelAddCustomActivity";
            this.labelAddCustomActivity.Size = new System.Drawing.Size(144, 17);
            this.labelAddCustomActivity.TabIndex = 12;
            this.labelAddCustomActivity.Text = "Add Custom Activity : ";
            // 
            // labelActivityName
            // 
            this.labelActivityName.AutoSize = true;
            this.labelActivityName.Location = new System.Drawing.Point(552, 139);
            this.labelActivityName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelActivityName.Name = "labelActivityName";
            this.labelActivityName.Size = new System.Drawing.Size(101, 17);
            this.labelActivityName.TabIndex = 19;
            this.labelActivityName.Text = "Activity Name :";
            // 
            // textBoxCustomActivityName
            // 
            this.textBoxCustomActivityName.Location = new System.Drawing.Point(665, 135);
            this.textBoxCustomActivityName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCustomActivityName.Name = "textBoxCustomActivityName";
            this.textBoxCustomActivityName.Size = new System.Drawing.Size(260, 22);
            this.textBoxCustomActivityName.TabIndex = 20;
            // 
            // buttonAddActivity
            // 
            this.buttonAddActivity.Location = new System.Drawing.Point(195, 389);
            this.buttonAddActivity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddActivity.Name = "buttonAddActivity";
            this.buttonAddActivity.Size = new System.Drawing.Size(145, 48);
            this.buttonAddActivity.TabIndex = 21;
            this.buttonAddActivity.Text = "Add Activity";
            this.buttonAddActivity.UseVisualStyleBackColor = true;
            this.buttonAddActivity.Click += new System.EventHandler(this.buttonAddActivity_Click);
            // 
            // buttonAddCustomActivity
            // 
            this.buttonAddCustomActivity.Location = new System.Drawing.Point(685, 389);
            this.buttonAddCustomActivity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddCustomActivity.Name = "buttonAddCustomActivity";
            this.buttonAddCustomActivity.Size = new System.Drawing.Size(145, 48);
            this.buttonAddCustomActivity.TabIndex = 22;
            this.buttonAddCustomActivity.Text = "Add Custom Activity";
            this.buttonAddCustomActivity.UseVisualStyleBackColor = true;
            this.buttonAddCustomActivity.Click += new System.EventHandler(this.buttonAddCustomActivity_Click);
            // 
            // labelCustomPriceValue
            // 
            this.labelCustomPriceValue.AutoSize = true;
            this.labelCustomPriceValue.Location = new System.Drawing.Point(684, 316);
            this.labelCustomPriceValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomPriceValue.Name = "labelCustomPriceValue";
            this.labelCustomPriceValue.Size = new System.Drawing.Size(16, 17);
            this.labelCustomPriceValue.TabIndex = 24;
            this.labelCustomPriceValue.Text = "0";
            // 
            // labelCustomPrice
            // 
            this.labelCustomPrice.AutoSize = true;
            this.labelCustomPrice.Location = new System.Drawing.Point(549, 316);
            this.labelCustomPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomPrice.Name = "labelCustomPrice";
            this.labelCustomPrice.Size = new System.Drawing.Size(74, 17);
            this.labelCustomPrice.TabIndex = 23;
            this.labelCustomPrice.Text = "Price (£) : ";
            // 
            // labelErrorSelectActivity
            // 
            this.labelErrorSelectActivity.AutoSize = true;
            this.labelErrorSelectActivity.ForeColor = System.Drawing.Color.Red;
            this.labelErrorSelectActivity.Location = new System.Drawing.Point(136, 446);
            this.labelErrorSelectActivity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorSelectActivity.Name = "labelErrorSelectActivity";
            this.labelErrorSelectActivity.Size = new System.Drawing.Size(0, 17);
            this.labelErrorSelectActivity.TabIndex = 25;
            // 
            // labelErrorFacilitatorRequired
            // 
            this.labelErrorFacilitatorRequired.AutoSize = true;
            this.labelErrorFacilitatorRequired.ForeColor = System.Drawing.Color.Red;
            this.labelErrorFacilitatorRequired.Location = new System.Drawing.Point(136, 475);
            this.labelErrorFacilitatorRequired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorFacilitatorRequired.Name = "labelErrorFacilitatorRequired";
            this.labelErrorFacilitatorRequired.Size = new System.Drawing.Size(0, 17);
            this.labelErrorFacilitatorRequired.TabIndex = 26;
            // 
            // labelErrorRewardsRequired
            // 
            this.labelErrorRewardsRequired.AutoSize = true;
            this.labelErrorRewardsRequired.ForeColor = System.Drawing.Color.Red;
            this.labelErrorRewardsRequired.Location = new System.Drawing.Point(136, 506);
            this.labelErrorRewardsRequired.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorRewardsRequired.Name = "labelErrorRewardsRequired";
            this.labelErrorRewardsRequired.Size = new System.Drawing.Size(0, 17);
            this.labelErrorRewardsRequired.TabIndex = 27;
            // 
            // labelErrorAdditions
            // 
            this.labelErrorAdditions.AutoSize = true;
            this.labelErrorAdditions.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAdditions.Location = new System.Drawing.Point(531, 446);
            this.labelErrorAdditions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelErrorAdditions.Name = "labelErrorAdditions";
            this.labelErrorAdditions.Size = new System.Drawing.Size(0, 17);
            this.labelErrorAdditions.TabIndex = 28;
            // 
            // AddActivityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelErrorAdditions);
            this.Controls.Add(this.labelErrorRewardsRequired);
            this.Controls.Add(this.labelErrorFacilitatorRequired);
            this.Controls.Add(this.labelErrorSelectActivity);
            this.Controls.Add(this.labelCustomPriceValue);
            this.Controls.Add(this.labelCustomPrice);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddActivityView";
            this.Text = "Away Day Planner";
            this.Load += new System.EventHandler(this.AddActivityView_Load);
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
        private System.Windows.Forms.Label labelCustomPriceValue;
        private System.Windows.Forms.Label labelCustomPrice;
        private System.Windows.Forms.Label labelErrorSelectActivity;
        private System.Windows.Forms.Label labelErrorFacilitatorRequired;
        private System.Windows.Forms.Label labelErrorRewardsRequired;
        private System.Windows.Forms.Label labelErrorAdditions;
    }
}