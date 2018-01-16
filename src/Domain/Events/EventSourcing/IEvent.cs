using MediatR;

namespace Domain.Events.EventSourcing
{
    public interface IEvent : INotification
    {
    }
}
