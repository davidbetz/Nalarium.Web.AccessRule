#region Copyright

//+ Copyright © David Betz 2009-2016

#endregion

//+
using System;
using System.Configuration;
using Nalarium.Configuration;
using Nalarium.Configuration.AppConfig;

namespace Nalarium.Web.AccessRule.Configuration
{
    public class WhenCollection : CommentableCollection<MatchElement>
    {
        //- #GetElementKey -//
        protected override Object GetElementKey(ConfigurationElement element)
        {
            return GuidCreator.GetNewGuid();
        }
    }
}