using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm_Domain.Model
{
    public class GioHang
    {
        public Guid Id { get; set; }

        public Guid UseId { get; set; } // khóa ngoại  Use 
        public int Status { get; set; }
        public virtual Use Use { get; set; }
        public virtual ICollection<ChiTietGioHang> ChiTietGioHangs { get; set; }
    }
}
