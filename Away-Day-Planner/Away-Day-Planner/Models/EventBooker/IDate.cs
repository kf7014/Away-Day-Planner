using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.EventBooker
{
    public interface IDate
    {
        int id { set; get; }
        DateTime dateTime { set; get; }
    }
}
