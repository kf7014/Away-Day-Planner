
namespace Away_Day_Planner.Views
{
    partial class EventBookerView
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
            this.listBoxActivities = new System.Windows.Forms.ListBox();
            this.labelRequestedActivities = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDistance = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.buttonAddActivity = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonConfirmBooking = new System.Windows.Forms.Button();
            this.labelDistanceValue = new System.Windows.Forms.Label();
            this.labelTotalPriceValue = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelNoOfAttendees = new System.Windows.Forms.Label();
            this.numericUpDownNoOfAttendees = new System.Windows.Forms.NumericUpDown();
            this.labelErrorDateSelected = new System.Windows.Forms.Label();
            this.labelSuccess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfAttendees)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxActivities
            // 
            this.listBoxActivities.FormattingEnabled = true;
            this.listBoxActivities.Location = new System.Drawing.Point(65, 78);
            this.listBoxActivities.Name = "listBoxActivities";
            this.listBoxActivities.Size = new System.Drawing.Size(255, 251);
            this.listBoxActivities.TabIndex = 0;
            // 
            // labelRequestedActivities
            // 
            this.labelRequestedActivities.AutoSize = true;
            this.labelRequestedActivities.Location = new System.Drawing.Point(62, 50);
            this.labelRequestedActivities.Name = "labelRequestedActivities";
            this.labelRequestedActivities.Size = new System.Drawing.Size(104, 13);
            this.labelRequestedActivities.TabIndex = 1;
            this.labelRequestedActivities.Text = "Requested Activities";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(510, 109);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 13);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date :";
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Location = new System.Drawing.Point(422, 180);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(124, 13);
            this.labelDistance.TabIndex = 3;
            this.labelDistance.Text = "Distance Away (Hours) : ";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(563, 106);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate.TabIndex = 4;
            // 
            // buttonAddActivity
            // 
            this.buttonAddActivity.Location = new System.Drawing.Point(65, 350);
            this.buttonAddActivity.Name = "buttonAddActivity";
            this.buttonAddActivity.Size = new System.Drawing.Size(125, 23);
            this.buttonAddActivity.TabIndex = 6;
            this.buttonAddActivity.Text = "Add New Activity";
            this.buttonAddActivity.UseVisualStyleBackColor = true;
            this.buttonAddActivity.Click += new System.EventHandler(this.buttonAddActivity_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(339, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(167, 13);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Booking Event For CLIENTNAME";
            // 
            // buttonConfirmBooking
            // 
            this.buttonConfirmBooking.Location = new System.Drawing.Point(592, 367);
            this.buttonConfirmBooking.Name = "buttonConfirmBooking";
            this.buttonConfirmBooking.Size = new System.Drawing.Size(156, 47);
            this.buttonConfirmBooking.TabIndex = 8;
            this.buttonConfirmBooking.Text = "Confirm Booking";
            this.buttonConfirmBooking.UseVisualStyleBackColor = true;
            this.buttonConfirmBooking.Click += new System.EventHandler(this.buttonConfirmBooking_Click);
            // 
            // labelDistanceValue
            // 
            this.labelDistanceValue.AutoSize = true;
            this.labelDistanceValue.Location = new System.Drawing.Point(560, 180);
            this.labelDistanceValue.Name = "labelDistanceValue";
            this.labelDistanceValue.Size = new System.Drawing.Size(0, 13);
            this.labelDistanceValue.TabIndex = 9;
            // 
            // labelTotalPriceValue
            // 
            this.labelTotalPriceValue.AutoSize = true;
            this.labelTotalPriceValue.Location = new System.Drawing.Point(560, 262);
            this.labelTotalPriceValue.Name = "labelTotalPriceValue";
            this.labelTotalPriceValue.Size = new System.Drawing.Size(13, 13);
            this.labelTotalPriceValue.TabIndex = 11;
            this.labelTotalPriceValue.Text = "0";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(422, 262);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(61, 13);
            this.labelTotalPrice.TabIndex = 10;
            this.labelTotalPrice.Text = "Total Price:";
            // 
            // labelNoOfAttendees
            // 
            this.labelNoOfAttendees.AutoSize = true;
            this.labelNoOfAttendees.Location = new System.Drawing.Point(422, 219);
            this.labelNoOfAttendees.Name = "labelNoOfAttendees";
            this.labelNoOfAttendees.Size = new System.Drawing.Size(89, 13);
            this.labelNoOfAttendees.TabIndex = 12;
            this.labelNoOfAttendees.Text = "No Of Attendees:";
            // 
            // numericUpDownNoOfAttendees
            // 
            this.numericUpDownNoOfAttendees.Location = new System.Drawing.Point(560, 217);
            this.numericUpDownNoOfAttendees.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDownNoOfAttendees.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNoOfAttendees.Name = "numericUpDownNoOfAttendees";
            this.numericUpDownNoOfAttendees.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownNoOfAttendees.TabIndex = 13;
            this.numericUpDownNoOfAttendees.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelErrorDateSelected
            // 
            this.labelErrorDateSelected.AutoSize = true;
            this.labelErrorDateSelected.ForeColor = System.Drawing.Color.Red;
            this.labelErrorDateSelected.Location = new System.Drawing.Point(510, 142);
            this.labelErrorDateSelected.Name = "labelErrorDateSelected";
            this.labelErrorDateSelected.Size = new System.Drawing.Size(0, 13);
            this.labelErrorDateSelected.TabIndex = 14;
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Location = new System.Drawing.Point(361, 367);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(0, 13);
            this.labelSuccess.TabIndex = 15;
            // 
            // EventBookerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSuccess);
            this.Controls.Add(this.labelErrorDateSelected);
            this.Controls.Add(this.numericUpDownNoOfAttendees);
            this.Controls.Add(this.labelNoOfAttendees);
            this.Controls.Add(this.labelTotalPriceValue);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelDistanceValue);
            this.Controls.Add(this.buttonConfirmBooking);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonAddActivity);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelDistance);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelRequestedActivities);
            this.Controls.Add(this.listBoxActivities);
            this.Name = "EventBookerView";
            this.Text = "Away Day Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNoOfAttendees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxActivities;
        private System.Windows.Forms.Label labelRequestedActivities;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button buttonAddActivity;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonConfirmBooking;
        private System.Windows.Forms.Label labelDistanceValue;
        private System.Windows.Forms.Label labelTotalPriceValue;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelNoOfAttendees;
        private System.Windows.Forms.NumericUpDown numericUpDownNoOfAttendees;
        private System.Windows.Forms.Label labelErrorDateSelected;
        private System.Windows.Forms.Label labelSuccess;
    }
}