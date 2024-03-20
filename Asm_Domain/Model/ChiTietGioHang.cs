using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm_Domain.Model
{
    public class ChiTietGioHang
    {
        public Guid Id { get; set; }
        public Guid GioHangID { get; set; } // giỏ hàng
        public Guid SanPhamID { get; set; } // Sản phẩm 
        public int SoLuong { get; set; }
        public int TrangThai { get; set; }
        public virtual GioHang GioHang { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
