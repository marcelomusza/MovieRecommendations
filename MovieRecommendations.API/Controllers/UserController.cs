using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieRecommendations.API.Models;
using MovieRecommendations.Application.Commands.Users;
using MovieRecommendations.Application.Queries;
using MovieRecommendations.Application.Validators;

namespace MovieRecommendations.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{userId}/recommended")]
        public async Task<IActionResult> GetRecommendedMovies(int userId)
        {
            var query = new GetRecommendedMoviesQuery(userId);

            var queryValidator = new GetRecommendedMoviesQueryValidator();
            var validationResult = await queryValidator.ValidateAsync(query);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var result = await _mediator.Send(query);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserDto dto)
        {
            var cmd = new UserCreateCommand { Name = dto.Name };

            var queryValidator = new UserCreateCommandValidator();
            var validationResult = await queryValidator.ValidateAsync(cmd);

            if (!validationResult.IsValid)
                return BadRequest(validationResult.Errors);

            var result = await _mediator.Send(cmd);

            return Ok(result);

        }
    }
}
