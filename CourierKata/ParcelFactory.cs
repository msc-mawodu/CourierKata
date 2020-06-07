using System;
using System.Collections.Generic;
using System.Linq;

namespace CourierKata
{
    public class ParcelFactory
    {
        private static Dictionary<ParcelType, Decimal> _parcelPricing = new Dictionary<ParcelType, Decimal>
        {
            {ParcelType.small, 3.00M},
            {ParcelType.medium, 8.00M},
            {ParcelType.large, 15.00M},
            {ParcelType.extra_large, 25.00M}
        };

        public static Parcel CreteParcel(int width, int height, int length)
        {
            int largestDimension = new int[] {width, height, length}.Max();
            ParcelType parcelType;

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