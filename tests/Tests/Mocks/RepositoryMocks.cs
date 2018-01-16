using Domain.Models;
using System;
using System.Collections.Generic;

namespace Tests.Mocks
{
    public class RepositoryMocks
    {
        public static IReadOnlyCollection<Driver> Drivers()
        {
            return new[]
            {
                new Driver(1052, "Fabio", "01236547895"),
                new Driver(1053, "Maria", "98521453789"),
                new Driver(1054, "Pedro", "52893697154")
            };
        }

        public static IReadOnlyCollection<Vehicle> Vehicles()
        {
            return new[]
            {
                new Vehicle(2951, "AAA-1111", "Scania"),
                new Vehicle(2952, "AAA-2222", "Iveco"),
                new Vehicle(2953, "AAA-3333", "Mercedes")
            };
        }

        public static IReadOnlyCollection<Period> Periods()
        {
            return new[]
            {
                new Period(3280, DateTime.Now.AddHours(1),DateTime.Now.AddHours(2)),
                new Period(3281, DateTime.Now.AddHours(3), DateTime.Now.AddHours(4)),
                new Period(3282, DateTime.Now.AddHours(5), DateTime.Now.AddHours(6))
            };
        }
    }
}
