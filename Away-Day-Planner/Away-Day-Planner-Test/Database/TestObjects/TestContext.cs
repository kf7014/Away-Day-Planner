using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner_Test.Database.TestObjects
{
    public class TestContext : DbContext
    {
        public TestContext() : base() { } 
        public virtual DbSet<ObjectWithID>? ObjectsWithID { get; set; }
    }
}
