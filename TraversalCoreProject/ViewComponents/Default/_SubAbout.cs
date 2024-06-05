using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _SubAbout : ViewComponent
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EFSubAboutDal());
        public IViewComponentResult Invoke() {

            var values = subAboutManager.TGetList();
            return View(values); 
        }

    }
}
