using CleanArchitecture.Application.Features.Videos.Queries.GetVideosList;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CleanArchitecture.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class VideosController : ControllerBase
    {
        private readonly IMediator _mediator;

        public VideosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{username}", Name="GetVideo")]
        [Authorize]
        [ProducesResponseType(typeof(List<VideosVm>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<List<VideosVm>>> GetVideosByUsername(string username)
        {
            var query = new GetVideosListQuery(username);
            var videos = await _mediator.Send(query);
            return Ok(videos);
        }
    }
}
