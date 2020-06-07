using CourierKata;
using NUnit.Framework;

namespace CourierKataTests
{
    public class ParcelFactoryTest
    {
        [Test]
        public void ShouldCorrectlyCreateRegularParcels()
        {
            var small = ParcelFactory.CreteParcel(9, 9, 9);
            var medium = ParcelFactory.CreteParcel(10, 9, 9);
            var medium2 = ParcelFactory.CreteParcel(2, 10,15);
            var large = ParcelFactory.CreteParcel(2, 50,15);
            var large2 = ParcelFactory.CreteParcel(2, 50,99);
            var xLarge = ParcelFactory.CreteParcel(100, 50,99);

            Assert.IsTrue(ParcelType.small == small.ParcelType);
            Assert.IsTrue(ParcelType.medium == medium.ParcelType);
            Assert.IsTrue(ParcelType.medium == medium2.ParcelType);
            Assert.IsTrue(ParcelType.large == large.ParcelType);
            Assert.IsTrue(ParcelType.large == large2.ParcelType);
            Assert.IsTrue(ParcelType.extra_large == xLarge.ParcelType);
        }
        
        [Test]
        [Ignore("Not yet handled / implemented")]
        public void ShouldCorrectlyHandleAttemptsToCreateImpossibleParcels()
        {
            Parcel thinLetter = ParcelFactory.CreteParcel(0, 10, 10);
            Parcel negativeDimension = ParcelFactory.CreteParcel(-1, 10, 100);
        }
    }
}