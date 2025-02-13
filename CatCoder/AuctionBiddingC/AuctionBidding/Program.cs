using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionBidding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eingabe:");
            string data = Console.ReadLine();
            Level1 l1 = new Level1(data);

            l1.ComputeResult();

            Console.ReadKey();

        }
    }
}
