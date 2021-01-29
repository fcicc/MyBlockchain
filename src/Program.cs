using System;

namespace MyBlockchain
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var blockchain = new Blockchain<string>("Genesis");

            blockchain.AddBlock("First block");
            blockchain.AddBlock("Second block");
            blockchain.AddBlock("Third block");
            blockchain.AddBlock("Fourth block");
            blockchain.AddBlock("Fifth block");
            blockchain.AddBlock("Sixth block");
            blockchain.AddBlock("Seventh block");
            blockchain.AddBlock("Eight block");
            blockchain.AddBlock("Ninth block");
            blockchain.AddBlock("Tenth block");

            foreach (var block in blockchain)
            {
                Console.WriteLine($"{block.Data}\t{block.Hash}");
            }
        }
    }
}
