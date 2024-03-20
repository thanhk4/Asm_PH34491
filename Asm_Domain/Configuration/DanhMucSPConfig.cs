using Asm_Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Asm_Domain.Configuration
{
    internal class DanhMucSPConfig : IEntityTypeConfiguration<DanhMucSanPham>
    {
        public void Configure(EntityTypeBuilder<DanhMucSanPham> builder)
        {
            builder.HasKey(x => x.Id);

        }
    }
}
