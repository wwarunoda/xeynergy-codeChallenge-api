using System.ComponentModel.DataAnnotations;

namespace xeynergy_codeChallenge_api.Models
{
    public class AdminModel: PersonModel
    {
        [Required]
        [MaxLength(200)]
        public string Privilege { get; init; }
    }
}
