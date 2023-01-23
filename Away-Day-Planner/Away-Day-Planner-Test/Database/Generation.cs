/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009505
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using Away_Day_Planner_Test.Database.TestObjects;
using Moq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner_Test.Database
{
    public enum ObjectList
    {
        GenericObject,
        ObjectWithID
    }

    public class Generation
    {
        private static readonly Dictionary<ObjectList, Mock> Objects = new()
        {
            { ObjectList.ObjectWithID, new Mock<DbSet<ObjectWithID>>()},
        };
        public static Mock<TestObjects.TestContext> GetContext()
        {
            return new Mock<TestObjects.TestContext>();
        }
        public static Mock GetSet(ITestObject obj)
        {
            return Objects[obj.Type()];
        }

        public static List<ObjectWithID> GenerateObjectsWithIDS(int num)
        {
            List<ObjectWithID> objects = new();

            for(int i = 0; i < num; i++) objects.Add(new ObjectWithID(i + 1));

            return objects;
        }

        public Dictionary<Type, DbSet> TestDBSetList() 
        {
            return new Dictionary<Type, DbSet>()
            {
                {typeof(ObjectWithID), GetContext().Object.ObjectsWithID}
            };
        }

    }
}
