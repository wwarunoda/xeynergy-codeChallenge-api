using System;

namespace xeynergy_codeChallenge_api.Dtos
{
    public class AccessRuleDto
    {
        public Guid AccessRuleId { get; set; }
        public string RuleName { get; set; }
        public bool Permission { get; set; }
    }
}
