using MediatR;
using Moq;
using Moq.Language.Flow;
using System.Threading;
using System.Threading.Tasks;

namespace Tests.Mocks
{
    public class MediatrMocks
    {
        private readonly Mock<IMediator> _fakeMediator;

        public MediatrMocks()
        {
            _fakeMediator = new Mock<IMediator>();
        }

        public IReturnsResult<IMediator> MockMediatr<T>(Task<T> response)
        {
            return _fakeMediator.Setup(m =>
                m.Send(
                    It.IsAny<IRequest<T>>(),
                    It.IsAny<CancellationToken>())
                    ).Returns(response);
        }
    }
}
