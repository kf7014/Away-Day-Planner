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
        DbContext GetContext();
        void Add<T>(T e_type) where T : class;
        T Get<T>(T e_type, int id) where T : Type;
        IResults GetRange<T>(T e_type, int start_id, int stop_id) where T : Type;
        DbSet<T> GetAll<T>(T e_type) where T : Type;
        void Update<T>(T old_entity, T new_entity) where T : class;
        void Delete<T>(T e_type) where T : class;
        int GetNextID<T>(T e_type) where T : Type;
    }
}
