using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EFFeatureDal());
        public IViewComponentResult Invoke()
        {
           var values = featureManager.TGetList();
         //  ViewBag.image1=featureManager.
             return View(values);
        }
    }
}
