using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asm_Domain.Model
{
    public class DanhGiaSanPham
    {
        public Guid Id { get; set; }
        public Guid SanPhamId { get; set; }
        public Guid UseID { get; set; }
        public int DanhGiaSao { get; set; }
        public string Comment { get; set; }

        public virtual SanPham SanPham { get; set; }
        public virtual Use Uses { get; set; }
    }
}
