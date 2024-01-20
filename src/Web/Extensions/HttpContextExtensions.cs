using System.Security.Claims;

namespace Web.Extensions
{
    public static class HttpContextExtensions
    {
        public static string GetUserId(this HttpContext context)
        {
            return context.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}
