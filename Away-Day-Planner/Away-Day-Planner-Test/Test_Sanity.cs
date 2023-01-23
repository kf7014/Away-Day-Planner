/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009505
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
namespace Away_Day_Planner_Test
{
    [TestClass]
    public class Test_Sanity
    {
        [TestMethod]
        public void ID_001_Assert_Sanity()
        {
            // Simple Sanity check
            Assert.AreEqual(true, true);
            Assert.AreEqual(false, false);
            Assert.IsNull(null);
            Assert.IsNotNull(new object());
            Assert.IsFalse(false);
            Assert.IsTrue(true);
        }
    }
}


// https://learn.microsoft.com/en-us/ef/ef6/fundamentals/testing/mocking

// ID Scheme:
// ID_[SUB][0-9]{2}_[NAME]
// ID_[0-9][3]_[NAME]

// General Tests
// Boundary Tests
// Sanity Checks
// Expected output handling
// Unexpected output handling

// Split the test sections into folders
// One Test Class per Concrete Class

// Maybe one test class per integration between classes later.  