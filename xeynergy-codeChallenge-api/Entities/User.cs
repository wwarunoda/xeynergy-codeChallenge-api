using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace xeynergy_codeChallenge_api.Entities
{
    public class User: Person
    {
        public Guid AttachedCustomer { get; set; }
        [ForeignKey("UserGroup")]
        public Guid? UserGroupId { get; set; }
        public virtual UserGroup UserGroup { get; set; }
    }
}
