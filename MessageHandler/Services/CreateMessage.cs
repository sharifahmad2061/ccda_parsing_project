using System;
using MessageHandler;
using Microsoft.Extensions.Configuration;

namespace MessageHandler.Services
{
    public class CreateMessage : ICreateMessage
    {
        private readonly string _host;
        private readonly string _port;
        private readonly string _exchange;
        private readonly string _queue;
        public CreateMessage(string host, string port, string exchange, string queue)
        {
            _host = host;
            _port = port;
            _exchange = exchange;
            _queue = queue;
        }
        public void QueueTask(TaskModel model)
        {
            string rmqHost = _host;
            string port = _port;
            Console.WriteLine(rmqHost);
            Console.WriteLine(port);
        }
    }
}