namespace CourierKata.Parcels
{
    public abstract class ParcelDecorator : Parcel
    {
        private Parcel _baseParcel = null;
        protected ParcelDecorator(Parcel baseParcel)
        {
            _baseParcel = baseParcel;
        }
    }
}