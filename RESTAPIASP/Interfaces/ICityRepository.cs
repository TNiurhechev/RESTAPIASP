using RESTAPIASP.Models;

namespace RESTAPIASP.Interfaces
{
    public interface ICityRepository
    {
        public ICollection<City> GetCities();
        public City GetCity(int cityId);
    }
}
