﻿using System;
using System.Security.Cryptography;
using System.Text;

namespace Books_shop.Data.Utils
{
    public class Hash
    {
        public static string GetMD5(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));
            return Convert.ToBase64String(hash);
        }
    }
}