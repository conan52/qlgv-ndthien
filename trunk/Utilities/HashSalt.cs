using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace QLGV.Utilities
{
    public class HashSalt
    {
        public string ComputeHash(string plainText)
        {
            plainText += "NDThien.DanCu" + plainText;
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            SHA1Managed sha = new SHA1Managed();
            byte[] results = sha.ComputeHash(plainTextBytes);
            return Convert.ToBase64String(results);
        }

        public bool VerifyHash(string plainText, string hashValue)
        {
            return (ComputeHash(plainText) == hashValue);
        }
    }
}
