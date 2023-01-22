/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009595
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Utilities;

namespace Away_Day_Planner_Test.Utilities
{
    [TestClass]
    public class Test_Util
    {
        [TestMethod]
        public void ID_01UT_Assert_Console_Redirect()
        {

            string expectedString = "Hello World";
            TextWriter current = Console.Out;

            var FakeConsole = new StringWriter();
            Console.SetOut(FakeConsole);


            Console.WriteLine(expectedString);
            string returnedString = FakeConsole.ToString().Remove(expectedString.Length);
            Assert.AreEqual(expectedString, returnedString);


            // Debugging StringWriting including a CRNL at end of ToString() method
            Console.SetOut(current);
            Console.WriteLine("String Writer adds CRNL for some reason, just filtered it above, look at STDOUT for proof:\n ");
            string outputString = "Returned unfilter: \n";
            foreach(byte b in FakeConsole.ToString().Select(v => (byte)v))
            {
                outputString += b.ToString();
            }

            outputString += "\n\nExpected: \n";

            foreach (byte b in Encoding.ASCII.GetBytes(expectedString))
            {
                outputString += b.ToString();
            }
            outputString += "\n\nReturned + Filter: \n";

            foreach (byte b in Encoding.ASCII.GetBytes(returnedString))
            {
                outputString += b.ToString();
            }
            Console.WriteLine(outputString);
        }
        // Function to mitigate binding to STDOUT including CRNL
        public string ConsoleValue(string value)
        {
            return value.Replace("\r", "").Replace("\n", "");
        }
        [TestMethod]
        public void ID_02UT_Assert_Log()
        {
            string expectedString = "Hello World : Hello World";
            TextWriter current = Console.Out;

            var FakeConsole = new StringWriter();
            Console.SetOut(FakeConsole);

            Util.Print(expectedString);

            string returnedString = ConsoleValue(FakeConsole.ToString());

            Assert.AreEqual(expectedString, returnedString);

            Console.SetOut(current);
        }
        [TestMethod]
        public void ID_03UT_Assert_Log_Tag()
        {
            string expectedString = "Hello World";
            TextWriter current = Console.Out;

            var FakeConsole = new StringWriter();
            Console.SetOut(FakeConsole);

            Util.Print_Tag(expectedString, "Test");

            string returnedString = ConsoleValue(FakeConsole.ToString());

            Assert.AreEqual("Test : " + expectedString, returnedString);

            Console.SetOut(current);
        }

        [TestMethod]
        public void ID_04UT_Assert_Debug_Log()
        {
            string expectedString = "Hello World";
            TextWriter current = Console.Out;

            var FakeConsole = new StringWriter();
            Console.SetOut(FakeConsole);

            AppSettings.Instance.VERBOSE = false;
            Util.Debug_Print(expectedString);
            Assert.AreEqual("", ConsoleValue(FakeConsole.ToString()));

            AppSettings.Instance.VERBOSE = true;
            Util.Debug_Print(expectedString);
            Assert.AreEqual(expectedString, ConsoleValue(FakeConsole.ToString()));

            Console.SetOut(current);
        }
        [TestMethod]
        public void ID_05UT_Assert_Print_Generic()
        {
            string expectedString = "Test : System.Object";

            TextWriter current = Console.Out;
            var FakeConsole = new StringWriter();
            Console.SetOut(FakeConsole);

            Util.Print(new object(), "Test");

            Assert.AreEqual(expectedString, ConsoleValue(FakeConsole.ToString()));

            Console.SetOut(current);
        }
    }
}
