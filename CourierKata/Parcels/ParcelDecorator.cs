namespace CourierKata.Parcels
{
    public abstract class ParcelDecorator : Parcel
    {
        private Parcel _baseParcel = null;
        protected ParcelDecorator(Parcel baseParcel)
        {
            _baseParcel = baseParcel;
        }

        // public bool isLegall() => new int[] {Width, Height, Length}.Max() < SizeLimit;
    }
}