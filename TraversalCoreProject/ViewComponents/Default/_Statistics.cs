﻿using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Statistics :ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           using var context =new Context();    
            ViewBag.v1=context.Destinations.Count();
            ViewBag.v2=context.Guides.Count();
            ViewBag.v3 = "285";
            return View();
        }
    }
}
