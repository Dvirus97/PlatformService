using System.ComponentModel.DataAnnotations;

namespace PlatformService.Dtos
{
    public class PlatformCreateDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        [Required]
        [MaxLength(50)]
        public string Publisher { get; set; } = null!;
        [Required]
        [MaxLength(50)]
        public string Cost { get; set; } = null!;
    }
}
