using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;
using Asm_Domain.Model;

namespace app_data_class.Models
{
    public partial class SD18302_NET104Context : DbContext
    {
        public SD18302_NET104Context()
        {
        }
        // dbset để trỏ đến mỗi bảng 
        public DbSet<HoaDon> hoadonss { get; set; }
        public DbSet<Use> uses { get; set; }
        public SD18302_NET104Context(DbContextOptions<SD18302_NET104Context> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=THANHCONGTU\\SQLEXPRESS01;Database=SD18302_NET104;Trusted_Connection=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
