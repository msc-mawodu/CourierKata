using System;
using System.Collections.Generic;
using System.Linq;
using CourierKata.Parcels;

namespace CourierKata
{
    public class ParcelFactory
    {
        public static Parcel CreteParcel(int width, int height, int length)
        {
            Parcel parcel = new BaseParcel(height, length, width);
            var largestDimension = parcel.LargestDimension();

            if (largestDimension < SmallParcel.AllowedSize)
            {
                parcel = new SmallParcel(parcel);
                
            } else if (largestDimension < MediumParcel.AllowedSize)
            {
                parcel = new MediumParcel(parcel);
                
            } else if (largestDimension < LargeParcel.AllowedSize)
            {
                parcel = new LargeParcel(parcel);
            }
            else
            {
                parcel = new ExtraLargeParcel(parcel);
            }

            return parcel;
        }
    }
}