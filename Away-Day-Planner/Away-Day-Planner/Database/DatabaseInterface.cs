using Away_Day_Planner.Database.Contexts;
using Away_Day_Planner.Models.ClientDepartment;
using Away_Day_Planner.Models.EventBooker;
using Away_Day_Planner.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;

namespace Away_Day_Planner.Database
{
    public class DatabaseInterface : IDatabaseInterface
    {
        // Load the relevent exceptions for this class from the utility functions
        private readonly Dictionary<string, Exception> Errors = ErrorList.DatabaseErrors;

        // Store the Type of context currently in use
        public Type ContextType { get; set;}

        // Store the Context object currently in use
        public DbContext Context { get; set; }

        // Constructor, Sets the default ContextType to the default context
        public DatabaseInterface() 
        {
            ContextType = typeof(EntitiesContext);
        }
        // Constructor, Allows to set a custom Context
        public DatabaseInterface(DbContext context)
        {
            ContextType = context.GetType();
        }
        // Adds an entity to its associated DbSet in the Interfaces current context
        public void Add<T>(T entity) where T : class
        {
            using (var context = GetContext())
            {
                if (AppSettings.Instance.VERBOSE) Util.Print_Tag("Adding " + entity.ToString(), "Database");
                if (entity == null) throw Errors["NullEntity"];
                context.Set<T>().Add(entity);
                SaveChanges(context);
            }
        }

        // Adds an entity to a specified DbSet
        public void Add<T>(T entity, DbSet<T> dbs) where T : class
        {
            using(var context = GetContext())
            {
                if (AppSettings.Instance.VERBOSE) Util.Print_Tag("Adding " + entity.ToString(), "Database");
                if (entity == null) throw Errors["NullEntity"];
                dbs.Add(entity);
                SaveChanges(context);
            }
        }
        // Deletes an entity from its DbSet in the current context
        public void Delete<T>(T entity) where T : class
        {
            using (var context = GetContext())
            {
                if (AppSettings.Instance.VERBOSE) Util.Print_Tag("Removing " + entity.ToString(), "Database");
                if (entity == null) throw Errors["NullEntity"];
                context.Set<T>().Attach(entity);
                context.Set<T>().Remove(entity);
                SaveChanges(context);
            }
        }
        public void Delete<T>(int id) where T : class
        {
            using (var context = GetContext())
            {
                Delete(Get<T>(id).Item1);
            }
        }
        // Deletes a specific entity from a specified DbSet
        public void Delete<T>(T entity, DbSet<T> dbs) where T : class
        {
            using (var context = GetContext())
            {
                if (entity == null) throw Errors["NullEntity"];
                dbs.Remove(entity);
                SaveChanges(context);
            }
        }
        /*
            Updates an entity
            Assumes immutable data structure, removes old entity and adds new entity.
         */
        public void Update<T>(T old_entity, T new_entity) where T : class
        {
            if (old_entity.GetType() != new_entity.GetType()) throw Errors["TypeMismatch"];
            if (old_entity == null || new_entity == null) throw Errors["NullEntity"];

            using(var context = GetContext())
            {
                Delete(old_entity);
                Add(new_entity);
                SaveChanges(context);
            }
        }
        public void Update<T>(int id, T new_entity) where T : class
        {
            using (var context = GetContext())
            {
                Delete<T>(id);
                Add(new_entity);
                SaveChanges(context);
            }
        }
        public (T, DbContext) Get<T>(int id) where T : class
        {
            DbContext context = GetContext();
            return (context.Set<T>().Find(id), context);
        }
        // Retuns entity by its id from specific DbSet
        public T Get<T>(Type e_type, int id, DbSet<T> dbs) where T : class
        {
            if (e_type == null) throw Errors["InvalidType"];
            if (id < 0) throw Errors["NegativeID"];

            return dbs.Find(id);
        }
        // Returns full dbset based on the type provided
        public (DbSet<T>, DbContext) GetAll<T>() where T : class
        {
            DbContext context = GetContext();
            return (context.Set<T>(), context);
        }
        public DbSet<T> GetAll<T>(DbSet<T> dbs) where T : class
        {
            return dbs;
        }
        // Returns a range from an ID to another ID, inclusive of both upper and lower IDs specified, returns a Results object
        public IResults GetRange<T>(T e_type, int start_id, int stop_id) where T : Type
        {
            if (e_type == null) throw Errors["InvalidType"];
            if (start_id < 0 || stop_id < 0) throw Errors["NegativeID"];
            if (start_id > stop_id) throw Errors["InvalidRange"];

            using (var context = GetContext())
            {
                IResults results = Results.Empty;
                for(int i = start_id; i <= stop_id; i++)
                {
                    results.AddToResults(context.Set<T>().Find(i));
                }
                return results;
                
            }
        }
        // Retunrs the current Database Interfaces context in use. for use externally in more advanced context queries
        public DbContext GetContext()
        {
            Context = (DbContext)Activator.CreateInstance(ContextType);
            return Context;
        }
        // Gets a DbSet from the default context
        private DbSet<T> GetSet<T>(T aClass) where T: class
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
                return dict[aClass.GetType()].Cast<T>();
            }
        }
        // Gets the next ID of an entity, used for incremental IDs
        public int GetNextID<T>() where T : class, IObjWithID
        {
            if (typeof(T).GetField("id") == null) throw Errors["NoID"];
            using (var context = GetContext())
            {
                return (int)context.Set<T>().Max(x => x.id);
            }
        }
        // Enforces a save for any entities in transaction
        public void SaveChanges() 
        {
            GetContext().SaveChanges();
        }
        public void ClearSet<T>() where T : class
        {
            using (var context = GetContext())
            {
                foreach (var x in context.Set<T>())
                {
                    Delete(x);
                }
            }
        }
        //Enforce a dispose
        public void DisposeContext() 
        {
            GetContext().Dispose();
        }
        // Enforce a disposal of the context
        public void DisposeContext(DbContext ctx)
        {
            ctx.Dispose();
        }
        // Save the current contexts changes, includes a verbosity check for debug output
        private void SaveChanges<T>(T context) where T : DbContext 
        {
            try
            {
                context.SaveChanges();
            }
            catch(DbEntityValidationException ex)
            {
                if (AppSettings.Instance.VERBOSE)
                {
                    foreach (var e in ex.EntityValidationErrors)
                    {
                        Util.Print_Tag(e.Entry.Entity.GetType().Name, "EntityType");
                        Util.Print(e.Entry.State, "ValidationErrors");
                        foreach (var ve in e.ValidationErrors)
                        {
                            Util.Print_Tag("Property: " + ve.PropertyName + " Error: " + ve.ErrorMessage, "    -Property Errors");
                        }
                    }
                }
                throw;
            }
        }
    }
}