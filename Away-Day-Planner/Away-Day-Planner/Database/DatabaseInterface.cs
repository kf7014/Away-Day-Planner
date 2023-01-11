using Away_Day_Planner.Database.Contexts;
using Away_Day_Planner.Models.ClientDepartment;
using Away_Day_Planner.Models.EventBooker;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Away_Day_Planner.Database
{
    public class DatabaseInterface : IDatabaseInterface
    {
        
        public Dictionary<Type, DbSet> DBSetList {get; set;}
        public Type ContextType { get; set;}
        public DbContext Context { get; set; }

        public DatabaseInterface() 
        {
            ContextType = typeof(EntitiesContext);
        }

        public DatabaseInterface(DbContext context)
        {
            ContextType = context.GetType();
        }

        private static readonly Dictionary<string, Exception> Errors = new Dictionary<string, Exception>() 
        {
            {"InvalidType", new Exception("Oops, there was an unknown model type")},
            {"TypeMismatch", new Exception("Oops, you cannot update an entity with a different object")},
            {"NegativeID", new Exception("Oops, an ID cannot be negative")},
            {"InvalidRange", new Exception("Oops, Upper range cannot be lower than lower range")},
            {"NullEntity", new Exception("Object provided was null")},
            {"NoID", new Exception("Object does not contain id field (Case sensitive)")},

        };

        public void Add<T>(T entity) where T : class
        {
            Add(entity, GetSet(entity));
        }

        public void Add<T>(T entity, DbSet<T> dbs) where T : class
        {
            using(var context = GetContext())
            {
                if (entity == null) throw Errors["NullEntity"];
                dbs.Add(entity);
                context.SaveChanges();
            }
        }

        public void AddNoDispose<T>(T entity, DbSet<T> dbs) where T : class
        {
            if (entity == null) throw Errors["NullEntity"];
            dbs.Add(entity);
            Context.SaveChanges();
        }

        public void Delete<T>(T entity) where T : class
        {
            Delete(entity, GetSet(entity));
        }

        public void Delete<T>(T entity, DbSet<T> dbs) where T : class
        {
            using (var context = GetContext())
            {
                if (entity == null) throw Errors["NullEntity"];
                dbs.Remove(entity);
                context.SaveChanges();
            }
        }

        public void DeleteNoDispose<T>(T entity, DbSet<T> dbs) where T : class
        {
            if (entity == null) throw Errors["NullEntity"];
            dbs.Remove(entity);
            Context.SaveChanges();
        }

        public void Update<T>(T old_entity, T new_entity) where T : class
        {
            if (old_entity.GetType() != new_entity.GetType()) throw Errors["TypeMismatch"];
            if (old_entity == null || new_entity == null) throw Errors["NullEntity"];

            using(var context = GetContext())
            {
                Delete(old_entity);
                Add(new_entity);
                context.SaveChanges();
            }
        }

        public IResults Get<T>(T e_type, int id) where T : Type
        {
            return Get(e_type, id, GetSet(e_type));
        }

        public IResults Get<T>(Type e_type, int id, DbSet<T> dbs) where T : class
        {
            using(var context = GetContext())
            {
                if (e_type == null) throw Errors["InvalidType"];
                if (id < 0) throw Errors["NegativeID"];

                Results results = new Results();
                results.AddToResults(dbs.Find(id));
                return results;
            }
        }

        public IResults GetAll<T>(T e_type) where T : Type
        {
            using (var context = GetContext())
            {
                return new Results(context.Set<T>().ToList());
            }
        }
        public IResults GetAllFromSet<T>(DbSet<T> dbs) where T : class
        {
            using (var context = GetContext())
            {
                return new Results(dbs.ToList());
            }
        }
        public IResults GetAllFromSetNoDispose<T>(DbSet<T> dbs) where T : class
        {
            return new Results(dbs.ToList());
        }


        public DbSet<T> GetSet<T>(T e_type) where T : class 
        { 
            return GetDBSet(e_type).Cast<T>();
        } 

        public IResults GetRange<T>(T e_type, int start_id, int stop_id) where T : Type
        {
            return GetRange(e_type, start_id, stop_id, GetSet(e_type));
        }
        public IResults GetRange<T>(T e_type, int start_id, int stop_id, DbSet<T> dbs) where T : Type
        {
            if (e_type == null) throw Errors["InvalidType"];
            if (start_id < 0 || stop_id < 0) throw Errors["NegativeID"];
            if (start_id > stop_id) throw Errors["InvalidRange"];

            using (var context = GetContext())
            {
                IResults results = Results.Empty;
                for(int i = start_id; i <= stop_id; i++)
                {
                    results.AddToResults(dbs.Find(i));
                }
                return results;
            }
        }

        public DbContext GetContext()
        {
            Context = (DbContext)Activator.CreateInstance(ContextType);
            return Context;
        }

        public DbSet GetDBSet<T>(T aClass) where T: class
        {
            if (ContextType.GetType() == typeof(EntitiesContext))
            {
                using (EntitiesContext dbc = (EntitiesContext)GetContext())
                {
                    Dictionary<Type, DbSet> dict = new Dictionary<Type, DbSet>()
                {
                    { typeof(Client),                   dbc.Clients},
                    { typeof(Department),               dbc.Departments},
                    { typeof(Activity),                 dbc.Activities},
                    { typeof(FacilitatorTeam),          dbc.FacilitatorTeams},
                    { typeof(Facilitator),              dbc.Facilitators},
                    { typeof(Event),                    dbc.Events},
                    { typeof(Contractor),               dbc.Contractors},
                    { typeof(EventFlexibilityDate),     dbc.EventFlexibilityDates},
                    { typeof(BookedFacilitatorTeamDate),dbc.BookedFacilitatorTeamDates},
                };
                    return dict[aClass.GetType()];
                }
            }
            else
            {
                using(var context = GetContext())
                {
                    return DBSetList[aClass.GetType()];
                }
            }
        }

        public int GetNextID<T>(T e_type) where T : Type
        {
            if(e_type == null) throw Errors["InvalidType"];
            if (e_type.GetField("id") == null) throw Errors["NoID"];

            using (var context = GetContext())
            {
                DbSet<T> dbs = GetSet(e_type);
                return (int)dbs.Max(x => x.GetField("id").GetValue(null));
            }
        }

        public void SaveChanges() 
        {
            GetContext().SaveChanges();
        }

        public void ClearSet<T>(DbSet set)
        {
            using (var context = GetContext())
            {
                foreach (var x in set)
                {
                    set.Remove(x);
                }
                SaveChanges();
            }
        }

        public void DisposeContext() 
        {
            GetContext().Dispose();
        }
        public void DisposeContext(DbContext ctx)
        {
            ctx.Dispose();
        }
    }
}
