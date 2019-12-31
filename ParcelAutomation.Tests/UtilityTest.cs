using ParcelAutomation.Entites;
using ParcelAutomation.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Xunit;
namespace ParcelAutomation.Tests
{
    public class UtilityTest
    {
        [Fact]
        public void Should_Deserialize_ValidXML()
        {
            //Arrange 
            string xmlFile =
                @"<Container><Id>68465468</Id> <ShippingDate>2016-07-22T00:00:00+02:00</ShippingDate><parcels>
                    <Parcel>
                         <Sender>
                           <Name>Klaas</Name>
                           <Address>
                             <Street>Uranusstraat</Street>
                             <HouseNumber>22</HouseNumber>
                             <PostalCode>2402AE</PostalCode>
                             <City>Alphen a/d Rijn</City>
                           </Address>
                           <CcNumber>65465424</CcNumber> 
                         </Sender>
                         <Receipient>
                           <Name>Piet</Name>
                           <Address>
                             <Street>Schenklaan</Street>
                             <HouseNumber>22</HouseNumber>
                             <PostalCode>2497AV</PostalCode>
                             <City>Den Haag</City>
                           </Address>
                         </Receipient>
                         <Weight>0.02</Weight>
                         <Value>500</Value>
                       </Parcel> 
                     </parcels>
                </Container>";
            var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(xmlFile));
            var streamReader = new StreamReader(memoryStream, Encoding.UTF8, true);

            //Act 
            var result = XMLFormatter.Deserialize<Container>(streamReader);

            //Assert
            Assert.Equal(68465468, result.Id);
            Assert.Equal(DateTime.Parse("2016-07-22T00:00:00+02:00"), result.ShippingDate);
            Assert.Equal(0.02, result.Parcels.Parcel.FirstOrDefault().Weight);
            Assert.Equal(500, result.Parcels.Parcel.FirstOrDefault().Value);

            Assert.Single(result.Parcels.Parcel);
            Assert.Equal("Klaas", result.Parcels.Parcel.FirstOrDefault().Sender.Name);
            Assert.Equal("Uranusstraat", result.Parcels.Parcel.FirstOrDefault().Sender.Address.Street); 
            Assert.Equal("22", result.Parcels.Parcel.FirstOrDefault().Sender.Address.HouseNumber); 
            Assert.Equal("2402AE", result.Parcels.Parcel.FirstOrDefault().Sender.Address.PostalCode); 
            Assert.Equal("Alphen a/d Rijn", result.Parcels.Parcel.FirstOrDefault().Sender.Address.City);
            Assert.Equal("65465424", result.Parcels.Parcel.FirstOrDefault().Sender.CcNumber);

            Assert.Equal("Piet", result.Parcels.Parcel.FirstOrDefault().Receipient.Name);
            Assert.Equal("Schenklaan", result.Parcels.Parcel.FirstOrDefault().Receipient.Address.Street);
            Assert.Equal("22", result.Parcels.Parcel.FirstOrDefault().Receipient.Address.HouseNumber);
            Assert.Equal("2497AV", result.Parcels.Parcel.FirstOrDefault().Receipient.Address.PostalCode);
            Assert.Equal("Den Haag", result.Parcels.Parcel.FirstOrDefault().Receipient.Address.City);

        }
    }
}
