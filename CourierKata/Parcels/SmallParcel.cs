namespace CourierKata.Parcels
{
    public class SmallParcel : ParcelDecorator
    {
        public const int AllowedSize = 10;  
        public SmallParcel(Parcel baseParcel) : base(baseParcel)
        {
            Description  = "Small Parcel";
            Price  = 3.0M;
            ParcelType = ParcelType.small; // for backwards compatibility (refactor out later);
            SizeLimit  = AllowedSize; 
            WeightLimit  = 1;
        }
    }
}