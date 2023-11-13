using System.ComponentModel.DataAnnotations;

namespace ProjectWithLogin.Models.DTO
{
    public class AssetMaintenance
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public int AssetId { get; set; }

        public Asset? Asset { get; set; }

        public DateTime MaintenanceDate { get; set; }

        public string? MaintenanceType { get; set; }

        public string? Description { get; set; }

        public string? Technician { get; set; }

        public int Cost { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
