#region Copyright

//+ Copyright © David Betz 2009-2016

#endregion

using System;
using System.Collections.Generic;

namespace Nalarium.Web.AccessRule
{
    internal class RuleGroup : List<Rule>
    {
        public Boolean HasPermit
        {
            get
            {
                if (this[Count - 1].GetType() == typeof(PermitExecutor))
                {
                    return true;
                }
                //+
                return false;
            }
        }
    }
}