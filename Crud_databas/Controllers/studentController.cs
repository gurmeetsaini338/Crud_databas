using Crud_databas.DB_Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_databas.Controllers
{
    public class studentController : Controller
    {
        public IActionResult info()
        {
            
            gurmeet10Context obj = new gurmeet10Context();
            var re = obj.Logins.ToList();

            return View(re);
        }
    }
}
