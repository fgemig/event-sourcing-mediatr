using Domain.Events.EventSourcing;

namespace Domain.Commands.Events
{
    public class CreatedBookingEvent : IEvent
    {
        public CreatedBookingEvent(int id)
            => Id = id;

        public int Id { get; set; }
    }
}
