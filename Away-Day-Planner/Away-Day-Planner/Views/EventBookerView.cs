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

namespace Away_Day_Planner.Views
{
    public partial class EventBookerView : Form, IEventBookerView
    {
        private EventBookerPresenter eventBookerPresenter;

        public String pageTitle
        {
            get { return labelTitle.Text; }
            set { labelTitle.Text = value; }
        }

        public EventBookerView()
        {
            InitializeComponent();
        }

        public void register(EventBookerPresenter eventBookerPresenter)
        {
            this.eventBookerPresenter = eventBookerPresenter;
            
        }

        private void buttonAddActivity_Click(object sender, EventArgs e)
        {
            AddActivityView addActivityView = new AddActivityView();
            AddActivityPresenter addActivityPresenter = new AddActivityPresenter(addActivityView);
            addActivityView.ShowDialog();         
        }

        public void setActivityList(String[] activityListNames)
        {
            listBoxActivities.DataSource = activityListNames;
        }
    }
}
