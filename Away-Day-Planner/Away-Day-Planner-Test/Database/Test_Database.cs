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
using System.Collections;
using System.Security.Cryptography;
using System.Reflection.Metadata;

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

            ObjectWithID Object = new(1);


            dbi.ContextType = mockContext.Object.GetType();
            dbi.Add(Object, mockSet.Object);

            mockSet.Verify(x => x.Add(It.IsAny<ObjectWithID>()), Times.Once());

            dbi.Delete(Object, mockSet.Object);
            mockSet.Verify(x => x.Remove(It.IsAny<ObjectWithID>()), Times.Once());

            mockContext.Object.Dispose();
        }
        [TestMethod]
        public void ID_DB02_Assert_Multiple_Insertion_Multiple_Deletion() 
        {
            int NUM_OF_OBJECTS = 5;

            List<ObjectWithID> objectList = Generation.GenerateObjectsWithIDS(NUM_OF_OBJECTS);

            DatabaseInterface dbi = new();
            Mock<DbSet<ObjectWithID>> mockSet = new();

            Mock<TestObjects.TestContext> mockContext = new();

            mockContext.Setup(c => c.ObjectsWithID).Returns(mockSet.Object);

            dbi.ContextType = mockContext.Object.GetType();

            foreach (ObjectWithID obj in objectList) dbi.Add(obj, mockSet.Object);
            foreach(ObjectWithID obj in objectList) dbi.Delete(obj, mockSet.Object);
  
            Assert.AreEqual(objectList.Count, NUM_OF_OBJECTS);
            mockSet.Verify(x => x.Add(It.IsAny<ObjectWithID>()), Times.Exactly(NUM_OF_OBJECTS));
            mockSet.Verify(x => x.Remove(It.IsAny<ObjectWithID>()), Times.Exactly(NUM_OF_OBJECTS));
        }
        [TestMethod]
        public void ID_DB03_Assert_Addition_Query() 
        {
            int NUM_OF_OBJECTS = 5;

            List<ObjectWithID> objectList = Generation.GenerateObjectsWithIDS(NUM_OF_OBJECTS);

            DatabaseInterface dbi = new();
            Mock<DbSet<ObjectWithID>> mockSet = new();

            IQueryable data = objectList.AsQueryable();

            mockSet.As<IQueryable<ObjectWithID>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<ObjectWithID>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<ObjectWithID>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<ObjectWithID>>().Setup(m => m.GetEnumerator()).Returns((IEnumerator<ObjectWithID>)data.GetEnumerator());
            mockSet.Setup(m => m.Remove(new ObjectWithID(1)));

            Mock<TestObjects.TestContext> mockContext = new();

            mockContext.Setup(c => c.ObjectsWithID).Returns(mockSet.Object);

            dbi.ContextType = mockContext.Object.GetType();

            foreach (ObjectWithID obj in objectList) dbi.Add(obj, mockSet.Object);

            IResults returnedData = dbi.GetAllFromSet(mockSet.Object);
            Assert.IsNotNull(returnedData);

            string testStr = "(Size : "+returnedData.GetList().Count+")\n";
            foreach(ObjectWithID obj in returnedData.GetList())
            {
                testStr += obj.ToString() +" : ID(" + obj.id +")\n";
            }
            Console.WriteLine(testStr);

            CollectionAssert.AreEquivalent(objectList, returnedData.GetList());
        }
    }
}
