using Machine.Specifications;
using System.Web.Routing;
using day1;

namespace TestRouting
{
    [Subject("Route is match")]
    public class TestRouteMatch
    {
        private static RouteCollection routes;
        private static RouteData result;
        private static string controller = "home";
        private static string action = "index";

        Establish context = () =>
        {
            routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
        };

        Because of = () =>
        {
            result = routes.GetRouteData(Helper.CreateHttpContext("~/home/index/13"));
        };

        It route_should_match = () => Helper.TestIncomingRouteResult(result, controller, action).ShouldBeTrue();
    }

    [Subject("Route is failed")]
    public class TestRouteFail
    {
        private static RouteData result;
        private static RouteCollection routes;

        Establish context = () =>
        {
            routes = new RouteCollection();
            RouteConfig.RegisterRoutes(routes);
        };

        Because of = () =>
            result = routes.GetRouteData(Helper.CreateHttpContext("~/home/index"));

        It route_should_be_failed = () =>
            (result?.Route == null).ShouldBeTrue();
    }
}
