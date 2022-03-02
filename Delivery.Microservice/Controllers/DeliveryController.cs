using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Delivery.Microservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryController : ControllerBase
    {
        

        private readonly ILogger<DeliveryController> _logger;

        public DeliveryController(ILogger<DeliveryController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public string getMessage()
        {
            return "welcome to use Delivery api ";
        }
       
    }
}
