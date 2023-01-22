/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009595
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
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
