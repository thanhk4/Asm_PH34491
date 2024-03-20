using Asm_Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Asm_Domain.Configuration
{
    internal class HoaDonConfig : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.HasKey(x => x.Id);
            //config khóa ngoại 
            builder.HasOne(p => p.Use).WithMany(p => p.HoaDons).
                HasForeignKey(p => p.UserID).HasConstraintName("FK_User_HD");
            // với môi use sẽ có nhiều hóa đơn, khóa ngoại là cột UserID nối với bẳng User 
            // Tên Khóa ngoại là FK_use_HD 
        }
    }
}
