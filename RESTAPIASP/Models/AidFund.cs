using System.ComponentModel.DataAnnotations;

namespace RESTAPIASP.Models
{
    public class AidFund
    {
        [Key]
        public int FundId { get; set; }
        public string Name { get; set; } = "";
        public ICollection<Family> Families { get; set; }
    }
}
