﻿#region Copyright

//+ Copyright © David Betz 2009-2016

#endregion

//+
using System;

namespace Nalarium.Web.AccessRule
{
    public static class AccessRuleChecker
    {
        public static void SystemCheck(String accessRuleGroup)
        {
            lock (RuleMap._Lock)
            {
                RuleMap map = RuleMap.Current;
                RuleGroup group = map[accessRuleGroup];
                if (group == null)
                {
                    return;
                }
                Rule activeRule = null;
                foreach (Rule rule in group)
                {
                    if (rule.Check())
                    {
                        //++ stop on first hit
                        activeRule = rule;
                        break;
                    }
                }
                //+
                if (activeRule != null)
                {
                    activeRule.Action.Execute();
                }
            }
        }
    }
}