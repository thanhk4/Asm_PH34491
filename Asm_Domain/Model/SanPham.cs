using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm_Domain.Model
{
    public class SanPham
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MoTa { get; set; }
        public Guid DanhMucSanPhamID { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DanhMucSanPham DanhMucSanPham { get; set; }
        public virtual ICollection<DanhGiaSanPham> DanhGiaSanPham { get; set; }
    }
}
