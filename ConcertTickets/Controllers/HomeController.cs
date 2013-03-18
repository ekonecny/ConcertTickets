using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConcertTickets.Models;


namespace ConcertTickets.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult OrderForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult OrderForm(CustomerResponse customerResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", customerResponse);
            }
            else
            {
                return View();
            }
        }
    }
}
