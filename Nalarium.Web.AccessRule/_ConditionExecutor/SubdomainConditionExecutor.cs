#region Copyright

//+ Copyright © David Betz 2009-2016

#endregion

using System;

namespace Nalarium.Web.AccessRule
{
    public class SubdomainConditionExecutor : ConditionExecutor
    {
        
        public override Boolean Process()
        {
            return Http.SubDomainPartArray[0].Equals(Value);
        }
    }
}