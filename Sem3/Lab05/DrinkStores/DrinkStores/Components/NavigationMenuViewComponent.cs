using Microsoft.AspNetCore.Mvc;
using System.Linq;
using DrinkStores.Models;

namespace DrinkStores.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IStoreRepository repository;

        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }

        //public string Invoke()
        //{
        //    return "Ahihi Hello from the Nav View Component";
        //}

    }
}
