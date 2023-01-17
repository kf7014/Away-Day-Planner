using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Models.EventBooker
{
    public interface IRewardTemplate
    {
        int id { get; set; }
        String name { get; set; }
        Decimal price { get; set; }
    }
}
