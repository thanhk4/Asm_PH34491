using app_data_class.Models;
using Asm_Domain.Model;
using Asm_Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asm.Web.Controllers
{
    public class GHCTController : Controller
    {
        SD18302_NET104Context context;
        AllReposotory<ChiTietGioHang> _Repo;
        DbSet<ChiTietGioHang> _DbSP;

        public GHCTController()
        {
            context = new SD18302_NET104Context();
            _DbSP = context.chiTietGioHangs;
            _Repo = new AllReposotory<ChiTietGioHang>(_DbSP, context);
        }
     
      
        public IActionResult Index()
        {
            var login = HttpContext.Session.GetString("User");
            if (login == null)
                return RedirectToAction("Login", "User");
            else
            {
                var all = context.chiTietGioHangs.Where(x => x.GioHangID == Guid.Parse(login)).ToList();
                return View(all);
            }


        }

        public IActionResult Delete(Guid id)
        {
            _Repo.Delete(id);
            return RedirectToAction("Index");
          
        }

        [HttpPost]
        public IActionResult DataUpdateAmout(int amount, Guid id)
        {
            var loginDT = HttpContext.Session.GetString("User");

           
             var UseID = Guid.Parse(loginDT);
                var cu = context.GioHangs.FirstOrDefault(x=> x.UseId == UseID);
                var AllCart = context.chiTietGioHangs.FirstOrDefault(x => x.SanPhamID == id && x.GioHangID == cu.Id);
                if (AllCart != null)
                {
                    AllCart.SoLuong = AllCart.SoLuong + amount;

                    context.chiTietGioHangs.Update(AllCart);
                    context.SaveChanges();
                }
                return RedirectToAction("Index","GHCT");
          

        }
    }
}
