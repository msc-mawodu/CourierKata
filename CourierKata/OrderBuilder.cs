using System.Collections.Generic;

namespace CourierKata
{
    public class OrderBuilder
    {
        public List<Parcel> Parcels { get; }
        public decimal Cost { get; private set; }

        public OrderBuilder()
        {
            Parcels = new List<Parcel>();
            Cost = 0;
        }

        public OrderBuilder AddParcel(Parcel parcel)
        {
            Parcels.Add(parcel);
            Cost += parcel.Price;
            return this;
        }

        public Order FinaliseOrder()
        {
            return new Order(this);
        }

    }
}