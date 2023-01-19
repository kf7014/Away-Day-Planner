using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Away_Day_Planner.Models.ClientDepartment;
using Away_Day_Planner.Models.EventBooker;
using Away_Day_Planner.Models.Login;

namespace Away_Day_Planner.Database
{
    public class DatabaseAbstraction
    {
        IDatabaseInterface databaseInterface = new DatabaseInterface();

        public DatabaseAbstraction()
        {

        }

        public void addNewClient(String clientName, int noOfHoursAway, bool hasClientDispute)
        {
            Client newClient = new Client(clientName, noOfHoursAway, hasClientDispute);
            databaseInterface.Add(newClient); 
        }

        public void addNewDepartment(String name, Client client)
        {
            int clientFK = client.id;

            Department newDepartment = new Department(name, clientFK);
            databaseInterface.Add(newDepartment);
        }

        public void addNewEvent()
        {
            Event _event = new Event();
            databaseInterface.Add(_event);
        }

        public void addNewReward(String name, Decimal price, int activityFK)
        {
            Reward reward = new Reward(name, price, activityFK);
            databaseInterface.Add(reward);
        }

        public void addNewAddition(String name, Decimal price, int activityFK)
        {
            Addition addition = new Addition(name, price, activityFK);
            databaseInterface.Add(addition);
        }

        public void addNewActivity(String name, Decimal price, bool facilitatorRequired, int eventFK)
        {
            Activity activity = new Activity(name, price, facilitatorRequired, eventFK);
            databaseInterface.Add(activity);
        }

        public Event[] getAllEvents()
        {
            Tuple<DbSet<Event>, DbContext> result = databaseInterface.GetAll<Event>().ToTuple();
            Event[] events = result.Item1.ToArray();
            databaseInterface.DisposeContext(result.Item2);
            return events;
        }

        public Event getEvent(int eventId)
        {
            Tuple<Event, DbContext> result = databaseInterface.Get<Event>(eventId).ToTuple();
            Event _event = result.Item1;
            databaseInterface.DisposeContext(result.Item2);
            return _event;
        }

        public Activity[] getAllActivities()
        {
            Tuple<DbSet<Activity>, DbContext> result = databaseInterface.GetAll<Activity>().ToTuple();
            Activity[] activities = result.Item1.ToArray();
            databaseInterface.DisposeContext(result.Item2);
            return activities;
        }

        public Client[] getAllClients()
        {
            Tuple<DbSet<Client>, DbContext> result = databaseInterface.GetAll<Client>().ToTuple();
            Client[] clients = result.Item1.ToArray();
            databaseInterface.DisposeContext(result.Item2);
            return clients;
        }

        public Client getClient(int clientId)
        {
            Tuple<Client, DbContext> result = databaseInterface.Get<Client>(clientId).ToTuple();
            Client client = result.Item1;
            databaseInterface.DisposeContext(result.Item2);
            return client;
        }

        public Department[] getClientDepartments(int clientId)
        {
            Tuple<DbSet<Department>, DbContext> result = databaseInterface.GetAll<Department>().ToTuple();
            Department[] departments = result.Item1.ToArray();
            List<Department> clientDepartments = new List<Department>();
            foreach (Department department in departments)
            {
                if (department.ClientFK == clientId)
                {
                    clientDepartments.Add(department);
                }
            }

            return clientDepartments.ToArray();
        }

        public Addition[] getActivityAdditions(int activityId)
        {
            Tuple<DbSet<Addition>, DbContext> result = databaseInterface.GetAll<Addition>().ToTuple();
            Addition[] additions = result.Item1.ToArray();
            List<Addition> activityAdditions = new List<Addition>();
            foreach (Addition addition in additions)
            {
                if (addition.ActivityFK == activityId)
                {
                    activityAdditions.Add(addition);
                }
            }

            return activityAdditions.ToArray();
        }

