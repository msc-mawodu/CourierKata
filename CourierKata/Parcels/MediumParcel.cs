namespace CourierKata.Parcels
{
    public class MediumParcel : ParcelDecorator
    {
        public const int AllowedSize = 50;
        public MediumParcel(Parcel baseParcel) : base(baseParcel)
        {
            Description = "Medium Parcel";
            Price = 8.0M;
            ParcelType = ParcelType.medium; // for backwards compatibility (refactor out later); 
            SizeLimit = AllowedSize; 
            WeightLimit = 3;
        }
    }
}