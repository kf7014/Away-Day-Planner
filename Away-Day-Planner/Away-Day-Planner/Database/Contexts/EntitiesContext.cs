using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Models.ClientDepartment;
using Away_Day_Planner.Models.EventBooker;

namespace Away_Day_Planner.Database.Contexts
{
    internal class EntitiesContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<FacilitatorTeam> FacilitatorTeams { get; set; }
        public DbSet<Facilitator> Facilitators { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<EventFlexibilityDate> EventFlexibilityDates { get; set; }
        public DbSet<BookedFacilitatorTeamDate> BookedFacilitatorTeamDates { get; set; }

        public EntitiesContext() : base("name=connection-string")
        {
            // public DbSet<Ix> x { get; set;}
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
