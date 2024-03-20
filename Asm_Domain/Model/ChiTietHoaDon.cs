using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm_Domain.Model
{
    public class ChiTietHoaDon
    {
        public Guid Id { get; set; }
        public Guid HoaDonId { get; set; } // Khóa ngoại Hóa Đơ
        public Guid SanPhamID { get; set; }// Khóa ngoại Sản phẩm 
        public int SoLuong { get; set; }
        public decimal GiaSP { get; set; }

        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
