/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009595
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Database;

namespace Away_Day_Planner_Test.Database
{
    [TestClass]
    public class Test_Results
    {
        [TestMethod]
        public void ID_DB04_Assert_Null_Object() 
        {
            Assert.AreEqual(Results.Empty.Size, 0);
            Assert.IsNull(Results.Empty.GetList());
        }
        [TestMethod]
        public void ID_DB05_Assert_Empty() 
        {
            List<object> x = new();
            Assert.AreEqual(x.Count, 0);

            Results testResults = new(x);

            Assert.AreEqual(testResults.Size, 0);
            Assert.IsNotNull(testResults.GetList());

        }
        [TestMethod]
        public void ID_DB06_Assert_Size()
        {
            int RANDOM_RANGE = 100;
            int NUMBER_OF_OBJECTS = new Random().Next(RANDOM_RANGE);

            object x = new();
            List<object> y = new();

            for (int i = 0; i < NUMBER_OF_OBJECTS; i++) y.Add(x);

            Results testResults = new(y);

            Assert.AreEqual(testResults.Size, NUMBER_OF_OBJECTS);

        }
    }
}
