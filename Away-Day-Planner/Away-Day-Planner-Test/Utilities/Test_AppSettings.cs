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
using Away_Day_Planner.Utilities;

namespace Away_Day_Planner_Test.Utilities
{
    [TestClass]
    public class Test_AppSettings
    {
        [TestMethod]
        public void ID_01AS_Assert_Singleton()
        {
            AppSettings instance_1 = AppSettings.Instance;
            AppSettings instance_2 = AppSettings.Instance;

            Assert.IsNotNull(instance_1);
            Assert.IsNotNull(instance_2);

            Assert.AreSame(instance_1, instance_2);
        }
        [TestMethod]
        public void ID_02AS_Assert_Get_Set_Value()
        {
            AppSettings.Instance.VERBOSE = true;
            Assert.IsTrue(AppSettings.Instance.VERBOSE);

            AppSettings.Instance.VERBOSE = false;
            Assert.IsFalse(AppSettings.Instance.VERBOSE);

            AppSettings.Instance.LOGGING = true;
            Assert.IsTrue(AppSettings.Instance.LOGGING);

            AppSettings.Instance.LOGGING = false;
            Assert.IsFalse(AppSettings.Instance.LOGGING);
        }
    }
}
