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
    public class Test_ErrorList
    {
        [TestMethod]
        [ExpectedException(typeof(Exception),"Oops, Null Object")]
        public void ID_01EL_Assert_Error_Thrown()
        {
            Dictionary<string, Exception> errors = ErrorList.Errors;
            throw errors["Null"];
        }
    }
}
