using Microsoft.Extensions.DependencyInjection;
using MovieRecommendations.Application.Queries;

namespace MovieRecommendations.Application.DependencyInjection
{
    public static class MediatRConfig
    {
        public static IServiceCollection AddMediatRServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetRecommendedMoviesQueriesHandler).Assembly));            

            return services;
        }
    }
}
