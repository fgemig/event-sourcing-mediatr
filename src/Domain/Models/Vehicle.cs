using Domain.Common;
using FluentValidator.Validation;

namespace Domain.Models
{
    public class Vehicle : Entity
    {
        public Vehicle(int id, string licensePlate, string manufacturer)
        {
            Id = id;
            LicensePlate = licensePlate;
            Manufacturer = manufacturer;

            AddNotifications(new ValidationContract()
                .HasLen(LicensePlate, 8, nameof(LicensePlate), "License Plate is invalid"));
        }
        
        public string LicensePlate { get; private set; }

        public string Manufacturer { get; private set; }

        public override string ToString()
        {
            return $"{Manufacturer}, placa: {LicensePlate}";
        }
    }
}
