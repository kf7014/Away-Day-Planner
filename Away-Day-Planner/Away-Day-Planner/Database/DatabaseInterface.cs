using Away_Day_Planner.Database.Contexts;
using Away_Day_Planner.Models.EventBooker;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Away_Day_Planner.Database
{
    internal class DatabaseInterface : IDatabaseInterface
    {
        private static readonly Dictionary<string, Exception> Errors = new Dictionary<string, Exception>() 
        {
            {"InvalidType", new Exception("Oops, there was an unknown model type")},
            {"TypeMismatch", new Exception("Oops, you cannot update an entity with a different object")},
            {"NegativeID", new Exception("Oops, and ID cannot be negative")},
            {"InvalidRange", new Exception("Oops, Upper range cannot be lower than lower range")},
            {"NullEntity", new Exception("Object provided was null")},
        };

        public Dictionary<Type, DbContext> DbContextMap => new Dictionary<Type, DbContext>() 
        {
            {typeof(Client), new ClientContext()},
            {typeof(Department), new DepartmentContext()},
        };

        public void Add<T>(T entity) where T : class
        {
            if (entity == null) throw Errors["NullEntity"];
            using (DbContext context = GetContext(entity.GetType()))
            {

            }
        }

        public void Delete<T>(T e_type) where T : Type
        {
            if (e_type == null) throw Errors["InvalidType"];
            using (DbContext context = GetContext(e_type))
            {

            }
        }

        public void Update<T>(T old_entity, T new_entity) where T : class
        {
            Type e_type = old_entity.GetType();

            if (e_type != new_entity.GetType()) throw Errors["TypeMismatch"];
            if (e_type == null) throw Errors["NullEntity"];

            using (DbContext context = GetContext(e_type))
            {

            }
        }

        public IResults Get<T>(T e_type, int id) where T : Type
        {
            if (e_type == null) throw Errors["InvalidType"];
            if(id < 0) throw Errors["NegativeID"];

            IResults results = Results.Empty;
            using (DbContext context = GetContext(e_type))
            {

            }
            return results;
        }

        public IResults GetAll<T>(T e_type) where T : Type
        {
            if (e_type == null) throw Errors["InvalidType"];

            IResults results = Results.Empty;
            using (DbContext context = GetContext(e_type))
            {

            }
            return results;
        }

        public DbContext GetContext(Type x)
        {
            return DbContextMap[x];
        }

        public IResults GetRange<T>(T e_type, int start_id, int stop_id) where T : Type
        {
            if (e_type == null) throw Errors["InvalidType"];
            if (start_id < 0 || stop_id < 0) throw Errors["NegativeID"];
            if (start_id > stop_id) throw Errors["InvalidRange"];

            IResults results = Results.Empty;
            using (DbContext context = GetContext(e_type))
            {

            }
            return results;
        }
    }
}
