using System;
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
            decimal sum = order.Sum(o => o.Value * UnitPrice);
            return sum;
        }
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
