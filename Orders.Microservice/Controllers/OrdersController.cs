using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Orders.Microservice.Models;
using SharedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orders.Microservice.Controllers
{
    [ApiController]
    [Route("api/order")]
    public class OrdersController : ControllerBase
    {     
        private readonly ILogger<OrdersController> _logger;
        private readonly IBus _busService;

        public OrdersController(ILogger<OrdersController> logger, IBus busService)
        {
            _logger = logger;
            _busService = busService;
        }

        [HttpPost]
        public async Task<string> NewOrder(Order order)
        {
            if (order != null)
            {
                _logger.LogInformation("processing ... and sending the order to the queue ");
                Uri uri = new Uri("queue:"+RabbitMqConsts.EndPoint);
                var endpoint = await _busService.GetSendEndpoint(uri);
                await endpoint.Send<OrderDelivery>(new {
                    orderId=order.orderId,
                    customerId = order.customerId,
                    productId = order.productId,
                    quanty = order.quanty
                });
                return "true";
            }
            _logger.LogInformation("order is null");
            return "false";
        }
    }
}
