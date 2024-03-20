using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm_Domain.Model
{
    public class DanhMucSanPham
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MoTa { get; set; }

        public virtual ICollection<SanPham> SanPham { get; set; }
    }
}
