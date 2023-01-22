/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009595
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Database
{
    internal interface IDatabaseInterface
    {
        // Implements CRUD features
        DbContext GetContext();
        void Add<T>(T e_type) where T : class;
        (T, DbContext) Get<T>(int id) where T : class;
        (DbSet<T>, DbContext) GetAll<T>() where T : class;
        IResults GetRange<T>(T e_type, int start_id, int stop_id) where T : Type;
        void Update<T>(T old_entity, T new_entity) where T : class, IObjWithID;
        void Update<T>(int id, T new_entity) where T : class, IObjWithID;
        void Update<T>(T obj, string field, object value) where T : class, IObjWithID;
        void Delete<T>(T e_type) where T : class;
        int GetNextID<T>() where T : class, IObjWithID;
        void ClearSet<T>() where T : class;
        void DisposeContext(DbContext ctx);
    }
}
