using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public class Checkout : ICheckout
    {

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
            if (item == 'A')
                Total += 50;
            if (item == 'B')
                Total += 30;
        }
    }
}
