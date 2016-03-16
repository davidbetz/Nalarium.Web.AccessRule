#region Copyright

//+ Copyright © David Betz 2009-2016

#endregion

//+
namespace Nalarium.Web.AccessRule
{
    public class RedirectActionExecutor : ActionExecutor
    {
        
        public override void Execute()
        {
            if (Value.StartsWith("http://") || Value.StartsWith("https://"))
            {
                Http.Response.Redirect(Value);
            }
        }
    }
}