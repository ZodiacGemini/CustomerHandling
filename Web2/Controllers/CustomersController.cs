using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web2.Controllers
{
    public class CustomersController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Customers = DataManager.GetAllCustomers();
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            DataManager.Remove(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            DataManager.AddCustomer(customer);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Customer = DataManager.GetCustomer(id);
            return View();
        }
        [HttpPost]
        public IActionResult Update(Customer customer)
        {
            DataManager.UpdateCustomer(customer);
            return RedirectToAction(nameof(Index));
        }

    }
}
