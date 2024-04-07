using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm_Domain.Model
{
    public class SanPham
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage ="Tên sản phẩm là bắt buộc.")]
        [StringLength(100,MinimumLength =6,ErrorMessage ="Tên sản phẩm phải có ít nhất 6 ký tự")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Mô tả sản phẩm là bắt buộc.")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Tên sản phẩm phải có ít nhất 10 ký tự")]
        public string MoTa { get; set; }
        public Guid DanhMucSanPhamID { get; set; }
        [Required(ErrorMessage ="Giá sản phẩm là bắt buộc.")]
        [Range(1, 1000000000,ErrorMessage ="Giá sản phẩm phải từ 1 và không chứa số âm ")]
        public decimal Gia { get; set; }
        public string ImgURL { get; set; }
        [Required(ErrorMessage = "Số lượng sản phẩm là bắt buộc.")]
        [Range(0, double.MaxValue, ErrorMessage = "Số lượng không được âm ")]
        public int SoLuong { get; set; }
        public int TrangThai { get; set; }

        public virtual ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DanhMucSanPham DanhMucSanPham { get; set; }
        public virtual ICollection<DanhGiaSanPham> DanhGiaSanPham { get; set; }
    }
}
