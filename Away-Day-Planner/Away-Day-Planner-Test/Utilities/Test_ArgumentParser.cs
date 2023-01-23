/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009505
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using Away_Day_Planner.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner_Test.Utilities
{
    [TestClass]
    public class Test_ArgumentParser
    {
        [TestMethod]
        public void ID_01AP_Assert_No_Args()
        {
            string[] emptyArray = Array.Empty<string>();
            ArgumentParser AP = new(emptyArray);

            Assert.IsNotNull(AP);
            Assert.AreEqual(AP.GetArguments().Count, 0);
        }
        [TestMethod]
        public void ID_02AP_Assert_Valid_Arg()
        {
            string[] array = { "-v" };
            ArgumentParser AP = new(array);

            Assert.IsNotNull(AP);
            Assert.AreEqual(AP.GetArguments().Count, 1);
            Assert.IsTrue(AP.GetArguments().Contains(ArgumentParser.VALID_ARG.VERBOSE));
        }
        [TestMethod]
        public void ID_03AP_Assert_Invalid_Arg()
        {
            string[] array = { "-FAKE_ARG" };
            ArgumentParser AP = new(array);

            Assert.IsNotNull(AP);
            Assert.AreEqual(AP.GetArguments().Count, 0);
        }
        [TestMethod]
        public void ID_04AP_Assert_Invalid_And_Valid_Args()
        {
            string[] array = { "-FAKE_ARG", "-v" };
            ArgumentParser AP = new(array);

            Assert.IsNotNull(AP);
            Assert.AreEqual(AP.GetArguments().Count, 1);
            Assert.IsTrue(AP.GetArguments().Contains(ArgumentParser.VALID_ARG.VERBOSE));
        }
        [TestMethod]
        public void ID_05AP_Assert_String_Print_Empty()
        {
            string[] emptyArray = Array.Empty<string>();
            ArgumentParser AP = new(emptyArray);

            Assert.IsNotNull(AP);
            Assert.AreEqual(AP.GetArgumentsAsString(), "Empty");
        }
    }
}
