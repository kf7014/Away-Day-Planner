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

        public static ArrayList GenerateObjects<T>(int num, T obj) where T : ITestObject
        {
            bool flag_id = false;
            ArrayList objects = new();
            if (obj.Type() == ObjectList.ObjectWithID) flag_id = true;

            for (int i = 0; i < num; i++)
            {
                ITestObject newObj = Activator.CreateInstance<T>();

                if (flag_id)
                {
                    ObjectWithID x = (ObjectWithID)newObj;
                    x.id = i;
                    objects.Add(x);
                }
                else
                {
                    objects.Add(newObj);
                }
            }
            return objects;
        }

        private static bool CheckTypes(ArrayList list)
        {
            if (list.Count == 0) return false;
            return list.ToArray().Select(t => t?.GetType()).Distinct().Count() == 1;
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
