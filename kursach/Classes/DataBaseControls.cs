using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace kursach.Classes
{
    internal class DataBaseControls
    {
        public string Hash(string password)
        {
            MD5 md5hasher = MD5.Create();

            var data = md5hasher.ComputeHash(Encoding.Default.GetBytes(password));

            return Convert.ToBase64String(data);
        }
    }
}
