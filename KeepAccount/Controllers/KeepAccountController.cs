using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KeepAccount.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KeepAccount.Controllers
{
    public class KeepAccountController : Controller
    {
        public static List<Expenditure> Data = new List<Expenditure>();

        // GET: KeepAccountController
        public ActionResult Index()
        {
            var model = new PageViewModel {Expenditures = Data};

            return View("Index", model);
        }

        [HttpPost]
        public ActionResult Create(Expenditure expenditure)
        {
            if (expenditure.Amount == 0)
            {
                
                ModelState.AddModelError(nameof(expenditure.Amount), "Please enter your name");
            } 
            if (!ModelState.IsValid)
                return View("Index", new PageViewModel { Expenditures = Data, Expenditure = expenditure});

            Data.Add(expenditure);
            return RedirectToAction("Index");
        }
    }
}
