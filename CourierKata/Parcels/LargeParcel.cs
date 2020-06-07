namespace CourierKata.Parcels
{
    public class LargeParcel : ParcelDecorator
    {
        public const int AllowedSize = 100;
        public LargeParcel(Parcel baseParcel) : base(baseParcel)
        {
            Description = "Large Parcel";
            Price  = 15.0M;
            ParcelType = ParcelType.large; // for backwards compatibility (refactor out later);
            SizeLimit = AllowedSize; 
            WeightLimit = 6;
        }
    }
}