using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Away_Day_Planner.Models.Login
{
    public class User : IUser 
    {
        public User(string firstName, string lastName, string username, string userEmail, String userPassword, string userRole)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.userEmail = userEmail;
            this.userPassword = userPassword;
            this.userRole = userRole;
        }

        private int USERID;
        [Required, Key]
        public int userID { get => USERID; set => USERID = value; }

        private string FIRSTNAME;
        [MinLength(2), MaxLength(50)]
        public string firstName { get => FIRSTNAME; set => FIRSTNAME = value; }

        private string LASTNAME;
        [MinLength(2), MaxLength(50)]
        public string lastName { get => LASTNAME; set => LASTNAME = value; }

        private string USERNAME;
        [MinLength(5), MaxLength(20)]
        public string username { get => USERNAME; set => USERNAME = value; }

        private string USEREMAIL;
        [MinLength(10), MaxLength(50)]
        public string userEmail { get => USEREMAIL; set => USEREMAIL = value; }

        private string USERPASSWORD;
        [MinLength(8), MaxLength(50)]
        public String userPassword { get => USERPASSWORD; set => USERPASSWORD = value; }

        private string USERROLE;
        [MinLength(2), MaxLength(20)]
        public string userRole { get => USERROLE; set => USERROLE = value; }

    }
}
