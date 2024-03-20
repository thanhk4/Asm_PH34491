using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm_Domain.Model
{
    public class Use
    {


        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string username { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime DoB { get; set; } //Ngày sinh

        public virtual ICollection<HoaDon> HoaDons { get; set; }
        // thể hiện mối quan hệ 
        //ICollection<HoaDon> HoaDons chỉ để thể hiện 1 user có thể chứa nhiều hóa đơn
        //ICollection<HoaDon> còn được sử dụng để làm Navigation để trỏ đến khi cần 

        public virtual ICollection<DanhGiaSanPham> DanhGiaSanPham { get; set; }
        public virtual GioHang GioHang { get; set; }
    }
}
