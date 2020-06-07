namespace CourierKata.Parcels
{
    public abstract class ParcelDecorator : Parcel
    {
        private Parcel _baseParcel = null;
        protected ParcelDecorator(Parcel baseParcel)
        {
            Height = baseParcel.Height;
            Width = baseParcel.Width;
            Length = baseParcel.Length;
            _baseParcel = baseParcel;
        }
    }
}