using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DrinkStores.Models;
using eshop.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrinkStores.Pages
{
    public class _CartModel : PageModel
    {
        private IStoreRepository repository;
        public _CartModel(IStoreRepository repo)
        {
            repository = repo;
        }
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long Id, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.Id ==Id);
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(product, 1);
            HttpContext.Session.SetJson("cart", Cart);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}

