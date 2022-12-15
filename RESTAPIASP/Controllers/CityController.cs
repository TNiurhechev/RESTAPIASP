using Microsoft.AspNetCore.Mvc;
using RESTAPIASP.Interfaces;
using RESTAPIASP.Models;
using RESTAPIASP.Repository;

namespace RESTAPIASP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : Controller
    {
        private readonly ICityRepository _cityRepository;
        public CityController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        [HttpGet]
        [ProducesResponseType(200,Type = typeof(IEnumerable<City>))]
        public IActionResult GetCities()
        {
            var cities = _cityRepository.GetCities();
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(cities);
        }
        [HttpGet("api/[controller]/GetById")]
        [ProducesResponseType(200, Type = typeof(City))]
        public IActionResult GetCity(int cityId)
        {
            var city = _cityRepository.GetCity(cityId);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(city);
        }
    }
}
