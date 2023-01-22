using Away_Day_Planner.Database;
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
        public static Tuple<string, byte[]> HashPassword(String password)
        {
            Byte[] salt = new Byte[24];

            //Randomises hash generated
            RNGCryptoServiceProvider cryptoProvider = new RNGCryptoServiceProvider();
            cryptoProvider.GetBytes(salt);

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, 1000);

            Tuple<string, byte[]> hashSalt = new Tuple<string, byte[]>(Convert.ToBase64String(pbkdf2.GetBytes(20)), salt);
            return hashSalt;
        }

        public static bool checkHashMatch(String plaintextPassword, string hashedPassword, Tuple<string, byte[]> hashSalt)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(plaintextPassword, hashSalt.Item2, 1000);
            byte[] hash = pbkdf2.GetBytes(20);
            String newHashedPassword = Convert.ToBase64String(hash);

            if (newHashedPassword == hashSalt.Item1)
            {
                Console.WriteLine("True");
                return true;
            }
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }
    }
}
