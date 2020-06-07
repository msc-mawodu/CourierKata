using System.Linq;

namespace CourierKata
{
    public abstract class Parcel
    {
        public int Height { get; protected set; }
        public int Length { get; protected set; }
        public int Width { get; protected set; }
        public int Weight { get; protected set; }
        public int SizeLimit { get; protected set; }
        public int WeightLimit { get; protected set; }
        
        public ParcelType ParcelType { get; protected set; }
        public string Description { get; protected set; }
        public decimal Price { get; protected set; }
        public int LargestDimension() => new int[] {Width, Height, Length}.Max();
    }
}