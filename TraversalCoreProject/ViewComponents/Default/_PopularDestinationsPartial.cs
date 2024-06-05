using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.ViewComponents.Default
{
    public class _PopularDestinationsPartial : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDal());

        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();
            return View(values); 
        }
    }
}
