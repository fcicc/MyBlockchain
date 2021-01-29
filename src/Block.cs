using System;

namespace MyBlockchain
{
    public class Block<T>
    {
        public Block(T data, string previousBlockHash)
        {
            Data = data
                ?? throw new ArgumentNullException(nameof(data));

            PreviousBlockHash = previousBlockHash
                ?? throw new ArgumentNullException(nameof(previousBlockHash));

            Hash = Crypto.ComputeSHA256(data.ToString(), previousBlockHash);
        }

        public T Data { get; }

        public string PreviousBlockHash { get; }

        public string Hash { get; }
    }
}
