using System;
using System.ComponentModel.DataAnnotations;

namespace xeynergy_codeChallenge_api.Models
{
    public class PersonModel
    {
        public Guid Id { get; init; }
        [Required]
        [MaxLength(200)]
        public string FirstName { get; init; }
        [Required]
        [MaxLength(200)]
        public string LastName { get; init; }
        [MaxLength(100)]
        public string EmailAddress { get; init; }
    }
}
