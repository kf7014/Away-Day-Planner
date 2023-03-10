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

namespace Away_Day_Planner.Models.ClientDepartment
{
    public class Department : IDepartment
    {
        
        private int Id;
        [Required, Key]
        public int id { get => Id; set => Id = value; }

        private string Name;
        [Required, MinLength(2), MaxLength(50)]
        public string name { get => Name; set => Name = value; }

        public virtual Client Client { get; set; }
        [ForeignKey("Client")]
        public int ClientFK { get; set; }
        public Department()
        {

        }
        public Department(String name, int clientFK)
        {
            Name = name;
            ClientFK = clientFK;
        }
    }
}
