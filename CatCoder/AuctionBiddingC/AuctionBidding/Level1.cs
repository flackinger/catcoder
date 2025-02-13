using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionBidding
{
    internal class Level1
    {
        public int AuctionPrice { get; set; }

        List<Bid> bidList = new List<Bid>();
        string currentBidder=null;

        public Level1(string data)
        {
           
            string[] dataArr = data.Split(',');
            AuctionPrice = Int32.Parse(dataArr[0]);

            for (int i = 1; i < dataArr.Length-1; i+=2)
            {
                Bid b = new Bid(dataArr[i], Int32.Parse(dataArr[i + 1]));
                bidList.Add(b);
            }

        }



        public void ComputeResult()
        {
            int index = 0;

            do
            {
                if (currentBidder == null)
                {
                    if (bidList[index].MaxBid >= AuctionPrice)
                    {
                       
                        currentBidder = bidList[index].Name;
                    }
                }
                else
                {
                    if (bidList[index].Name != currentBidder)
                    {
                        if (bidList[index].MaxBid > AuctionPrice)
                        {
                            AuctionPrice++;
                            currentBidder=bidList[index].Name;
                        }
                        else
                        {
                            bidList.RemoveAt(index);
                        }
                    }
                }
                index = (index+1)%bidList.Count;

            } while(bidList.Count > 1);

            Console.WriteLine(bidList[0].Name+","+AuctionPrice);
        }

      


    }
}
