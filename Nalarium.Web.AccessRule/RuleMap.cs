#region Copyright

//+ Copyright © David Betz 2009-2016

#endregion

using System;

namespace Nalarium.Web.AccessRule
{
    internal class RuleMap : Map<String, RuleGroup>
    {
        internal static Object _Lock = new Object();

        //+
        
        public static RuleMap Current { get; set; }
    }
}