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
            var order = buildGenericOrder();
            var expectedTotal = 51.0M;
            Assert.AreEqual(expectedTotal, order.RegularCost);
        }
        
        [Test]
        public void ShouldBulidOrderWithSpeedyDeliveryCostCorrectly()
        {
            var order = buildGenericOrder();
            var expectedTotal = 102.0M;
            Assert.AreEqual(expectedTotal, order.Costs[OrderType.speedy].Total);
        }

        private Order buildGenericOrder()
        {
            // fixme: this is not ideal, as depends on parcel factory - decouple later.  
            var small = ParcelFactory.CreteParcel(9, 9, 9);
            var medium = ParcelFactory.CreteParcel(10, 9, 9);
            var large = ParcelFactory.CreteParcel(2, 50,15);
            var xLarge = ParcelFactory.CreteParcel(100, 50,99);
            
            
            return new OrderBuilder()
                .AddParcel(small)
                .AddParcel(medium)
                .AddParcel(large)
                .AddParcel(xLarge)
                .FinaliseOrder();
        }
    }
}