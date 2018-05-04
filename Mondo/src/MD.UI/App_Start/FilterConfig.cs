using MD.Infra.CrossCutting.MvcFilters;
using System.Web;
using System.Web.Mvc;

namespace MD.UI
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
