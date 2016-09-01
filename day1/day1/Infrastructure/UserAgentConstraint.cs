using System.Web;
using System.Web.Routing;

namespace day1.Infrastructure
{
    public class UserAgentConstraint : IRouteConstraint
    {
        private string uri;
        public UserAgentConstraint(string agentParam)
        {
            uri = agentParam;
        }
        public bool Match(HttpContextBase httpContext, Route route, string parameterName,
          RouteValueDictionary values, RouteDirection routeDirection)
        {
            return !(uri == httpContext.Request.Url.AbsolutePath);
        }
    }
}