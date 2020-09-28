using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using MessageHandler;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using RabbitMQ.Client.Core.DependencyInjection.Services;

namespace MessageHandler.Services
{
    public class CreateMessage : ICreateMessage
    {
        private readonly IConfiguration _config;
        private readonly ILogger<CreateMessage> _logger;
        private readonly IQueueService _queueService;
        public CreateMessage(IConfiguration configuration, ILogger<CreateMessage> logger, IQueueService queueService)
        {
            _config = configuration;
            _logger = logger;
            _queueService = queueService;
            _logger.LogInformation("Create Message Ctor Called");
        }
        public void QueueTask(TaskModel model)
        {
            string exchange = _config.GetValue<string>("rabbitmq:exchange");
            string queue = _config.GetValue<string>("rabbitmq:queue");
            _logger.LogInformation(exchange);
            _queueService.SendJson(JsonSerializer.Serialize<TaskModel>(model), exchangeName: exchange, routingKey: "parsing-task");
        }
    }
}