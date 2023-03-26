using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xeynergy_codeChallenge_api.Entities
{
    public class AccessRule
    {
        public AccessRule()
        {
            this.UserGroups = new HashSet<UserGroup>();
        }
        [Key]
        public Guid AccessRuleId { get; set; }
        public string RuleName { get; set; }
        public bool Permission { get; set; }
        public virtual ICollection<UserGroup> UserGroups { get; set; } = new List<UserGroup>();
    }
}
