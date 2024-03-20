using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm_Domain.Model
{
    public class HoaDon
    {
        public Guid Id { get; set; }
        public Guid ChiTietHoaDonID { get; set; }
        public DateTime SolDate { get; set; }

        public Guid UserID { get; set; }
        public decimal TotalMoney { get; set; } // tổng tiền
        public int Status { get; set; } // trạng thái 


        public virtual Use Use { get; set; } // thể hiện quan hệ 1
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
}
