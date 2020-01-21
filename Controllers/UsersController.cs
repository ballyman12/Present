using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Users;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View("CreateFormByHTMLHelpers");
        }

        [HttpGet]
        public IActionResult ShowUser(User users)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View();

                ViewData["Name"] = users.Name;
                ViewData["Address"] = users.Address;
                ViewData["Phone"] = users.Phone;
                ViewData["Province"] = users.Province;
                ViewData["Country"] = users.Country;
                ViewData["Zipcode"] = users.Zipcode;
                ViewData["Email"] = users.Email;
                ViewData["Gender"] = users.Gender;

                return View("ShowUser");
            } catch
            {
                return View();
            }
            
        }
    }
}