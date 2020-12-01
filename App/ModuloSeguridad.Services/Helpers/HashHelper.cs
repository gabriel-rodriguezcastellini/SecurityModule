﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace ModuloSeguridad.Services.Helpers
{
    public class HashHelper
    {
        public string GenerateHash(string clave)
        {
            return GetHash(clave);
        }

        public bool CompareHash(string input, string hash)
        {
            return VerifyHash(input, hash);
        }

        private static string GetHash(string input)
        {
            using var sha256Hash = SHA256.Create();
            // Convert the input string to a byte array and compute the hash.
            byte[] data = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        private static bool VerifyHash(string input, string hash)
        {
            // Hash the input.
            var hashOfInput = GetHash(input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }
    }
}
