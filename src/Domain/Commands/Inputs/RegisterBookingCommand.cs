using Domain.Commands.Results;
using MediatR;
using System;

namespace Domain.Commands.Inputs
{
    public class RegisterBookingCommand : IRequest<Response>
    {
        public int VehicleId { get; set; }

        public int DriverId { get; set; }

        public int PeriodId { get; set; }
    }
}
