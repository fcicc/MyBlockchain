using System.Text;

namespace MyBlockchain
{
    public static class Genesis
    {
        public static Block<T> CreateGenesisBlock<T>(T data)
        {
            var previousBlockHash = new StringBuilder(44);
            for (var i = 0; i < 44; i++)
            {
                previousBlockHash.Append('0');
            }

            return new Block<T>(
                data,
                previousBlockHash.ToString()
            );
        }
    }
}
