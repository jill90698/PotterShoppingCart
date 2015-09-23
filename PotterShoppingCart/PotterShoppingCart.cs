using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotterShoppingCart
{
    public class PotterShoppingCart
    {
        private decimal UnitPrice = 100;

        public decimal ComputeOrderAmount(IDictionary<PotterEpisode, int> order)
        {
            decimal sum = 0;
            decimal discount;

            //Convert to Order model
            var newOrder = order.Select(x => new Order() {PotterEpisode = x.Key, Count = x.Value}).ToList();

            //Business logic
            while (newOrder.Any())
            {
                //Each loop will sum one times of a group of distinct potterEpisode book.
                int distinctBookCount = newOrder.Count();

                switch (distinctBookCount)
                {
                    case 2:
                        discount = 0.95m;                        
                        break;
                    case 3:
                        discount = 0.9m;
                        break;
                    default:
                        discount = 1;
                        break;
                }

                sum += newOrder.Sum(o => UnitPrice * discount);

                //After compute finish, remove this group of distinct potterEpisode book.
                RemoveComputedBooks(newOrder);
            }
 
            return sum;
        }

        private void RemoveComputedBooks(IList<Order> order)
        {
            //Deducted the count of each order
            List<Order> wantedRemoveList = new List<Order>();
            foreach (var item in order)
            {
                item.Count--;
                if (item.Count == 0)
                {
                    wantedRemoveList.Add(item);
                }
            }

            //Remove the count equal zero item in order list
            foreach (var item in wantedRemoveList)
            {
                order.Remove(item);
            }
        }
    }

    public class Order
    {
        public PotterEpisode PotterEpisode { get; set; }

        public int Count { get; set; }
    }

    public enum PotterEpisode
    {
        First,
        Second,
        Third,
        Fourth,
        Fifth
    }

  
}
