using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CourierKata
{
    public class OrderBuilder
    {
        public List<Parcel> Parcels { get; }
        public Dictionary<OrderType, OrderCost> Costs { get; }
        public decimal Cost { get; private set; }

        public OrderBuilder()
        {
            Parcels = new List<Parcel>();
            Costs = new Dictionary<OrderType, OrderCost>();
            // not ideal, tightly coupled. Will do for now. 
            Costs.Add(OrderType.regular, new OrderCost("Regular Shipping", 1));
            Costs.Add(OrderType.speedy, new OrderCost("Speedy Shipping", 2));
        }

        public OrderBuilder AddParcel(Parcel parcel)
        {
            Parcels.Add(parcel);
            foreach (var orderCost in Costs)
            {
                orderCost.Value.Increment(parcel.Price);
            }
            return this;
        }

        public Order FinaliseOrder()
        {
            return new Order(this);
        }

    }
}