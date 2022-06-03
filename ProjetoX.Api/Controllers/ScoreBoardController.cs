using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoX.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScoreBoardController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ScoreBoardController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}