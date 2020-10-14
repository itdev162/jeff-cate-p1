using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Movies;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMediator mediator;
        public MoviesController(IMediator mediator) => this.mediator = mediator;
        public async Task<ActionResult<List<Movie>>> List()
        {
            return await this.mediator.Send(new List.Query());
        }
    }
}