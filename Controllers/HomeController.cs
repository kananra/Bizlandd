using Bizland.DataAccess;
using Bizland.Models;
using Bizland.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bizland.Controllers
{
    public class HomeController : Controller
    {

        private readonly DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }

        public ViewResult Index()
        {
            HomeViewModel vm = new HomeViewModel
            {
                TeamMembers = _context.TeamMembers.ToList(),
                Services = _context.Services.ToList(),

            };

            return View(vm);
        }


        public ViewResult About()
        {
            return View();
        }


        public ViewResult Contact()
        {
            return View();
        }



    }
}
