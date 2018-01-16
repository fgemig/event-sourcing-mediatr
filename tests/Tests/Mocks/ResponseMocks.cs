using Domain.Commands.Results;
using Domain.Common;
using System.Threading.Tasks;

namespace Tests.Mocks
{
    public class ResponseMocks
    {
        public static Task<Response> CreateResponseFrom(Entity entity)
        {
            return Task.Factory.StartNew(()
                => new Response(entity.Id, entity.Notifications));
        }
    }
}
