#region Copyright

//+ Copyright © David Betz 2009-2016

#endregion

using System;

namespace Nalarium.Web.AccessRule
{
    internal class Condition
    {
        public ConditionExecutor _executor;

        private Condition()
        {
        }

        //+
        
        public String Usage { get; set; }

        
        public String Value { get; set; }

        //+
        

        //+
        
        public static Condition Create(String usage, String value)
        {
            ConditionExecutor executor = ConditionExecutorFactory.Create(usage, value);
            if (executor == null)
            {
                return null;
            }
            //+
            return new Condition
                   {
                       Usage = usage,
                       Value = value,
                       _executor = executor
                   };
        }

        //+
        
        public Boolean Check()
        {
            return _executor.Process();
        }
    }
}