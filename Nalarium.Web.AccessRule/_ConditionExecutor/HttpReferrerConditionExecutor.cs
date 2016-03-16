#region Copyright

//+ Copyright © David Betz 2009-2016

#endregion

using System;

namespace Nalarium.Web.AccessRule
{
    public class HttpReferrerConditionExecutor : ConditionExecutor
    {
        
        public override Boolean Process()
        {
            return Http.Referrer.Equals(Value);
        }
    }
}