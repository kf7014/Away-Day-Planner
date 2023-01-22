/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009595
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using Away_Day_Planner.Models.EventBooker;
using Away_Day_Planner_Test.COR.TestObjects;
using Away_Day_Planner.CORChain;
using System;
using Moq;
using Away_Day_Planner.CORChain.Handlers;

namespace Away_Day_Planner_Test.COR
{
    [TestClass]
    public class Test_COR
    {
        public static IEvent GenerateEventXDaysInFuture(DateTime now,  int x)
        {
            DateTime StartTime = now;
            DateTime TestTime = StartTime.AddDays(x);
            TestEvent testEvent = new()
            {
                bookingDate = new Date()
            };
            testEvent.bookingDate.dateTime = TestTime;
            testEvent.price = 1;

            return testEvent;
        }

        [TestMethod]
        public void ID_01CR_Assert_Day_Checking()
        {
            int RandomDays = new Random().Next(5);
            DateTime start = DateTime.Now;
            double daysToEvent = GenerateEventXDaysInFuture(start, RandomDays).DaysTillEvent(start);

            Console.WriteLine("Expected: {0} | Got {1}", RandomDays, daysToEvent);
            Assert.AreEqual(daysToEvent, RandomDays);
        }
        [TestMethod]
        public void ID_02CR_Assert_Chain() 
        {
            Handler baseHandler = CancelledFeeChain.CreateSuccessorChain();

            Assert.AreEqual(baseHandler.GetType(), new DayHandler60().GetType());
            Assert.AreEqual(baseHandler.Successor.GetType(), new DayHandler30().GetType());
            Assert.AreEqual(baseHandler.Successor.Successor.GetType(), new DayHandler15().GetType());
        }
        [TestMethod]
        public void ID_03CR_Assert_60_Days()
        {
            int dayDiff = 61;
            DateTime StartTime = DateTime.Now;

            IEvent e = GenerateEventXDaysInFuture(StartTime, dayDiff);

            CancelledFeeChain.ProcessEvent(e);

            Assert.AreEqual(e.price, 1 * 0.2M);
            Assert.AreEqual(e.EventState, EVENT_STATE.CANCELLED);
        }
        [TestMethod]
        public void ID_04CR_Assert_30_Days()
        {
            int dayDiff = 45;
            DateTime StartTime = DateTime.Now;

            IEvent e = GenerateEventXDaysInFuture(StartTime, dayDiff);

            CancelledFeeChain.ProcessEvent(e);

            Assert.AreEqual(e.price, 1 * 0.50M);
            Assert.AreEqual(e.EventState, EVENT_STATE.CANCELLED);
        }
        [TestMethod]
        public void ID_05CR_Assert_15_Days()
        {
            int dayDiff = 17;
            DateTime StartTime = DateTime.Now;

            IEvent e = GenerateEventXDaysInFuture(StartTime, dayDiff);

            CancelledFeeChain.ProcessEvent(e);

            Assert.AreEqual(e.price, 1 * 0.75M);
            Assert.AreEqual(e.EventState, EVENT_STATE.CANCELLED);
        }
        [TestMethod]
        public void ID_06CR_Assert_Less_Than_15_Days()
        {
            int dayDiff = 7;
            DateTime StartTime = DateTime.Now;

            IEvent e = GenerateEventXDaysInFuture(StartTime, dayDiff);

            CancelledFeeChain.ProcessEvent(e);

            Assert.AreNotEqual(e.EventState, EVENT_STATE.CANCELLED);
            Assert.AreEqual(e.price, 1);
        }
    }
}
