using app_data_class.Models;
using Asm.Web.Models;
using Asm_Domain.Model;
using Asm_Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Asm.Web.Controllers
{
    public class HomeController : Controller
    {
        SD18302_NET104Context context;
        AllReposotory<SanPham> _Repo;
        DbSet<SanPham> _DbSP;
        public HomeController()
        {
            context = new SD18302_NET104Context();
            _DbSP = context.SanPham;
            _Repo = new AllReposotory<SanPham>(_DbSP, context);
        }

        public IActionResult Index()
        {

            var us = _Repo.GetAll();
            return View(us);
        }
        public IActionResult TimKiem()
        {
            return View();
        }
        public IActionResult Privacy()
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