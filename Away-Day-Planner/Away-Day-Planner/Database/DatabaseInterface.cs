﻿using Away_Day_Planner.Database.Contexts;
using Away_Day_Planner.Models.ClientDepartment;
using Away_Day_Planner.Models.EventBooker;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;

namespace Away_Day_Planner.Database
{
    public class DatabaseInterface : IDatabaseInterface
    {

        public DbContext Context { get; set; }
        public Dictionary<Type, DbSet> DBSetList {get; set;}


        public DatabaseInterface() 
        {
            Context = new EntitiesContext();
        }

        public DatabaseInterface(DbContext context)
        {
            Context = context;
        }

        private static readonly Dictionary<string, Exception> Errors = new Dictionary<string, Exception>() 
        {
            {"InvalidType", new Exception("Oops, there was an unknown model type")},
            {"TypeMismatch", new Exception("Oops, you cannot update an entity with a different object")},
            {"NegativeID", new Exception("Oops, an ID cannot be negative")},
            {"InvalidRange", new Exception("Oops, Upper range cannot be lower than lower range")},
            {"NullEntity", new Exception("Object provided was null")},
        };

        public void Add<T>(T entity) where T : class
        {
            Add(entity, GetDBSet(entity).Cast<T>());
        }

        public void Add<T>(T entity, DbSet<T> dbs) where T : class
        {
            if (entity == null) throw Errors["NullEntity"];
            dbs.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            Delete(entity, GetDBSet(entity).Cast<T>());
        }

        public void Delete<T>(T entity, DbSet<T> dbs) where T : class
        {
            if (entity == null) throw Errors["NullEntity"];
            dbs.Remove(entity);
        }

        public void Update<T>(T old_entity, T new_entity) where T : class
        {
            Type e_type = old_entity.GetType();

            if (e_type != new_entity.GetType()) throw Errors["TypeMismatch"];
            if (e_type == null) throw Errors["NullEntity"];

            using (DbContext context = GetContext())
            {
                
            }
        }

        public IResults Get<T>(T e_type, int id) where T : Type
        {
            if (e_type == null) throw Errors["InvalidType"];
            if(id < 0) throw Errors["NegativeID"];

            IResults results = Results.Empty;
            using (var context = GetContext())
            {
            }
            return results;
        }

        public IResults GetAll<T>(T e_type) where T : Type
        {
            if (e_type == null) throw Errors["InvalidType"];

            IResults results = Results.Empty;
            using (DbContext context = GetContext())
            {
            }
            return results;
        }

        public DbContext GetContext()
        {
            return Context;
        }

        public DbSet GetDBSet<T>(T aClass) where T: class
        {
            if (Context.GetType() == typeof(EntitiesContext))
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
            else return DBSetList[aClass.GetType()];
        }

        public IResults GetRange<T>(T e_type, int start_id, int stop_id) where T : Type
        {
            if (e_type == null) throw Errors["InvalidType"];
            if (start_id < 0 || stop_id < 0) throw Errors["NegativeID"];
            if (start_id > stop_id) throw Errors["InvalidRange"];

            IResults results = Results.Empty;
            using (DbContext context = GetContext())
            {

            }
            return results;
        }

        public int GetNextID<T>(T e_type) where T : Type
        {
            if(e_type == null) throw Errors["InvalidType"];

            DbSet<T> dbs = GetDBSet(e_type).Cast<T>();
            return (int)dbs.Max(x => x.GetField("id").GetValue(null));
        }

        public void SaveChanges() 
        {
            GetContext().SaveChanges();
        }

        public void ClearSet<T>(DbSet set)
        {
            foreach (var x in set) 
            {
                set.Remove(x);
            }
            SaveChanges();
        }
    }
}
