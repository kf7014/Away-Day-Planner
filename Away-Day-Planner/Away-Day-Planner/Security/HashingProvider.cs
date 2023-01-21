using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Away_Day_Planner.Security
{
    public class HashingProvider
    {
        private static object locker = new object();
        private static SHA256 hasher = new SHA256Managed();
        public static readonly int HashByteLength = 32;

        public static byte[] GenerateHash(String userPassword, byte[] salt)
        {
            lock(locker)
            {
                byte[] password = Encoding.Unicode.GetBytes(userPassword);
                byte[] passwordWithSalt = password.Concat(salt).ToArray();
                return hasher.ComputeHash(passwordWithSalt);
            }
        }
        public static Boolean ValidateHash(String userPassword, byte[] salt, byte[] PasswordStored)
        {
            lock(locker)
            {
                return StructuralComparisons.StructuralEqualityComparer.Equals(GenerateHash(userPassword, salt), PasswordStored);
            }
        }
    }
}
