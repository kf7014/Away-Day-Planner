using Away_Day_Planner.Models.EventBooker;
using Away_Day_Planner_Test.COR.TestObjects;
using Away_Day_Planner.CORChain;
using System;

namespace Away_Day_Planner_Test.COR
{
    [TestClass]
    public class Test_COR
    {

        [TestMethod]
        public void ID_01CR_Assert_Day_Checking()
        {
            int RandomDays = new Random().Next(5);
            DateTime StartTime = DateTime.Now;
            DateTime TestTime = StartTime.AddDays(RandomDays);

            TestEvent testEvent = new()
            {
                bookingDate = new Date()
            };
            testEvent.bookingDate.dateTime = TestTime;

            double daysToEvent = testEvent.DaysTillEvent(StartTime);

            Console.WriteLine("Expected: {0} | Got {1}", RandomDays, daysToEvent);
            Assert.AreEqual(daysToEvent, RandomDays);
        }
    }
}
