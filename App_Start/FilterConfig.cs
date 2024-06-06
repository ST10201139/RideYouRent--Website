using System.Web;
using System.Web.Mvc;

namespace The_Ride_You_Rent1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
