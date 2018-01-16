using Domain.Enumerations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Tests.Mocks;

namespace Tests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public async Task ShoudCreateANewValidBooking()
        {
            var command = BookingMocks.CreateCommand();
            var booking = BookingMocks.CreateNewBookingFrom(command);
            var response = ResponseMocks.CreateResponseFrom(booking);

            new MediatrMocks().MockMediatr(response);

            var result = await response;

            Assert.AreEqual(result.Status, ResponseStatus.SUCCESS);
            Assert.AreEqual(result.Id, 1);
        }
    }
}
