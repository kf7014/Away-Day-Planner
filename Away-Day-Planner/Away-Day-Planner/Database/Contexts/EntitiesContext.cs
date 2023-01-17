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
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<FacilitatorTeam> FacilitatorTeams { get; set; }
        public virtual DbSet<Facilitator> Facilitators { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Contractor> Contractors { get; set; }
        public virtual DbSet<EventFlexibilityDate> EventFlexibilityDates { get; set; }
        public virtual DbSet<BookedFacilitatorTeamDate> BookedFacilitatorTeamDates { get; set; }
        public virtual DbSet<ActivityTemplate> ActivityTemplates { get; set; }
        public virtual DbSet<RewardTemplate> RewardTemplates { get; set; }
        public virtual DbSet<AdditionTemplate> AdditionTemplates { get; set; }

        public EntitiesContext() : base("name=connection-string"){}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
