namespace CourierKata.Parcels
{
    public class SmallParcel : ParcelDecorator
    {
        public SmallParcel(Parcel baseParcel) : base(baseParcel)
        {
            Description  = "Small Parcel";
            Price  = 3.0M;
            SizeLimit  = 10; 
            WeightLimit  = 1;
        }
    }
}