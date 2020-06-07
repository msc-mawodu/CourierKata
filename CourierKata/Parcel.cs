namespace CourierKata
{
    public class Parcel
    {
        public int Height { get; }
        public int Length { get; }
        public int Width { get; }
        public ParcelType ParcelType { get; }
        public decimal Price { get; }

        public Parcel(int height, int length, int width, ParcelType parcelType, decimal price)
        {
            Height = height;
            Length = length;
            Width = width;
            ParcelType = parcelType;
            Price = price;
        }
    }
}