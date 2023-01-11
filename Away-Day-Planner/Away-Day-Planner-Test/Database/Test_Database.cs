using Away_Day_Planner_Test.Database.TestObjects;
using Away_Day_Planner;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Database;

namespace Away_Day_Planner_Test.Database
{
    [TestClass]
    public class Test_Database
    {
        [TestMethod]
        public void ID_DB01_Assert_Context_and_Set_Add_And_Remove_Single() 
        {
            DatabaseInterface dbi = new();
            Mock<DbSet<ObjectWithID>> mockSet = new();

            Mock<TestObjects.TestContext> mockContext = new();

            mockContext.Setup(c => c.ObjectsWithID).Returns(mockSet.Object);

            ObjectWithID Object = new ObjectWithID(1);


            dbi.Context = mockContext.Object;
            dbi.Add(Object, mockSet.Object);
            dbi.SaveChanges();

            mockSet.Verify(x => x.Add(It.IsAny<ObjectWithID>()), Times.Once());
            mockContext.Verify(x => x.SaveChanges(), Times.Once());

            dbi.Delete(Object, mockSet.Object);
            dbi.SaveChanges();

            mockSet.Verify(x => x.Remove(It.IsAny<ObjectWithID>()), Times.Once());
            mockContext.Verify(x => x.SaveChanges(), Times.Exactly(2));

            mockContext.Object.Dispose();
        }
        [TestMethod]
        public void ID_DB02_Assert_Multiple_Insertion_Multiple_Deletion() { }
        [TestMethod]
        public void ID_DB03_Assert_Selective_Deletion() { }
        [TestMethod]
        public void ID_DB04_Assert_Get_Single() { }
        [TestMethod]
        public void ID_DB05_Assert_Get_All() { }
        [TestMethod]
        public void ID_DB06_Assert_Get_Range() { }
        [TestMethod]
        public void ID_DB07_Assert_Get_Next_ID() { }
    }
}
