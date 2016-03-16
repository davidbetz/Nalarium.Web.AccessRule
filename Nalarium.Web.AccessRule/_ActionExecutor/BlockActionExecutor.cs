#region Copyright

//+ Copyright © David Betz 2009-2016

#endregion

//+
using System.Web;

namespace Nalarium.Web.AccessRule
{
    public class BlockActionExecutor : ActionExecutor
    {
        
        public override void Execute()
        {
            HttpResponse response = Http.Response;
            response.SuppressContent = true;
            response.End();
        }
    }
}