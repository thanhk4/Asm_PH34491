using app_data_class.Models;
using Asm_Domain.Model;
using Asm_Domain.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Asm.Web.Controllers
{
    public class SanPhamController : Controller
    {
        SD18302_NET104Context context ;
        AllReposotory<SanPham> _Repo;
        DbSet<SanPham> _DbSP;

        public SanPhamController()
        {
            context = new SD18302_NET104Context();
            _DbSP = context.SanPham;
            _Repo = new AllReposotory<SanPham>(_DbSP,context);
            
        }
        public IActionResult Index()
        {
          
            var us = _Repo.GetAll();
            return View(us);
        }   
        public IActionResult Create()
        {
           return View();
        }
        [HttpPost]
        public IActionResult Create(SanPham sp, IFormFile imgFile)
        {
           

            //Xây dựng đường dẫn lưu ảnh trong www
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", imgFile.FileName);
            // Kết quả thu được có dạng như sau: wwwroot/img/concho.png
            //thực thi việc sao chép file được chọn vào thư mục root 
            var stry = new FileStream(path, FileMode.Create);
            //thực hiện sao chép ảnh vào mục root 
            imgFile.CopyTo(stry);
            sp.ImgURL = imgFile.FileName;
            _Repo.Create(sp);
           return RedirectToAction("Index");
        }
        public IActionResult Edit(Guid id)
        {
            var Sua = _Repo.GetbyID(id);
            return View(Sua);
        }
        public IActionResult Editto(SanPham sanPham)
        {
            _Repo.Update(sanPham);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Guid id)
        {
            _Repo.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Detail(Guid id)
        {
            var chitit = _Repo.GetbyID(id);
            return View(chitit);
        }
        public IActionResult AddToCart(Guid id,int Trangthai)
        {
            var loginDT = HttpContext.Session.GetString("User");
            if (loginDT == null)

                return Content("Phai Dang nhap");

            else
            {
                Guid UseID = Guid.Parse(loginDT); // lấy ra Id của khách giỏ hàng
                                                  //Lấy ra sản phẩm ID của nó trùng với ID của snar Sản Phẩm đâng được chọn
                var AllCart = context.chiTietGioHangs.FirstOrDefault(x => x.SanPhamID == id && x.GioHangID == UseID);
                if (AllCart != null)
                {
                    AllCart.SoLuong = AllCart.SoLuong + 1;

                    context.chiTietGioHangs.Update(AllCart);
                    context.SaveChanges();

                }
                else
                {
                    ChiTietGioHang gioHangCT = new ChiTietGioHang()
                    {
                        Id = Guid.NewGuid(),
                        SanPhamID = id,
                        SoLuong = 1,
                        GioHangID = UseID,  
                        TrangThai = 1


                    };
                    context.chiTietGioHangs.Add(gioHangCT);
                    context.SaveChanges();
                }
              

                
                return RedirectToAction("Index","GHCT");
            }
        }
    }
}
