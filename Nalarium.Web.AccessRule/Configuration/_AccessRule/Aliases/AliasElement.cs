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
    [DebuggerDisplay("{Name}")]
    public class AliasElement : CommentableElement
    {
        
        [ConfigurationProperty("name")]
        public String Name
        {
            get
            {
                return (String)this["name"];
            }
            set
            {
                this["name"] = value;
            }
        }

        
        [ConfigurationProperty("type")]
        public String Type
        {
            get
            {
                return (String)this["type"];
            }
            set
            {
                this["type"] = value;
            }
        }
    }
}