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
        public User(string firstName, string lastName, string username, string userEmail, byte[] userPassword, string userRole)
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
        [MinLength(2), MaxLength(50, ErrorMessage = "First name should be in between 2 and 50 characters long.")]
        public string firstName { get => FIRSTNAME; set => FIRSTNAME = value; }

        private string LASTNAME;
        [MinLength(2), MaxLength(50, ErrorMessage = "Last name should be in between 2 and 50 characters long.")]
        public string lastName { get => LASTNAME; set => LASTNAME = value; }

        private string USERNAME;
        [MinLength(5), MaxLength(20, ErrorMessage = "Username should be in between 5 and 20 characters long.")]
        public string username { get => USERNAME; set => USERNAME = value; }

        private string USEREMAIL;
        [MinLength(10), MaxLength(50, ErrorMessage = "Email should be in between 10 and 50 characters long.")]
        public string userEmail { get => USEREMAIL; set => USEREMAIL = value; }

        private byte[] USERPASSWORD;
        [MinLength(8), MaxLength(50, ErrorMessage = "Password should be in between 8 and 50 characters long.")]
        public byte[] userPassword { get => USERPASSWORD; set => USERPASSWORD = value; }

        private string USERROLE;
        [MinLength(5), MaxLength(10)]
        public string userRole { get => USERROLE; set => USERROLE = value; }

    }
}
