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
    internal class EventChainFactory
    {
        private readonly Dictionary<string, Exception> Errors = ErrorList.Errors;
        private BaseEventHandler NewBaseHandler()               => Activator.CreateInstance<BaseEventHandler>();
        private PreliminaryEventHandler NewPreliminaryHandler() => Activator.CreateInstance<PreliminaryEventHandler>();
        private GeneralEventHandler NewEventHandler()           => Activator.CreateInstance<GeneralEventHandler>();
        private CancelledEventHandler NewCancelledHandler()     => Activator.CreateInstance<CancelledEventHandler>();
        private PaymentEventHandler NewPaymentHandler()         => Activator.CreateInstance<PaymentEventHandler>();
        private ArchivedEventHandler NewArchivedHandler()       => Activator.CreateInstance<ArchivedEventHandler>();

        private IEvent _Event = null;
        private IHandler _Base = null;

        public IList<IHandler> Handlers { get; private set; }

        public EventChainFactory(){}
        public EventChainFactory(IEvent e){
            _Event = e;
            SetSuccessors();
        }

        public void SetEvent(IEvent e) { _Event = e; }
        public IEvent GetEvent() { return _Event; }
        public IHandler GetBase() { return _Base; }
        public IHandler GetEntry() { return GetBase(); }
        public IHandler GetStart() { return GetBase(); }

        private void SetSuccessors() 
        { 
            /*
             Layout and order of successors:

             Base ---> Prelim ---> General ---> Payment ---> Archived
               |          |           |           ^
               |          |           |           |
               -----------------------------> Cancelled            
             */

            if (_Event == null) throw Errors["Null"];

            BaseEventHandler _base = NewBaseHandler();
            PreliminaryEventHandler _prelim = NewPreliminaryHandler();
            GeneralEventHandler _general = NewEventHandler();
            CancelledEventHandler _cancel = NewCancelledHandler();
            PaymentEventHandler _pay= NewPaymentHandler();
            ArchivedEventHandler _archive= NewArchivedHandler();

            _base.SetCancelledSuccessor(_cancel);
            _prelim.SetCancelledSuccessor(_cancel);
            _general.SetCancelledSuccessor(_cancel);

            _base.SetSuccessor(_prelim);
            _prelim.SetSuccessor(_general);
            _general.SetSuccessor(_pay);
            _cancel.SetSuccessor(_pay);
            _pay.SetSuccessor(_archive);

            _base.SetEvent(_Event);
            _Base = _base;

            Handlers.Add(_base);
            Handlers.Add(_prelim);
            Handlers.Add(_general);
            Handlers.Add(_pay);
            Handlers.Add(_cancel);
            Handlers.Add(_archive);

            _Event.EventState = EVENT_STATE.BASE;
        }
    }

}
