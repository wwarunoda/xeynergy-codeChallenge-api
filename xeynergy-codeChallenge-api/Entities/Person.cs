using System;
using System.ComponentModel.DataAnnotations;

namespace xeynergy_codeChallenge_api.Entities
{
    public abstract class Person
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string EmailAddress { get; init; }
    }
}
