using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Views;
using Away_Day_Planner.Models.EventBooker;

namespace Away_Day_Planner.Presenters
{
    public class pdfDisplayPresenter
    {
        private IpdfDisplayView pdfDisplayView;
        private IEventModel EventModel;

        public pdfDisplayPresenter(IpdfDisplayView pdfDisplayView, IEventModel EventModel)
        {
            this.pdfDisplayView = pdfDisplayView;
            this.EventModel = EventModel;
            pdfDisplayView.register(this);


        }
    }
}
