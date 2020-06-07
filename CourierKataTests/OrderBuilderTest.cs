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
        
        [Test]
        public void ShouldBulidOrderWithSpeedyDeliveryAndWeightedCostCorrectly()
        {
            var order = buildGenericWeightedOrder();
            var expectedRegularTotal = 59.0M;
            var expectedSpeedyTotal = 118.0M;
            Assert.AreEqual(expectedRegularTotal, order.Costs[OrderType.regular].Total);
            Assert.AreEqual(expectedSpeedyTotal, order.Costs[OrderType.speedy].Total);
        }

        private Order buildGenericOrder()
        {
            // fixme: this is not ideal, as depends on parcel factory - decouple later.  
            var small = ParcelFactory.CreteSizedParcel(9, 9, 9);
            var medium = ParcelFactory.CreteSizedParcel(10, 9, 9);
            var large = ParcelFactory.CreteSizedParcel(2, 50,15);
            var xLarge = ParcelFactory.CreteSizedParcel(100, 50,99);
            
            
            return new OrderBuilder()
                .AddParcel(small)
                .AddParcel(medium)
                .AddParcel(large)
                .AddParcel(xLarge)
                .FinaliseOrder();
        }
        
        private Order buildGenericWeightedOrder()
        {
            // fixme: this is not ideal, as depends on parcel factory - decouple later.  
            var small = ParcelFactory.CreateWeightedParcel(9, 9, 9, 2);
            var medium = ParcelFactory.CreateWeightedParcel(10, 9, 9, 4);
            var large = ParcelFactory.CreateWeightedParcel(2, 50,15, 7);
            var xLarge = ParcelFactory.CreateWeightedParcel(100, 50,99, 11);
            
            return new OrderBuilder()
                .AddParcel(small)
                .AddParcel(medium)
                .AddParcel(large)
                .AddParcel(xLarge)
                .FinaliseOrder();
        }
    }
}