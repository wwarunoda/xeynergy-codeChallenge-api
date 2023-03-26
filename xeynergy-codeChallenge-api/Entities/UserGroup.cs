namespace xeynergy_codeChallenge_api.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    public class UserGroup
    {
        public UserGroup()
        {
            this.Users = new HashSet<User>();
        }
        [Key]
        public Guid UserGroupId { get; set; }
        public string GroupName { get; set; }

        [ForeignKey("AccessRule")]
        public Guid AccessRuleId { get; set; }
        public virtual AccessRule AccessRule { get; private set; }
        public virtual ICollection<User> Users { get; set; } = new List<User>();
        
    }
}
