using CleanArchitecture.Application.Features.Streamers.Commands;
using CleanArchitecture.Application.Features.Streamers.Commands.DeleteStreamer;
using CleanArchitecture.Application.Features.Streamers.Commands.UpdateStreamer;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StreamersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StreamersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "CreateStreamer")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateStreamer([FromBody] CreateStreamerCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPut(Name = "UpdateStreamer")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateStreamer([FromBody] UpdateStreamerCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }

        [HttpDelete("{id:int}", Name = "DeleteStreamer")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteStreamer(int id)
        {
            var command = new DeleteStreamerCommand { Id = id };

            await _mediator.Send(command);

            return NoContent();
        }
    }
}
