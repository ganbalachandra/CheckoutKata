using System.Collections.Generic;


namespace Checkout
{
    public class Checkout : ICheckout
    {
        private readonly Dictionary<char, int> _prices ;
        private readonly Dictionary<char, int> _NoOfSimilarItems;
        public Checkout() {
            _prices = new Dictionary<char, int>() { { 'A', 50 }, { 'B', 30 },{ 'C', 20 }, { 'D', 15 } };
            _NoOfSimilarItems = new Dictionary<char, int> { { 'A', 0 }, { 'B', 0 }, { 'C', 0 }, { 'D', 0 } };
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
            // increment item counter
            _NoOfSimilarItems[item]++;
            Total += _prices[item];
            // business rule, if A and no of items 3 then discount amount 20
            if (item == 'A' && _NoOfSimilarItems[item] == 3)
            {
                Total -= 20;
            }
            // business rule, if B and no of items 2 then discount amount 15
            if (item == 'B' && _NoOfSimilarItems[item] == 2)
            {
                Total -= 15;
            }
        }
    }
}
