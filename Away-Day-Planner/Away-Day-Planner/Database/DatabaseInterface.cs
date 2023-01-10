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
    internal class DatabaseInterface : IDatabaseInterface
    {
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
            if (entity == null) throw Errors["NullEntity"];
            using (DbContext context = GetContext())
            {

            }
        }

        public void Delete<T>(T entity) where T : class
        {
            if (entity == null) throw Errors["NullEntity"];
            using (DbContext context = GetContext())
            {
                    
            }
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
            using (DbContext context = GetContext())
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

        public EntitiesContext GetContext()
        {
            return new EntitiesContext();
        }
        public DbSet GetDBSet(Type T)
        {
            using (EntitiesContext dbc = GetContext()) 
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
                return dict[T.GetType()];
            }
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
    }
}
