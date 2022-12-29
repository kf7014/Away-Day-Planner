﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Away_Day_Planner.Models.EventBooker
{
    public class FacilitatorTeam
    {
        private int Id;
        [Key]
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        private ICollection<IPerson> FacilitatorsList;
        public ICollection<IPerson> facilitatorsList
        {
            get { return FacilitatorsList; }
            set { FacilitatorsList = value; }
        }

        private ICollection<IDate> BookedDays;
        public ICollection<IDate> bookedDays
        {
            get { return BookedDays; }
            set { BookedDays = value; }
        }

        public virtual Activity Activity { get; set; }
        [ForeignKey("Activity")]
        public int ActivityFK { get; set; }
    }
}
