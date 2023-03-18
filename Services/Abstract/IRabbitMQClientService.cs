using System;
using RabbitMQ.Client;

namespace Services.Abstract
{
    public interface IRabbitMQClientService
    {
        IModel Connect();
    }
}