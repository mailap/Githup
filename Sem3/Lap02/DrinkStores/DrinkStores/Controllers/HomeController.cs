﻿using Microsoft.AspNetCore.Mvc;
using DrinkStores.Models;
using System.Linq;
using DrinkStores.Models.ViewModels;
namespace DrinkStores.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        public int PageSize = 4;

        public ViewResult Index(int productPage = 1)
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                .OrderBy(p => p.Id)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                }
            });
        //public IActionResult Index(int productPage = 1)
        //    => View(repository.Products
        //        .OrderBy(p => p.Id)
        //        .Skip((productPage - 1) * PageSize)
        //        .Take(PageSize)
        //    );

        //public IActionResult Index() => View(repository.Products);           
    }
}