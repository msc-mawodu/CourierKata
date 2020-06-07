using System;
using CourierKata;
using NUnit.Framework;

namespace CourierKataTests
{
    public class OrderBuilderTest
    {
        [Test]
        public void ShouldBulidOrderCorrectly()
        {
            // fixme: this is not ideal, as depends on parcel factory - decouple later.  
            var small = ParcelFactory.CreteParcel(9, 9, 9);
            var medium = ParcelFactory.CreteParcel(10, 9, 9);
            var large = ParcelFactory.CreteParcel(2, 50,15);
            var xLarge = ParcelFactory.CreteParcel(100, 50,99);
            
            Decimal expectedTotal = 51.00M;
            Order order = new OrderBuilder()
                .AddParcel(small)
                .AddParcel(medium)
                .AddParcel(large)
                .AddParcel(xLarge)
                .FinaliseOrder();
            
            Assert.AreEqual(expectedTotal, order.TotalCost);
        }
    }
}