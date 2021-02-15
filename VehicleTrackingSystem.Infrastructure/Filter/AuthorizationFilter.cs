using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace POS.Infrastructure.Filter
{
    public class AuthorizationFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var action = context.RouteData.Values["action"].ToString();

            if (string.IsNullOrEmpty(action) || context.Controller.GetType().GetMethod(action).GetCustomAttributes(typeof(AllowAnonymousAttribute), true).Length <= 0)
            {
                var controller = context.RouteData.Values["controller"].ToString();
                string userRole = controller + "_" + action;

                if (!context.HttpContext.User.IsInRole(userRole) && !context.HttpContext.User.IsInRole("Admin"))
                {
                    context.Result = new UnauthorizedResult();
                    return;
                }
            }

            var resultContext = await next();
        }
    }
}
