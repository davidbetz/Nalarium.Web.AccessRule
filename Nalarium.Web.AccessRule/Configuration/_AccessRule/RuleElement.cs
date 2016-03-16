#region Copyright

//+ Copyright © David Betz 2009-2016

#endregion

using System;
using System.Configuration;
using System.Diagnostics;
using Nalarium.Configuration;
using Nalarium.Configuration.AppConfig;
using Nalarium.Configuration.AppConfig.Parameter;

namespace Nalarium.Web.AccessRule.Configuration
{
    [DebuggerDisplay("{Name}")]
    public class RuleElement : CommentableElement
    {
        
        [ConfigurationProperty("group")]
        public String Group
        {
            get
            {
                return (String)this["group"];
            }
            set
            {
                this["group"] = value;
            }
        }

        
        [ConfigurationProperty("composite")]
        [ConfigurationCollection(typeof(ParameterElement), AddItemName = "add")]
        public WhenCollection Composite
        {
            get
            {
                return (WhenCollection)this["composite"];
            }
        }

        
        [ConfigurationProperty("action")]
        public String Action
        {
            get
            {
                return (String)this["action"];
            }
            set
            {
                this["action"] = value;
            }
        }

        
        [ConfigurationProperty("condition")]
        public String Condition
        {
            get
            {
                return (String)this["condition"];
            }
            set
            {
                this["condition"] = value;
            }
        }
    }
}