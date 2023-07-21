using MediatR;

namespace MovieRecommendations.Application.Commands.Users
{
    public class UserCreateCommand : IRequest<int>
    {
        public string Name { get; set; }
    }
}
