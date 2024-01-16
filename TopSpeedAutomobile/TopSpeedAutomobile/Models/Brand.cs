using System.ComponentModel.DataAnnotations;

namespace TopSpeedAutomobile.Models
{
    public class Brand
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int EstablishedYear { get; set; }
        public string BrandLogs { get; set; }
    }
}
