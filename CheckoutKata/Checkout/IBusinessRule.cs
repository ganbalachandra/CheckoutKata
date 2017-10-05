using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout
{
    public interface IBusinessRule
    {
        char Item { get; set; }
        int Discount { get; set; }
        int Count { get; set; }

    }
}
