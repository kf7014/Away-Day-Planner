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

        [Required]
        public virtual Client Client { get; set; }
        [ForeignKey("Client")]
        public int ClientFK { get; set; }

        public Department(String name, Client client, int clientFK)
        {
            Name = name;
            Client = client;
            ClientFK = clientFK;
        }
    }
}
