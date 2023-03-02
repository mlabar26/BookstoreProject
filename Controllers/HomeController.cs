using BookstoreProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreProject.Controllers
{
    public class HomeController : Controller
    {
        //Creates an instance of the context file
        private BookstoreContext context { get; set; }

        //Creates a constructor
        public HomeController(BookstoreContext temp)
        {
            context = temp;
        }

        public IActionResult Index()
        {
            var BookstoreData = context.Books.ToList();

            return View(BookstoreData);
        }
    }
}
