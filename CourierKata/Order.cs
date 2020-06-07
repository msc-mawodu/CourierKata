using System.Collections.Generic;

namespace CourierKata
{
    public class Order
    {
        private List<Parcel> _parcels;
        public decimal TotalCost { get; }
    }
}