﻿using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ManagingProduct.Bootstrap;
using ManagingProducts.Web.App_Start;

namespace ManagingProducts.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AutomapperDtoConfiguration.RegisterDtoMapping();
            AutoMapperViewModelConfiguration.RegisterDtoMapping();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
