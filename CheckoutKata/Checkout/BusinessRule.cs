namespace Checkout
{
    public class BusinessRule : IBusinessRule
    {
        public char Item { get; set; }
        public int Discount { get; set; }
        public int Count { get; set; }

       
    }
}