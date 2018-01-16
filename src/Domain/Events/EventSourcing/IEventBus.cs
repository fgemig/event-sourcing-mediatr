using System.Threading.Tasks;

namespace Domain.Events.EventSourcing
{
    public interface IEventBus
    {
        Task Publish<TEvent>(TEvent @event) where TEvent : IEvent;
    }
}
