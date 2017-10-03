using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public class Checkout : ICheckout
    {
        private readonly Dictionary<char, int> _prices ;
        public Checkout() {
            _prices = new Dictionary<char, int>() { { 'A', 50 }, { 'B', 30 },{ 'C', 20 }, { 'D', 15 } };

        }
        public int Total { get; set; }
        /// <summary>
        /// change the hardcoded total to some what dynamic
        /// </summary>
        /// <returns></returns>
        public int GetTotalPrice()
        {
            return Total;
        }

        public void Scan(char item)
        {
            Total +=_prices[item];
        }
    }
}
