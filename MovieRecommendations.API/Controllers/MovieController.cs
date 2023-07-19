using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieRecommendations.API.Models;
using MovieRecommendations.Application.Commands;
using MovieRecommendations.Application.Validators;

namespace MovieRecommendations.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MovieController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateMovie([FromBody] MovieDto dto)
        {
            var cmd = new MovieCreateCommand { Title = dto.Title };

            var queryValidator = new MovieCreateCommandValidator();
            var validationResult = await queryValidator.ValidateAsync(cmd);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var result = await _mediator.Send(cmd);

            return Created($"movies/{result}", result);
            
        }
    }
}
