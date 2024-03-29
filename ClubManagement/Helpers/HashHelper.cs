﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagement.Helpers
{
    class HashHelper
    {
        public static string HashPassword(string password)
        {
            var bytes = new UTF8Encoding().GetBytes(password);
            byte[] hashBytes;
            using (var algorithm = new System.Security.Cryptography.SHA512Managed())
            {
                hashBytes = algorithm.ComputeHash(bytes);
            }
            return Convert.ToBase64String(hashBytes);
        }
        public static string DecodeConnString(string hashConnString)
        {
            byte[] hashBytes = Convert.FromBase64String(hashConnString);
            string connString = Encoding.UTF8.GetString(hashBytes);
            return connString;
        }
    }
}
