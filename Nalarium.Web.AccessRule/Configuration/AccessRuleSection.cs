#region Copyright

//+ Copyright © David Betz 2009-2016

#endregion

using System.Configuration;

namespace Nalarium.Web.AccessRule.Configuration
{
    /// <summary>
    /// Provides access to the configuration section.
    /// </summary>
    public class AccessRuleSection : Nalarium.Configuration.AppConfig.ConfigurationSection
    {
        
        [ConfigurationProperty("rules")]
        [ConfigurationCollection(typeof(RuleElement), AddItemName = "add")]
        public RuleCollection Rules
        {
            get
            {
                return (RuleCollection)this["rules"];
            }
        }

        
        [ConfigurationProperty("aliases")]
        [ConfigurationCollection(typeof(AliasElement), AddItemName = "add")]
        public AliasCollection Aliases
        {
            get
            {
                return (AliasCollection)this["aliases"];
            }
        }

        //+
        
        /// <summary>
        /// Gets the config section.
        /// </summary>
        /// <returns>Configuration section</returns>
        public static AccessRuleSection GetConfigSection()
        {
            return GetConfigSection<AccessRuleSection>("nalarium/accessRule");
        }
    }
}