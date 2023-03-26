using System;

namespace xeynergy_codeChallenge_api.Dtos
{
    public class PersonDto
    {
        public Guid Id { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string EmailAddress { get; init; }
    }
}
