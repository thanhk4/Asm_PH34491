using Asm_Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Asm_Domain.Configuration
{
    internal class SanPhamConfig : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnName("Name").
                HasColumnType("nvarchar(100)");
            builder.Property(x => x.MoTa).HasColumnName("MoTa").

                HasColumnType("nvarchar(100)");
            builder.Property(x => x.SoLuong).HasPrecision(5); //max là 99999
            builder.HasOne(x => x.DanhMucSanPham).WithMany(x => x.SanPham).HasForeignKey(x => x.DanhMucSanPhamID).HasConstraintName("FK_DM_SP");
        }
    }
}
