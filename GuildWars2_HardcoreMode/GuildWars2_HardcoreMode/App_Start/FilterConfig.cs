﻿using System.Web;
using System.Web.Mvc;

namespace GuildWars2_HardcoreMode
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
