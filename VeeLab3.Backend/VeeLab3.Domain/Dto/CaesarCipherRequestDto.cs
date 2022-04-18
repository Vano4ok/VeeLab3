using System.ComponentModel.DataAnnotations;

namespace VeeLab3.Domain.Dto
{
    public class CaesarCipherRequestDto
    {
        [Required]
        public string Str { get; set; } = string.Empty;

        [Range(1, int.MaxValue)]
        public int Key { get; set; }
    }
}
