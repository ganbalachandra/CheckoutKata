using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public class Checkout : ICheckout
    {
        /// <summary>
        /// fake it with hardcoded value
        /// </summary>
        /// <returns></returns>
        public int GetTotalPrice()
        {
            return 0;
        }

        public void Scan(char item)
        {
            throw new NotImplementedException();
        }
    }
}
