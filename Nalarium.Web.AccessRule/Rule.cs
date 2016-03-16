#region Copyright

//+ Copyright © David Betz 2009-2016

#endregion

using System;
using System.Collections.Generic;

namespace Nalarium.Web.AccessRule
{
    internal class Rule
    {
        
        public Action Action { get; set; }

        
        public Condition Condition { get; set; }

        
        public List<Condition> WhenList { get; set; }

        
        public bool Check()
        {
            Boolean execute = false;
            if (!Collection.IsNullOrEmpty(WhenList))
            {
                Int32 requiredCount = WhenList.Count;
                WhenList.ForEach(p =>
                                 {
                                     if (p.Check())
                                     {
                                         requiredCount--;
                                         if (requiredCount == 0)
                                         {
                                             execute = true;
                                         }
                                     }
                                 });
            }
            else if (Condition != null)
            {
                if (Condition.Check())
                {
                    execute = true;
                }
            }
            else
            {
                execute = true;
            }
            //+
            return execute;
        }
    }
}