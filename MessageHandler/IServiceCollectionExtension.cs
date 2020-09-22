using Microsoft.Extensions.DependencyInjection;
using Services;

namespace MessageHandler
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddMessageHandler(this IServiceCollection services)
        {
            services.AddTransient<ICreateMessage, CreateMessage>();
            return services;
        }
    }
}