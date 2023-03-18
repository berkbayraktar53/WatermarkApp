using Services.Concrete;

namespace Services.Abstract
{
    public interface IRabbitMQPublisherService
    {
        void Publish(ProductImageCreatedEvent productImageCreatedEvent);
    }
}