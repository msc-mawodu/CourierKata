namespace CourierKata.Parcels
{
    public class HeavyParcel : ParcelDecorator
    {
        private const decimal _overweightCostPerKg = 1.0M;
        private const int _baseHeavyWeight = 50;
        
        public HeavyParcel(Parcel baseParcel, int weight) : base(baseParcel)
        {
            Width = baseParcel.Width;
            Height = baseParcel.Height;
            Length = baseParcel.Length;
            Weight = weight;
            
            Description  = "Heavy Parcel";
            Price  = 50.0M;
            ParcelType = ParcelType.heavy; // for backwards compatibility (refactor out later);
            
            // SizeLimit  = baseParcel.SizeLimit; 
            // WeightLimit  = baseParcel.WeightLimit;

            int overweight = weight - _baseHeavyWeight;
            overweight = overweight < 0 ? 0 : overweight; 
            Price = Price + (_overweightCostPerKg *  overweight);
        }
    }
}