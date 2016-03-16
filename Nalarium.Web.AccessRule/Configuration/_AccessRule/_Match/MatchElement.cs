#region Copyright

//+ Copyright © David Betz 2009-2016

#endregion

using System;
using System.Configuration;
using System.Diagnostics;
using Nalarium.Configuration;
using Nalarium.Configuration.AppConfig;

namespace Nalarium.Web.AccessRule.Configuration
{
    [DebuggerDisplay("{Usage}, {Value}")]
    public class MatchElement : CommentableElement
    {
        
        [ConfigurationProperty("usage")]
        public String Usage
        {
            get
            {
                return (String)this["usage"];
            }
            set
            {
                this["usage"] = value;
            }
        }

        
        [ConfigurationProperty("value")]
        public String Value
        {
            get
            {
                return (String)this["value"];
            }
            set
            {
                this["value"] = value;
            }
        }
    }
}