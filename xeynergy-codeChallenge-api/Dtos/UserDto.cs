using System;

namespace xeynergy_codeChallenge_api.Dtos
{
    public class UserDto: PersonDto
    {
        public Guid AttachedCustomer { get; set; }
    }
}
