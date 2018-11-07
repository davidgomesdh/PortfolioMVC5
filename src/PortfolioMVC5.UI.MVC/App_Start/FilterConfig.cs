using PortfolioMVC5.Data.CrossCutting.MvcFilters;
using System.Web;
using System.Web.Mvc;

namespace PortfolioMVC5.UI.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new GlobalErrorHandler());
        }
    }
}
