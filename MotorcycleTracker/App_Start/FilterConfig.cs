using System.Web;
using System.Web.Mvc;

namespace MotorcycleTracker
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //force ssl 
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
