using Domain.Commands.Inputs;
using Domain.Models;
using System.Linq;

namespace Tests.Mocks
{
    public class BookingMocks
    {
        public static RegisterBookingCommand CreateCommand()
        {
            return new RegisterBookingCommand()
            {
                DriverId = 1053,
                VehicleId = 2951,
                PeriodId = 3282
            };
        }

        public static Booking CreateNewBookingFrom(RegisterBookingCommand command)
        {
            var vehicle = RepositoryMocks.Vehicles()
                .Where(c => c.Id == command.VehicleId)
                .FirstOrDefault();

            var driver = RepositoryMocks.Drivers()
                .Where(c => c.Id == command.DriverId)
                .FirstOrDefault();

            var period = RepositoryMocks.Periods()
                .Where(c => c.Id == command.PeriodId)
                .FirstOrDefault();

            return new Booking(1, vehicle, driver, period);
        }
    }
}
