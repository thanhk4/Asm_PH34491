using Asm_Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Asm_Domain.Configuration
{
    internal class GiohangChiTietConfig : IEntityTypeConfiguration<ChiTietGioHang>
    {
        public void Configure(EntityTypeBuilder<ChiTietGioHang> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.GioHang).WithMany(x => x.ChiTietGioHangs).HasForeignKey(x => x.GioHangID).HasConstraintName("FK_Chitietgiohang_giohang");
            builder.HasOne(x => x.SanPham).WithMany(x => x.ChiTietGioHangs).HasForeignKey(x => x.SanPhamID).HasConstraintName("FK_Chitietgiohang_sanpham");
        }
    }
}
