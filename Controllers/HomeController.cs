using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiEEP.Models;

namespace WebApiEEP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Controller for the view /Home/Index
        /// Consults for one or all employee from the Api
        /// </summary>
        /// <param name="InputId">Code of the employee to be shown</param>
        /// <returns>Index View</returns>
        public async Task<IActionResult> Index(string InputId = "0")
        {
            Console.WriteLine($"InputId: {InputId}");
            List<Employee> employees = new List<Employee>();

            if (InputId == null)
                employees = await EmployeeFactory.getEmployees();
            else{
                employees = await EmployeeFactory.getEmployee(Int32.Parse(InputId));
            }    
            
            ViewBag.employees = employees;

            return View();
        }

        /// <summary>
        /// Contact data of the evaluated programmer
        /// </summary>
        /// <returns>ContactData View</returns>
        public IActionResult ContactData()
        {
            return View();
        }
        /// <summary>
        /// Controler for the Class Design View
        /// shows the class diagram
        /// </summary>
        /// <returns>ClassDesign view</returns>
        public IActionResult ClassDesign()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
