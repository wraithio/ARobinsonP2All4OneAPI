using ARobinsonP2All4OneAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ARobinsonP2All4OneAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly RestaurantServices _restaurantServices;
        
        public RestaurantController(RestaurantServices restaurantServices)
        {
            _restaurantServices = restaurantServices;
        }

        [HttpGet]
        [Route ("goRestaurant/{genre}")]
        public string GoRestaurant(string genre)
        {
            return _restaurantServices.GoRestaurant(genre);
        }
    }
}