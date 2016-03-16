#region Copyright

//+ Copyright © David Betz 2009-2016

#endregion

using System;

namespace Nalarium.Web.AccessRule
{
    public abstract class ConditionExecutor
    {
        
        public String Usage { get; set; }

        
        public String Name { get; set; }

        
        public String Value { get; set; }

        //+
        
        public abstract Boolean Process();
    }
}