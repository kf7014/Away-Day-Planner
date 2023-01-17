using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Away_Day_Planner.Models.Login
{
    public class Role : IRole
    {
        public Role(string staffRole)
        {
            this.staffRole = staffRole;
        }

        private int ROLEID;
        [Required, Key]
        public int roleID { get => ROLEID; set => ROLEID = value; }

        public virtual User User { get; set; }
        [ForeignKey("User")]
        public int UserFK { get; set; }


        private string STAFFROLE;
        [MinLength(2), MaxLength(50)]
        public string staffRole { get => STAFFROLE; set => STAFFROLE = value; }
    }
}
