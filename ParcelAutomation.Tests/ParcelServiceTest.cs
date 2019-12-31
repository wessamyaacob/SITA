using ParcelAutomation.Entites;
using System;
using Xunit;

namespace ParcelAutomation.Tests
{
    public class ParcelServiceTest : IClassFixture<TestFixture>
    {
        private readonly TestFixture _fixture;
        public ParcelServiceTest(TestFixture testFixture)
        {
            _fixture = testFixture;
        }

        [Fact]
        public void Should_Return_MailDepartement_When_Parcel_Wegiht_Up_To_1kg()
        {
            //Arrange 
            var parcel = new Parcel();
            parcel.Weight = 0.5;

            //Act 
            var result = _fixture.service.HandleParcel(parcel);

            //Assert
            Assert.Equal("MailDepartement", result);
        }

        [Fact]
        public void Should_Return_MailDepartement_When_Parcel_Wegiht_Equal_1kg()
        {
            //Arrange
            var parcel = new Parcel();
            parcel.Weight = 1;

            //Act 
            var result = _fixture.service.HandleParcel(parcel);

            //Assert
            Assert.Equal("MailDepartement", result);
        }


        [Fact]
        public void Should_Return_RegularDepartement_When_Parcel_Wegiht_Up_To_10kg()
        {
            //Arrange
            var parcel = new Parcel();
            parcel.Weight = 9;

            //Act 
            var result = _fixture.service.HandleParcel(parcel);

            //Assert
            Assert.Equal("RegularDepartement", result);
        }

        [Fact]
        public void Should_Return_RegularDepartement_When_Parcel_Wegiht_Equal_10kg()
        {
            //Arrange
            var parcel = new Parcel();
            parcel.Weight = 10;

            //Act 
            var result = _fixture.service.HandleParcel(parcel);

            //Assert
            Assert.Equal("RegularDepartement", result);
        }

        [Fact]
        public void Should_Return_HeavyDepartement_When_Parcel_Wegiht_Over_10kg()
        {
            //Arrange
            var parcel = new Parcel();
            parcel.Weight = 11;

            //Act 
            var result = _fixture.service.HandleParcel(parcel);

            //Assert
            Assert.Equal("HeavyDepartement", result);
        }

        [Fact]
        public void Should_Return_InsuranceDepartement_When_Parcel_Value_Over_1000EUR()
        {
            //Arrange
            var parcel = new Parcel();
            parcel.Weight = 10;
            parcel.Value = 1100;

            //Act 
            var result = _fixture.service.HandleParcel(parcel);

            //Assert 
            Assert.Contains("InsuranceDepartement", result);
            Assert.Contains("RegularDepartement", result);
        }

        [Fact]
        public void Should_ThrowArgumentNullException_When_Parcel_IsNull()
        {
            //Assert 
            Assert.Throws<ArgumentNullException>(() => _fixture.service.HandleParcel(null));
        }

        [Fact]
        public void Should_ArgumentException_When_Parcel_Weight_Less_Than_Zero()
        {
            //Arrange
            var parcel = new Parcel();
            parcel.Weight = -10;

            //Assert 
            Assert.Throws<ArgumentException>(() => _fixture.service.HandleParcel(parcel));
        }
    }
}
