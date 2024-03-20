using Asm_Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Asm_Domain.Configuration
{
    internal class HoadonChiTietConfig : IEntityTypeConfiguration<ChiTietHoaDon>
    {
        public void Configure(EntityTypeBuilder<ChiTietHoaDon> builder)
        {
            builder.HasKey(t => t.Id);
            builder.HasOne(x => x.HoaDon).WithMany(x => x.ChiTietHoaDons).HasForeignKey(x => x.HoaDonId).HasConstraintName("FK_Hoadon_hoadonchitiet");
            builder.HasOne(x => x.SanPham).WithMany(x => x.ChiTietHoaDons).HasForeignKey(x => x.SanPhamID).HasConstraintName("FK_Hoadon_sanpham");
        }
    }
}
