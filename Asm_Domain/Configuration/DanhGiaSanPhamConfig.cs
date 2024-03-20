using Asm_Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Asm_Domain.Configuration
{
    internal class DanhGiaSanPhamConfig : IEntityTypeConfiguration<DanhGiaSanPham>
    {
        public void Configure(EntityTypeBuilder<DanhGiaSanPham> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.SanPham).WithMany(x => x.DanhGiaSanPham).HasForeignKey(x => x.SanPhamId).HasConstraintName("FK_DG_SP");
            builder.HasOne(x => x.Uses).WithMany(x => x.DanhGiaSanPham).HasForeignKey(x => x.UseID).HasConstraintName("FK_DG_US");
        }
    }
}
