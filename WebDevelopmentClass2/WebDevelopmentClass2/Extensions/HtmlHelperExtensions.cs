using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace WebDevelopmentClass2.Extensions
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString MenuLink(this HtmlHelper helper, string text, string action, string controller, string @class)
        {
            var routeData = helper.ViewContext.RouteData.Values;
            var currentController = routeData["controller"] as string;
            var currentAction = routeData["action"] as string;

            if (String.Equals(action, currentAction, StringComparison.OrdinalIgnoreCase) &&
               String.Equals(controller, currentController, StringComparison.OrdinalIgnoreCase))
            {
                return helper.ActionLink(text, action, controller, null, new { @class });
            }
            return helper.ActionLink(text, action, controller);
        }
    }
}