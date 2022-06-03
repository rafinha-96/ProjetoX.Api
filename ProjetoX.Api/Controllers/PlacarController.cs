using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoX.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacarController : ControllerBase
    {
        private readonly IMediator _mediator;
        public PlacarController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}