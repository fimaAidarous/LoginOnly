using System.ComponentModel.DataAnnotations;

namespace ProjectWithLogin.Models.DTO
{
    public class AssetMovement
    {
        [Key]
        public int Id { get; set; }
        [Required]

        public int AssetId { get; set; }

        public Asset? Asset { get; set; }
        public string? FromLocation { get; set; }

        public string? ToLocation { get; set; }

        public DateTime MoveDate { get; set; }

        public string? MoveReason { get; set; }

        public string? ResponsibleParty { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
