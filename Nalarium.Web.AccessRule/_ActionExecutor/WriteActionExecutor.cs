#region Copyright

//+ Copyright © David Betz 2009-2016

#endregion

//+
namespace Nalarium.Web.AccessRule
{
    public class WriteActionExecutor : ActionExecutor
    {
        
        public override void Execute()
        {
            Nalarium.Web.Http.Response.Write(Value);
            Nalarium.Web.Http.Response.End();
        }
    }
}