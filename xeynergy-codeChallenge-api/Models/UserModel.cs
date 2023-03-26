using System;

namespace xeynergy_codeChallenge_api.Models
{
    public class UserModel: PersonModel
    {
        public Guid AttachedCustomer { get; set; }
    }
}
