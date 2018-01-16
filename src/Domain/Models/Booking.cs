using Domain.Common;
using FluentValidator.Validation;

namespace Domain.Models
{
    public class Booking : Entity
    {
        public Booking (int id, Vehicle vehicle, Driver driver, Period period)
        {
            Id = id;
            Vehicle = vehicle;
            Driver = driver;
            Period = period;

            AddNotifications(new ValidationContract()
                .IsNotNull(Vehicle, nameof(Vehicle), "Vehicle is required")
                .IsNotNull(Driver, nameof(Driver), "Driver is required")
                .IsNotNull(Period, nameof(Period), "Period is required"));

            AddNotifications(Vehicle, Driver, Period);
        }
        
        public Vehicle Vehicle { get; private set; }

        public Driver Driver { get; private set; }

        public Period Period { get; private set; }
    }
}
