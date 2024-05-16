using app_data_class.Models;
using Asm_Domain.Model;
using Asm_Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Asm.Web.Controllers
{
    public class UserController : Controller
    {
        SD18302_NET104Context _context;

        AllReposotory<Use> _Repo;
        DbSet<Use> UserSet;
        public UserController()
        {
            //khởi tạo DBcontext
            _context = new SD18302_NET104Context();
            //khởi tạo reposotiory với 2 tham số là Dbset và dbContext;
            UserSet = _context.uses;
            _Repo = new AllReposotory<Use>(UserSet, _context);
        }

        //lấy ra tất cả danh sách User
        public IActionResult Index(string name)
        {
            var Sesesion = HttpContext.Session.GetString("user");
            if (Sesesion == null)
            {
                ViewData["message"] = "Phiên bản đã hết hạn <Đăng nhập lại>";

            }
            else
            {
                ViewData["message"] = $"Chào mừng {Sesesion} đến với cửa hàng";
            }
            var us = _Repo.GetAll();

            if (string.IsNullOrEmpty(name))
            {
                return View(us);
            }
            else
            {
                var searchData = _Repo.GetAll().Where(x => x.Name.Contains(name)).ToList(); // Tìm theo tên           
                ViewData["count"] = searchData.Count;
                ViewBag.Count = searchData.Count;
                if (searchData.Count == 0) // Nếu ko tìm thấy 
                {
                    return View(us);
                }
                else return View(searchData); // có tìm thấy
            }

        }
        //Thêm data
        public IActionResult Create() //Action để mở form điền thông tin
        {
            return View();
        }
        //Ation để thực hiện

        [HttpPost]
        public IActionResult Create(Use use) 
        {
            Guid id = Guid.NewGuid();
            use.Id = id;
            
            var giohang = new GioHang()
            {
                Id = id,
                Status = 1,
                UseId = id
            };
            _Repo.Create(use);
            _context.GioHangs.Add(giohang);
            
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // sửa 
        public IActionResult Edit(Guid Id) // Load ra đối tượng cần sửa 
        {
            var Update = _Repo.GetbyID(Id);
            return View(Update);
        }
        public IActionResult EditUser(Use use)
        {
            _Repo.Update(use);
            return RedirectToAction("Index");
        }   
        //xóa 
        public IActionResult RollBack()
        {
            if (HttpContext.Session.Keys.Contains("delete"))
            {
                var jsonData = HttpContext.Session.GetString("delete");
                // tạo mới đối tượng có dữ liệu y hệt như dữ liệu cũ 
                var delete = JsonConvert.DeserializeObject<Use>(jsonData);
                _Repo.Create(delete);
                return RedirectToAction("Index");
            }
            else { 
                return Content("uể"); 
            }
           

        }
        
        public IActionResult Delete(Guid id)
        {
           var Delte = _Repo.GetbyID(id);
            var jsondata = JsonConvert.SerializeObject(Delte); // ép kiểu
            HttpContext.Session.SetString("delete", jsondata); // cho dữ liệu vào seesion
          _Repo.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Detail(Guid id)
        {
            var detail = _Repo.GetbyID(id);
            return View(detail);
        }
        public IActionResult Login() // Action nayf retunr 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Username, string password) 
        {
            var Usse = _Repo.GetAll().FirstOrDefault(x => x.username == Username && x.Password == password);
            if (Usse != null)
            {
                //return Content("Error");
                TempData["login"] = Usse.Name;
                // Lưu trữ thông tin đăng nhập vào Seession
                HttpContext.Session.SetString("User", Usse.Id.ToString());

              

                return RedirectToAction("Index", "Home");
            }
            else return Content("Thất bại");
           
        }
        public IActionResult Logout() 
        { 
        HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }
    }
}
