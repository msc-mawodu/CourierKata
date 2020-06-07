using System.Collections.Generic;

namespace CourierKata
{
    public class Order
    {
        private List<Parcel> Parcels { get; }
        public decimal RegularCost { get; }
        public Dictionary<OrderType, OrderCost> Costs { get; }

        public Order(OrderBuilder orderBuilder)
        {
            Parcels = orderBuilder.Parcels;
            Costs = orderBuilder.Costs;
            RegularCost = Costs[OrderType.regular].Total;
        }
    }
}