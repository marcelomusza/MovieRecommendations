using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieRecommendations.Application.Validators;
using MovieRecommendations.Application.Queries;

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

        [HttpGet("users/{userId}/recommended")]
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
    }
}
