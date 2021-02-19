using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementPractice1.Controllers
{
    public class ErrorController : Controller
    {
        //If there is 404 status, the route path will become Error/404
        [Route("Ërror/{statusCode}")]
        public IActionResult HttpStatusCodeHandler(int statusCode)
        {
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorMessage = "Sorry, the resource you requested could not be found";
                    break;
            }
            return View("NotFound");
        }
    }
}
