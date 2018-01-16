using MediatR;

namespace Domain.Events.EventSourcing
{
    public interface IAsyncEventHandler<in TEvent> : IAsyncNotificationHandler<TEvent>
           where TEvent : IEvent
    {
    }
}
