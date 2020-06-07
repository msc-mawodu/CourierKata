using CourierKata;
using CourierKata.Parcels;
using NUnit.Framework;

namespace CourierKataTests
{
    public class ParcelFactoryTest
    {
        [Test]
        public void ShouldCorrectlyCreateRegularParcels()
        {
            var small = ParcelFactory.CreteSizedParcel(9, 9, 9);
            var medium = ParcelFactory.CreteSizedParcel(10, 9, 9);
            var medium2 = ParcelFactory.CreteSizedParcel(2, 10,15);
            var large = ParcelFactory.CreteSizedParcel(2, 50,15);
            var large2 = ParcelFactory.CreteSizedParcel(2, 50,99);
            var xLarge = ParcelFactory.CreteSizedParcel(100, 50,99);

            Assert.IsTrue(ParcelType.small == small.ParcelType);
            Assert.IsTrue(small is SmallParcel);
            Assert.AreEqual(9,  small.Width);
            Assert.AreEqual(9,  small.Height);
            Assert.AreEqual(9,  small.Length);
            
            Assert.IsTrue(ParcelType.medium == medium.ParcelType);
            Assert.IsTrue(medium is MediumParcel);
            Assert.IsTrue(ParcelType.medium == medium2.ParcelType);
            Assert.IsTrue(ParcelType.large == large.ParcelType);
            Assert.IsTrue(large is LargeParcel);
            Assert.IsTrue(ParcelType.large == large2.ParcelType);
            Assert.IsTrue(ParcelType.extra_large == xLarge.ParcelType);
        }
        
        [Test]
        public void ShouldCorrectlyCreateWeightedParcels()
        {
            var small = ParcelFactory.CreateWeightedParcel(9, 9, 9, 1);
            var medium = ParcelFactory.CreateWeightedParcel(10, 9, 9, 2);
            var large = ParcelFactory.CreateWeightedParcel(2, 50,15, 2);
            var xLarge = ParcelFactory.CreateWeightedParcel(100, 50,99, 2);

            Assert.IsTrue(ParcelType.small == small.ParcelType);
            Assert.IsTrue(9 == small.Width);
            Assert.IsTrue(9 == small.Length);
            Assert.IsTrue(9 == small.Height);
            Assert.IsTrue(ParcelType.medium == medium.ParcelType);
            Assert.IsTrue(ParcelType.large == large.ParcelType);
            Assert.IsTrue(ParcelType.extra_large == xLarge.ParcelType);
            Assert.IsTrue(small is WeightedParcel);
        }

        [Test]
        public void ShouldCorrectlyCreateHeavyParcel()
        {
            var heavy = ParcelFactory.CreateWeightedParcel(9, 9, 9, 100);
            Assert.IsTrue(heavy is HeavyParcel);
            Assert.AreEqual(100,  heavy.Price);
        }

        [Test]
        [Ignore("Not yet handled / implemented")]
        public void ShouldCorrectlyHandleAttemptsToCreateImpossibleParcels()
        {
            Parcel thinLetter = ParcelFactory.CreteSizedParcel(0, 10, 10);
            Parcel negativeDimension = ParcelFactory.CreteSizedParcel(-1, 10, 100);
        }
    }
}