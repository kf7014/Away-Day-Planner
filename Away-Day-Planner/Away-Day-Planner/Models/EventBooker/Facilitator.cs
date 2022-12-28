using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.EventBooker
{
    public class Facilitator : IPerson
    {
        private int Id;
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        private String FirstName;
        public String firstName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        private String LastName;
        public String lastName
        {
            get { return LastName; }
            set { LastName = value; }
        }

        private String EmailAddress;
        public String emailAddress
        {
            get { return EmailAddress; }
            set { EmailAddress = value; }
        }
    }
}
