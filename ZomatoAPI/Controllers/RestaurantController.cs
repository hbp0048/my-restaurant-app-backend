using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ZomatoApi.Core;

namespace ZomatoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantController : ControllerBase
    { 
        private readonly ILogger<RestaurantController> _logger;
        private IRestaurantService _restaurantService;

        public RestaurantController(IRestaurantService restaurantService, ILogger<RestaurantController> logger)
        {
            _restaurantService = restaurantService;
            _logger = logger;
        }

        //[HttpGet]
        //public IEnumerable<Restaurant> Get()
        //{
        //}

        //[HttpGet("SearchByName")]
        //public Restaurant SearchByName([FromQuery]string name)
        //{
        //}
    }
}
