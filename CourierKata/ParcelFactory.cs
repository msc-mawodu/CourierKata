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
            int largestDimension = new int[] {width, height, length}.Max();
            Parcel baseParcel = new BaseParcel();

            if (largestDimension < 10)
            {
                parcelType = ParcelType.small;
                
            } else if (largestDimension < 50)
            {
                parcelType = ParcelType.medium;
                
            } else if (largestDimension < 100)
            {
                parcelType = ParcelType.large;
            }
            else
            {
                parcelType = ParcelType.extra_large;
                
            }
            
            return new Parcel(height, length, width, parcelType, _parcelPricing[parcelType]);

        }
    }
}