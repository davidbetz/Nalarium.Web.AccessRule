#region Copyright

//+ Copyright © David Betz 2009-2016

#endregion

using System;

namespace Nalarium.Web.AccessRule
{
    internal class Action
    {
        public ActionExecutor _executor;

        //+
        

        //+
        
        private Action()
        {
        }

        public String Value { get; set; }

        //+
        
        public static Action Create(String value)
        {
            ActionExecutor executor = ActionExecutorFactory.Create(value);
            if (executor == null)
            {
                return null;
            }
            //+
            return new Action
                   {
                       Value = value,
                       _executor = executor
                   };
        }

        public void Execute()
        {
            _executor.Execute();
        }
    }
}