        public Reward[] getActivityRewards(int activityId)
        {
            Tuple<DbSet<Reward>, DbContext> result = databaseInterface.GetAll<Reward>().ToTuple();
            Reward[] rewards = result.Item1.ToArray();
            List<Reward> activityRewards = new List<Reward>();
            foreach (Reward reward in rewards)
            {
                if (reward.ActivityFK == activityId)
                {
                    activityRewards.Add(reward);
                }
            }

            return activityRewards.ToArray();
        }

        public ActivityTemplate[] getActivityTemplates()
        {
            Tuple<DbSet<ActivityTemplate>, DbContext> result = databaseInterface.GetAll<ActivityTemplate>().ToTuple();
            ActivityTemplate[] activityTemplates = result.Item1.ToArray();
            databaseInterface.DisposeContext(result.Item2);
            return activityTemplates;
        }

        public RewardTemplate[] getRewardTemplates()
        {
            Tuple<DbSet<RewardTemplate>, DbContext> result = databaseInterface.GetAll<RewardTemplate>().ToTuple();
            RewardTemplate[] rewardTemplates = result.Item1.ToArray();
            databaseInterface.DisposeContext(result.Item2);
            return rewardTemplates;
        }

        public AdditionTemplate[] getAdditionTemplates()
        {
            Tuple<DbSet<AdditionTemplate>, DbContext> result = databaseInterface.GetAll<AdditionTemplate>().ToTuple();
            AdditionTemplate[] additionTemplates = result.Item1.ToArray();
            databaseInterface.DisposeContext(result.Item2);
            return additionTemplates;
        }
        public ActivityTemplate getActivityTemplate(int activityId)
        {
            Tuple<ActivityTemplate, DbContext> result = databaseInterface.Get<ActivityTemplate>(activityId).ToTuple();
            ActivityTemplate activityTemplate = result.Item1;
            databaseInterface.DisposeContext(result.Item2);
            return activityTemplate;
        }
        public RewardTemplate getRewardTemplate(int rewardId)
        {
            Tuple<RewardTemplate, DbContext> result = databaseInterface.Get<RewardTemplate>(rewardId).ToTuple();
            RewardTemplate rewardTemplate = result.Item1;
            databaseInterface.DisposeContext(result.Item2);
            return rewardTemplate;
        }
        public AdditionTemplate getAdditionTemplate(int additionId)
        {
            Tuple<AdditionTemplate, DbContext> result = databaseInterface.Get<AdditionTemplate>(additionId).ToTuple();
            AdditionTemplate additionTemplate = result.Item1;
            databaseInterface.DisposeContext(result.Item2);
            return additionTemplate;
        }

        public Date[] getAllStoredDates()
        {
            Tuple<DbSet<Date>, DbContext> result = databaseInterface.GetAll<Date>().ToTuple();
            Date[] dates = result.Item1.ToArray();
            databaseInterface.DisposeContext(result.Item2);
            return dates;
        }

        public BookedFacilitatorTeamDate[] getBookedFacilitatorTeams()
        {
            Tuple<DbSet<BookedFacilitatorTeamDate>, DbContext> result = databaseInterface.GetAll<BookedFacilitatorTeamDate>().ToTuple();
            BookedFacilitatorTeamDate[] bookedFacilitatorTeamDates = result.Item1.ToArray();
            databaseInterface.DisposeContext(result.Item2);
            return bookedFacilitatorTeamDates;
        }
        }

        public void addNewUser(String firstName, String lastName, String username, String userEmail, String userPassword)
        {
            User newUser = new User(firstName, lastName, username, userEmail, userPassword);
            Console.WriteLine("New user added");
            databaseInterface.Add(newUser);
        }

        public User[] getAllUsers()
        {
            Tuple<DbSet<User>, DbContext> result = databaseInterface.GetAll<User>().ToTuple();
            User[] users = result.Item1.ToArray();
            databaseInterface.DisposeContext(result.Item2);
            return users;

        }
    }

}
