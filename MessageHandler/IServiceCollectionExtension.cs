using Microsoft.Extensions.DependencyInjection;
using MessageHandler.Services;
using RabbitMQ.Client.Core.DependencyInjection;
using Microsoft.Extensions.Configuration;
// using RabbitMq.Client;

namespace MessageHandler
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddMessageHandler(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<ICreateMessage, CreateMessage>();
            services.AddRabbitMqClient(configuration.GetSection("rabbitmq"));
            // services.AddRabbitMqClient();
            return services;
        }
    }
}