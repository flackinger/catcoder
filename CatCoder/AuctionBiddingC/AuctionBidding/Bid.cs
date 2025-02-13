using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionBidding
{
    internal class Bid
    {
        public string Name { get; set; }
        public int MaxBid { get; set; }

        public Bid(string name, int maxBid)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            MaxBid = maxBid;
        }
    }
}
