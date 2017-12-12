using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Tender.Controllers
{
    [Authorize]
    public class LikeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}