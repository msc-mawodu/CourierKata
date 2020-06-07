using System;

namespace CourierKata
{
    // fixme: I'm not happy with that. Overcomplicated. This might as well simply be a decimal property in Order.  
    public class OrderCost
    {
        public decimal Total { get; private set; }
        public string label { get; }
        private int multiplier { get; }

        public OrderCost(string label, int multiplier)
        {
            Total = 0.0M;
            this.label = label;
            this.multiplier = multiplier;
        }

        public void Increment(Decimal baseAmount)
        {
            Total += multiplier * baseAmount;
        } 
    }

    public enum OrderType
    {
        regular, 
        speedy
    }
}