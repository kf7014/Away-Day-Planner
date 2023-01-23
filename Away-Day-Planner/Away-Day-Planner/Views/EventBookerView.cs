/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009595
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using Away_Day_Planner.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Away_Day_Planner.Models.EventBooker;
using Away_Day_Planner.Models.ClientDepartment;

namespace Away_Day_Planner.Views
{
    public partial class EventBookerView : Form, IEventBookerView
    {
        private EventBookerPresenter eventBookerPresenter;
        private PdfDisplayPresenter PdfDisplayPresenter;

        //Getters and setters for form elements
        public String pageTitle
        {
            get { return labelTitle.Text; }
            set { labelTitle.Text = value; }
        }
        public String clientDistance
        {
            get { return labelDistanceValue.Text; }
            set { labelDistanceValue.Text = value; }
        }
        public string totalPrice
        {
            get { return labelTotalPriceValue.Text; }
            set { labelTotalPriceValue.Text = value; }
        }
        public DateTime selectedDate
        {
            get { return dateTimePickerDate.Value; }
            set { dateTimePickerDate.Value = value; }
        }
        public int noOfAttendees
        {
            get { return (int)numericUpDownNoOfAttendees.Value; }
            set {}
        }
        public string ErrorDate
        {
            get { return labelErrorDateSelected.Text; }
            set { labelErrorDateSelected.Text = value; }
        }
        public string SuccessFailMessage
        {
            get { return labelSuccess.Text; }
            set { labelSuccess.Text = value; }
        }

        public EventBookerView()
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            dateTimePickerDate.MinDate = today;
            dateTimePickerDate.MaxDate = today.AddYears(2);
        }

        public void register(EventBookerPresenter eventBookerPresenter)
        {
            this.eventBookerPresenter = eventBookerPresenter;
            
        }
        public void register(PdfDisplayPresenter pdfDisplayPresenter)
        {
            this.PdfDisplayPresenter = pdfDisplayPresenter;
        }

        private void buttonAddActivity_Click(object sender, EventArgs e)
        {
            AddActivityView addActivityView = new AddActivityView();
            EventModel eventModel = new EventModel();
            AddActivityPresenter addActivityPresenter = new AddActivityPresenter(addActivityView, eventModel);
            addActivityView.ShowDialog();
            eventBookerPresenter.buttonAddActivityEvent();
        }

        public void setActivityList(String[] activityListNames)
        {
            listBoxActivities.DataSource = activityListNames;
        }

        private void buttonConfirmBooking_Click(object sender, EventArgs e)
        {
            eventBookerPresenter.buttonConfirmBookingEvent(); 
            if(eventBookerPresenter.checkDateAvailability())
            {
                PdfDisplayView pdfDisplayView = new PdfDisplayView();
                EventModel eventModel = new EventModel();
                ClientModel clientModel = new ClientModel();
                PdfDisplayPresenter presenter = PdfDisplayPresenter.Instance(pdfDisplayView, eventModel, clientModel);
                pdfDisplayView.ShowDialog();
            }
        }
    }
}
