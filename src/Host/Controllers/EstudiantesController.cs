using ApplicationCore.Commands;
using ApplicationCore.Interfaces;
using ApplicationCore.Wrappers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Host.Controllers
{
    [Route("api/estudiantes")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        private readonly IEstudiantesService _service;
        private readonly IMediator _mediator;
        
        public EstudiantesController(IEstudiantesService service, IMediator mediator)
        {
            _service = service;
            _mediator = mediator;
        }
        
        [HttpGet("get")]
        public async Task<IActionResult> GetEstudiantes()
        {
            var result = await _service.GetEstudiantes();
            return Ok(result);
        }
        
        [HttpPost("create")]
        public async Task<ActionResult<Response<int>>> CreateEstudiante(EstudianteCreateCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<Response<int>>> DeleteEstudiante(int id)
        {
            var result = await _mediator.Send(new EstudianteDeleteCommand { Id = id });
            return Ok(result);
        }
        
        [HttpPut("{id}")]
        public async Task<ActionResult<Response<int>>> UpdateEstudiante(int id, EstudianteUpdateCommand command)
        {
            if (id != command.Id)
            {
                return BadRequest("El Id en la  coincide.");
            }

            var result = await _mediator.Send(command);
            return Ok(result);
        }
        
        
    }
}
