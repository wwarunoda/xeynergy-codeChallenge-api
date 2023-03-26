using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using xeynergy_codeChallenge_api.Entities;

namespace xeynergy_codeChallenge_api.Contexts
{
    public static class DbInitializer
    {
        public static void Initialize(IdentityDbContext context)
        {
            context.Database.EnsureCreated();
            if (!context.AccessRules.Any())
            {
                IList<AccessRule> accessRules = new List<AccessRule>();

                accessRules.Add(new AccessRule() { RuleName = "Admin", Permission = false });
                accessRules.Add(new AccessRule() { RuleName = "Level1", Permission = true });
                accessRules.Add(new AccessRule() { RuleName = "Level2", Permission = true });
                accessRules.Add(new AccessRule() { RuleName = "Level3", Permission = true });

                context.AccessRules.AddRange(accessRules);

                context.SaveChanges();
            }
            if (!context.UserGroups.Any())
            {
                IList<UserGroup> userGroups = new List<UserGroup>();

                userGroups.Add(new UserGroup() { GroupName = "Admin", AccessRuleId = context.AccessRules.Where(x => x.RuleName == "Admin").FirstOrDefault().AccessRuleId });
                userGroups.Add(new UserGroup() { GroupName = "Gest1", AccessRuleId = context.AccessRules.Where(x => x.RuleName == "Level1").FirstOrDefault().AccessRuleId });
                userGroups.Add(new UserGroup() { GroupName = "Gest2", AccessRuleId = context.AccessRules.Where(x => x.RuleName == "Level2").FirstOrDefault().AccessRuleId });
                userGroups.Add(new UserGroup() { GroupName = "Gest3", AccessRuleId = context.AccessRules.Where(x => x.RuleName == "Level3").FirstOrDefault().AccessRuleId });

                context.UserGroups.AddRange(userGroups);

                context.SaveChanges();
            }
        }
    }
}
