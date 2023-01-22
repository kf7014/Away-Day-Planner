using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Security
{
    public class Hashing
    {
        public static byte[] generateSalt()
        {
            byte[] salt = new byte[20];
            using (RandomNumberGenerator randomNumber = new RNGCryptoServiceProvider())
                randomNumber.GetNonZeroBytes(salt);

            return salt;
        }
        
        public static byte[] createHash(byte[] unhashedPass, byte[] salt)
        {
            using (var rfc2898 = new Rfc2898DeriveBytes(unhashedPass, salt, 10000))
            {
                return rfc2898.GetBytes(20);
            }
        }

        public static Boolean compareHash(byte[] userPassword, byte[] dbHashedPassword, byte[] dbSalt)
        {
            byte[] hashedUserPassword = createHash(userPassword, dbSalt);

            if(hashedUserPassword == dbHashedPassword)
            {
                Console.WriteLine("Match");
                return true;
            } else
            {
                Console.WriteLine("No match");
                return false;
            }
        }

    }
}
