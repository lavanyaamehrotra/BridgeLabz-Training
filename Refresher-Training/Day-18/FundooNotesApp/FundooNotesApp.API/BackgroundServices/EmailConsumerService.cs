using System.Text;
using System.Text.Json;
using FundooNotesApp.BusinessLayer.Helpers;
using FundooNotesApp.ModelLayer.Models;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace FundooNotesApp.API.BackgroundServices
{
    public class EmailConsumerService : BackgroundService
    {
        private readonly EmailSender _emailSender;
        private readonly string _hostName;
        private readonly string _queueName;

        public EmailConsumerService(EmailSender emailSender, IConfiguration config)
        {
            _emailSender = emailSender;
            _hostName = config["RabbitMQSettings:HostName"]!;
            _queueName = config["RabbitMQSettings:QueueName"]!;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var factory = new ConnectionFactory { HostName = _hostName };
            var connection = await factory.CreateConnectionAsync(stoppingToken);
            var channel = await connection.CreateChannelAsync(cancellationToken: stoppingToken);

            await channel.QueueDeclareAsync(queue: _queueName, durable: true, exclusive: false, autoDelete: false, arguments: null, cancellationToken: stoppingToken);

            var consumer = new AsyncEventingBasicConsumer(channel);
            consumer.ReceivedAsync += async (model, ea) =>
            {
                byte[] body = ea.Body.ToArray();
                string json = Encoding.UTF8.GetString(body);
                var message = JsonSerializer.Deserialize<EmailQueueMessage>(json);

                if (message != null)
                {
                    _emailSender.SendReminderEmail(message.ToEmail, message.Subject, message.NoteTitle, message.NoteDescription);
                }

                await channel.BasicAckAsync(deliveryTag: ea.DeliveryTag, multiple: false);
            };

            await channel.BasicConsumeAsync(queue: _queueName, autoAck: false, consumer: consumer, cancellationToken: stoppingToken);

            // keep this background service alive until the app shuts down
            await Task.Delay(Timeout.Infinite, stoppingToken);
        }
    }
}