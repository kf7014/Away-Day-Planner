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
        DatabaseAbstraction databaseAbstraction;
        public static Tuple<string, byte[]> HashPassword(String password)
        {
            Byte[] salt = new Byte[24];

            //Randomises hash generated
            RNGCryptoServiceProvider cryptoProvider = new RNGCryptoServiceProvider();
            cryptoProvider.GetBytes(salt);

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, 1000);

            Console.WriteLine(Convert.ToBase64String(pbkdf2.GetBytes(20)));

            Tuple<string, byte[]> hashSalt = new Tuple<string, byte[]>(Convert.ToBase64String(pbkdf2.GetBytes(20)), salt);
            Console.WriteLine("Hash: " + hashSalt.Item1);

            return hashSalt; // Size of PBKDF2-HMAC-SHA-1 Hash 
        }
    }
}
