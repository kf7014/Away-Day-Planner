using Away_Day_Planner.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Models.ClientDepartment;

namespace Away_Day_Planner.Database.Contexts
{
    internal class ClientContext : DbContext
    {
        public ClientContext() : base("name=connection-string")
        {
           // public DbSet<Ix> x { get; set;}
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
