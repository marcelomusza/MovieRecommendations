using MediatR;
using MovieRecommendations.Domain.Entities;
using MovieRecommendations.Domain.Interfaces;

namespace MovieRecommendations.Application.Commands.Users
{
    internal class UserCreateCommandHandler : IRequestHandler<UserCreateCommand, int>
    {
        private readonly IUserRepository _userRepository;

        public UserCreateCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<int> Handle(UserCreateCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                Name = request.Name
            };

            await _userRepository.AddAsync(user);
            await _userRepository.SaveChangesAsync();


            return user.Id;
        }
    }
}
