using Asm_Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Asm_Domain.Configuration
{
    internal class UserConfig : IEntityTypeConfiguration<Use>
    {
        public void Configure(EntityTypeBuilder<Use> builder)
        {
            //THực hiện config trên entity 
            builder.ToTable("User"); // Đặt tên bảng 
            // Xác định khóa chính
            builder.HasKey(x => x.Id); //Set khóa cột ID 
            //builder.HasNoKey();// không khóa 
            //builder.HasKey(x => new { x.Id,x.Address });// Khóa Composite (Nhiều cột)
            // Thiếu lập thuộc tính cho cột 
            builder.Property(x => x.Name).HasColumnName("Name").
                HasColumnType("nvarchar(50)");

            builder.Property(x => x.Address).HasColumnName("Địa chỉ").
                HasMaxLength(64).IsUnicode(true); // nvarchar(50)

            builder.Property(x => x.username).IsRequired(); // not null

        }
    }
}
