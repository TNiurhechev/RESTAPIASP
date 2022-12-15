using Microsoft.EntityFrameworkCore;
using RESTAPIASP.Data;
using RESTAPIASP.Interfaces;
using RESTAPIASP.Models;

namespace RESTAPIASP.Repository
{
    public class CityRepository : ICityRepository
    {
        private readonly DataContext _context;
        public CityRepository(DataContext context) 
        {
            _context = context;
        }

        public ICollection<City> GetCities()
        {
            return _context.Cities.OrderBy(c => c.CityId).ToList();
        }

        public City GetCity(int cityId)
        {
            return _context.Cities
                .FromSqlRaw<City>("SpGetCityById {0}", cityId)
                .ToList()
                .FirstOrDefault();
        }
    }
}
