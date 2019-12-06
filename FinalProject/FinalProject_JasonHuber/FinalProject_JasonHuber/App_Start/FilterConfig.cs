using System.Web;
using System.Web.Mvc;

namespace FinalProject_JasonHuber
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
