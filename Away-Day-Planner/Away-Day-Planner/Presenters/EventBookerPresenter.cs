using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Views;
using Away_Day_Planner.Models.EventBooker;

namespace Away_Day_Planner.Presenters
{
    public class EventBookerPresenter
    {
        IEventBookerView eventBookerView;
        IClientModel clientModel;

        public EventBookerPresenter(IEventBookerView eventBookerView, IClientModel clientModel)
        {
            this.clientModel = clientModel;
            this.eventBookerView = eventBookerView;
            //eventBookerView.register(this);
        }

    }
}
