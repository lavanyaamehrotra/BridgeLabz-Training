using System.Text;
using System.Text.Json;
using FundooNotesApp.ModelLayer.Models;
using RabbitMQ.Client;

namespace FundooNotesApp.BusinessLayer.Helpers
{
    public class RabbitMQPublisher
    {
        private readonly string _hostName;
        private readonly string _queueName;

        public RabbitMQPublisher(string hostName, string queueName)
        {
            _hostName = hostName;
            _queueName = queueName;
        }

        public async Task PublishEmailMessageAsync(EmailQueueMessage message)
        {
            var factory = new ConnectionFactory { HostName = _hostName };
            using var connection = await factory.CreateConnectionAsync();
            using var channel = await connection.CreateChannelAsync();

            await channel.QueueDeclareAsync(queue: _queueName, durable: true, exclusive: false, autoDelete: false, arguments: null);

            string json = JsonSerializer.Serialize(message);
            byte[] body = Encoding.UTF8.GetBytes(json);

            await channel.BasicPublishAsync(exchange: "", routingKey: _queueName, body: body);
        }
    }
}