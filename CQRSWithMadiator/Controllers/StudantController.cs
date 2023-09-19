using CQRSWithMadiator.Commands;
using CQRSWithMadiator.queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSWithMadiator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudantController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudantController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public  async Task<IActionResult> GetAllStudants([FromQuery] StudantQuery query)
        {
            var reusult = await _mediator.Send(query); 
            return Ok(reusult);  
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetStudantById([FromQuery] StudanteQueryById query)
        {
            if (query is null)
                return BadRequest("deve informar um Id"); 

            var result = await _mediator.Send(query);
            if (result is null)
                return NotFound($"Não Existe uma conta de Estudante um Id {query.Id} "); 
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateStudantCommand command)
        {
            var result = await _mediator.Send(command);

            return Created("/", result);
        }
    }
}
