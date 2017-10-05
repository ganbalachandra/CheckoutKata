using System.Collections.Generic;


namespace Checkout
{
    public class Checkout : ICheckout
    {
        private readonly Dictionary<char, int> _prices ;
        private readonly Dictionary<char, int> _noOfSimilarItems;
        private readonly BusinessRule _itemARule;
        private readonly BusinessRule _itemBRule;
        public Checkout()
        {
            _prices = new Dictionary<char, int>() { { 'A', 50 }, { 'B', 30 },{ 'C', 20 }, { 'D', 15 } };
            _noOfSimilarItems = new Dictionary<char, int> { { 'A', 0 }, { 'B', 0 }, { 'C', 0 }, { 'D', 0 } };
            _itemARule = new BusinessRule { Item = 'A', Count = 3, Discount = 20 };
            _itemBRule = new BusinessRule { Item = 'B',  Count = 2, Discount = 15 };
      
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
            _noOfSimilarItems[item]++;
            CalculateTotal(item);
        }

        private void CalculateTotal(char item)
        {
            Total += _prices[item];
            Total -= GetDiscount(item);
        }

        private int GetDiscount(char item)
        {
            if (_itemARule.Item == item && _itemARule.Count == _noOfSimilarItems[item])
                return 20;

            if (_itemBRule.Item == item && _itemBRule.Count == _noOfSimilarItems[item])
                return 15;

            return 0;
        }
    }
}
