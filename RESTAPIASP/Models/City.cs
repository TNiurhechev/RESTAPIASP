using System.ComponentModel.DataAnnotations;

namespace RESTAPIASP.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string Name { get; set; } = "";
        public ICollection<Family> Families { get; set; }
    }
}
