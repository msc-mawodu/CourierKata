using System.Linq;

namespace CourierKata.Parcels
{
    public class BaseParcel : Parcel
    {
        public BaseParcel(int height, int length, int width) : base()
        {
            Height = height;
            Length = length;
            Width = width;
        }
    }
}