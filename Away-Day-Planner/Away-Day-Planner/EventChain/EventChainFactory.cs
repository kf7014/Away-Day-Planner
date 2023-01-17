using Away_Day_Planner.EventChain.Handlers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using Away_Day_Planner.Utilities;

namespace Away_Day_Planner.EventChain
{
    public class EventChainFactory
    {
        private readonly Dictionary<string, Exception> Errors = ErrorList.Errors;
        private PreliminaryEventHandler NewPreliminaryHandler() => Activator.CreateInstance<PreliminaryEventHandler>();
        private GeneralEventHandler NewEventHandler()           => Activator.CreateInstance<GeneralEventHandler>();
        private CancelledEventHandler NewCancelledHandler()     => Activator.CreateInstance<CancelledEventHandler>();
        private PaymentEventHandler NewPaymentHandler()         => Activator.CreateInstance<PaymentEventHandler>();
        private ArchivedEventHandler NewArchivedHandler()       => Activator.CreateInstance<ArchivedEventHandler>();

        private IEvent _Event = null;

        public IList<IHandler> Handlers = new List<IHandler>();

        public EventChainFactory(){}
        public EventChainFactory(IEvent e){
            _Event = e;
            SetSuccessors();
        }

        public void SetEvent(IEvent e) => _Event = e;
        public IEvent GetEvent() => _Event;

        private void SetSuccessors() 
        { 
            /**
             *  Preliminary
             *  General
             *  Cancelled
             *  Payment
             *  Archived
             */
        }
    }

}
