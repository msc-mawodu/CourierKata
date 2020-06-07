namespace CourierKata.Parcels
{
    public class WeightedParcel : ParcelDecorator
    {
        private new const decimal _overweightCostPerKg = 2.0M;
        
        public WeightedParcel(Parcel baseParcel, int weight) : base(baseParcel)
        {
            Weight = weight;
            int overweight = weight - baseParcel.WeightLimit;
            Price = baseParcel.Price + _overweightCostPerKg *  overweight;
        }
    }
}