using System.Collections.Generic;

namespace CourierKata
{
    public class Order
    {
        private List<Parcel> Parcels { get; }
        public decimal TotalCost { get; }

        public Order(OrderBuilder orderBuilder)
        {
            Parcels = orderBuilder.Parcels;
            TotalCost = orderBuilder.Cost;
        }
    }
}