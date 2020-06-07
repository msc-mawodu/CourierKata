namespace CourierKata.Parcels
{
    public class ExtraLargeParcel : ParcelDecorator
    {
        public ExtraLargeParcel(Parcel baseParcel) : base(baseParcel)
        {
            Description  = "Extra Large Parcel";
            Price = 25.0M;
            ParcelType = ParcelType.extra_large; // for backwards compatibility (refactor out later);
            // SizeLimit  = none...; 
            WeightLimit  = 10;
        }
    }
}