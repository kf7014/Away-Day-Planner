/*
* Aaron Beattie   - W19017261
* Sandra Czernik  - W19009505
* Kieran Robinson - W19002952
* Scott Donaldson - W19019810
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Away_Day_Planner.Models.EventBooker
{
    public class RewardTemplate : IReward
    {
        private int Id;
        [Key]
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        private String Name;
        [Required, MinLength(2), MaxLength(50)]
        public String name
        {
            get { return Name; }
            set { Name = value; }
        }

        private Decimal Price;
        public Decimal price
        {
            get { return Price; }
            set { Price = value; }
        }
    }
}
