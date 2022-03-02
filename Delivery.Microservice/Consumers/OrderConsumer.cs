using MassTransit;
using Microsoft.Extensions.Logging;
using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Microservice.Consumers
{
    public class OrderConsumer : IConsumer<OrderDelivery>
    {
        private readonly ILogger logger;

        public OrderConsumer(ILogger logger)
        {
            this.logger = logger;
        }
        public async Task Consume(ConsumeContext<OrderDelivery> context)
        {
            await Task.Run(() => {
                
                var objectConsumed = context.Message;
                logger.LogInformation("order received from message queue");
            });
        }
    }
}
