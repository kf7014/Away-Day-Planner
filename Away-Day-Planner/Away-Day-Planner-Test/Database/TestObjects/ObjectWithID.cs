using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner_Test.Database.TestObjects
{
    public class ObjectWithID : ITestObject
    {
        [Key]
        public int id { get; set; }


        public ObjectWithID(int id)
        {
            this.id = id;
        }

        public ObjectList Type()
        {
            return ObjectList.ObjectWithID; ;
        }
    }
}
