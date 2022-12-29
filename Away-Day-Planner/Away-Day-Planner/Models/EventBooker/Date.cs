using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.EventBooker
{
    class Date : IDate
    {
        private int Id;
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        private DateTime DateTime;
        public DateTime dateTime
        {
            get { return DateTime; }
            set { DateTime = value; }
        }
    }
}
