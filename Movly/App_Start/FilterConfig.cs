using System.Web;
using System.Web.Mvc;

namespace Movly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new AuthorizeAttribute()); //global - will be applied to all the controllers [Authorize]
        }
    }
}
