namespace CourierKata.Parcels
{
    public class WeightedParcel : ParcelDecorator
    {
        private new const decimal _overweightCostPerKg = 2.0M;
        
        public WeightedParcel(Parcel baseParcel, int weight) : base(baseParcel)
        {
            Width = baseParcel.Width;
            Height = baseParcel.Height;
            Length = baseParcel.Length;
            Description = baseParcel.Description;
            ParcelType = baseParcel.ParcelType;
            SizeLimit  = baseParcel.SizeLimit; 
            Weight = weight;
            WeightLimit  = baseParcel.WeightLimit;

            int overweight = weight - baseParcel.WeightLimit;
            overweight = overweight < 0 ? 0 : overweight; 
            Price = baseParcel.Price + (_overweightCostPerKg *  overweight);
        }
    }
}