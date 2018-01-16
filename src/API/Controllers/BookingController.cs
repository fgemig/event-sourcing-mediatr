using System.Threading.Tasks;
using Domain.Commands.Inputs;
using Domain.Commands.Results;
using Domain.Enumerations;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    public class BookingController : Controller
    {
        private readonly IMediator _mediatR;

        public BookingController(IMediator mediatR)
        {
            _mediatR = mediatR;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RegisterBookingCommand command)
        {
            if (command == null)
                return BadRequest();

            var booking = await _mediatR.Send(command);

            return Result(booking);
        }

        public IActionResult Result(Response response)
        {
            if (response.Status == ResponseStatus.SUCCESS)
            {
                return Ok(new
                {
                    id = response.Id,
                    status = response.Status.ToString()
                });
            }
            else
            {
                return BadRequest(new
                {
                    status = response.Status.ToString(),
                    notificacoes = response.Notifications
                });
            }
        }
    }
}
