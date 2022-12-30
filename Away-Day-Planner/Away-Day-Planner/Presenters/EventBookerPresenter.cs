using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Views;
using Away_Day_Planner.Models.ClientDepartment;
using Away_Day_Planner.Models.EventBooker;

namespace Away_Day_Planner.Presenters
{
    public class EventBookerPresenter
    {
        IEventBookerView eventBookerView;
        IEventModel eventModel;

        public EventBookerPresenter(IEventBookerView eventBookerView, IEventModel eventModel)
        {
            this.eventModel = eventModel;
            this.eventBookerView = eventBookerView;
            eventBookerView.register(this);
        }

    }
}
