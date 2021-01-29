using System;
using System.Security.Cryptography;
using System.Text;

namespace MyBlockchain
{
    public static class Crypto
    {
        public static string ComputeSHA256(string data, string previousBlockHash)
        {
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            if (previousBlockHash == null)
            {
                throw new ArgumentNullException(nameof(previousBlockHash));
            }

            using var sha256 = SHA256.Create();

            var hash = "";
            var nonce = 0;

            while (!hash.StartsWith("000"))
            {
                var buffer = Encoding.UTF8.GetBytes($"{data}\t{previousBlockHash}${nonce}");

                hash = Convert.ToBase64String(sha256.ComputeHash(buffer));
                nonce++;
            }

            return hash;
        }
    }
}
