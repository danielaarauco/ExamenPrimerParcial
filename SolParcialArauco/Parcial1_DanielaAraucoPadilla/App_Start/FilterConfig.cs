using System.Web;
using System.Web.Mvc;

namespace Parcial1_DanielaAraucoPadilla
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
