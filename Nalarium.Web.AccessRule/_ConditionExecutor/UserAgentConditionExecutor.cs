#region Copyright

//+ Copyright © David Betz 2009-2016

#endregion

using System;

namespace Nalarium.Web.AccessRule
{
    public class UserAgentConditionExecutor : ConditionExecutor
    {
        
        public override Boolean Process()
        {
            if (String.IsNullOrEmpty(Value) || String.IsNullOrEmpty(Http.UserAgent))
            {
                return false;
            }
            //+
            return Http.UserAgent.ToLower().Contains(Value.ToLower());
        }
    }
}