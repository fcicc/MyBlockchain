using System.Collections;
using System.Collections.Generic;

namespace MyBlockchain
{
    public class Blockchain<T> : IEnumerable<Block<T>>
    {
        private readonly List<Block<T>> _blocks;

        public Blockchain(T genesisData)
        {
            _blocks = new List<Block<T>>
            {
                Genesis.CreateGenesisBlock(genesisData)
            };
        }

        public void AddBlock(T data)
        {
            _blocks.Add(
                new Block<T>(
                    data,
                    _blocks[_blocks.Count - 1].Hash
                )
            );
        }

        public IEnumerator<Block<T>> GetEnumerator()
        {
            return _blocks.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
