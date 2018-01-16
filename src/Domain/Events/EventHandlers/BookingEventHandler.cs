using Domain.Commands.Events;
using Domain.Events.EventSourcing;
using System.Net.Http;
using System.Threading.Tasks;

namespace Domain.Events.EventHandlers
{
    public class BookingEventHandler : IAsyncEventHandler<CreatedBookingEvent>
    {
        public Task Handle(CreatedBookingEvent model)
        {
            HttpClient _httpClient = new HttpClient();

            return Task.Factory.StartNew(() =>
            {
                // do something...
                _httpClient.GetStringAsync("https://www.google.com.br/");
            });
        }
    }
}
