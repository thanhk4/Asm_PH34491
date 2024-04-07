using Asm_Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Asm_Domain.Configuration
{
    internal class GioHangConfig : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Use).WithOne(x => x.GioHang);
            

        }
    }
}
