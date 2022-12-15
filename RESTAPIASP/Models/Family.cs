using System.ComponentModel.DataAnnotations;

namespace RESTAPIASP.Models
{
    public class Family
    {
        [Key]
        public int FamilyId { get; set; }
        public string LastName { get; set; } = "";
        public int FundId { get; set; }
        public int RecieverId { get; set; }
        public int MembersCount { get; set; }
        public int CityId { get; set; }
    }
}
