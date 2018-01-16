using Domain.Commands.Events;
using Domain.Commands.Inputs;
using Domain.Commands.Results;
using Domain.Events.EventSourcing;
using Domain.Models;
using MediatR;
using System;
using System.Threading.Tasks;

namespace Domain.Commands.Handlers
{
    public class BookingCommandHandler : IAsyncRequestHandler<RegisterBookingCommand, Response>
    {
        private readonly IEventBus _eventBus;

        public BookingCommandHandler(IEventBus eventBus)
            => _eventBus = eventBus;

        public async Task<Response> Handle(RegisterBookingCommand message)
        {
            // from message...

            var vehicle = new Vehicle(
                1,
                "AAA-1111",
                "Scania");

            var driver = new Driver(
                2,
                "Fabio",
                "01234567891");          

            var period = new Period(
                3,
                DateTime.Now.AddHours(1),
                DateTime.Now.AddHours(2));

            var booking = new Booking(1, vehicle, driver, period);

            await _eventBus.Publish(new CreatedBookingEvent(booking.Id));

            return new Response(booking.Id, booking.Notifications);
        }
    }
}
