﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using app_data_class.Models;

#nullable disable

namespace Asm_Domain.Migrations
{
    [DbContext(typeof(SD18302_NET104Context))]
    partial class SD18302_NET104ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Asm_Domain.Model.ChiTietGioHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GioHangID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SanPhamID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GioHangID");

                    b.HasIndex("SanPhamID");

                    b.ToTable("ChiTietGioHang");
                });

            modelBuilder.Entity("Asm_Domain.Model.ChiTietHoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaSP")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("HoaDonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SanPhamID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HoaDonId");

                    b.HasIndex("SanPhamID");

                    b.ToTable("ChiTietHoaDon");
                });

            modelBuilder.Entity("Asm_Domain.Model.DanhGiaSanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DanhGiaSao")
                        .HasColumnType("int");

                    b.Property<Guid>("SanPhamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UseID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SanPhamId");

                    b.HasIndex("UseID");

                    b.ToTable("DanhGiaSanPham");
                });

            modelBuilder.Entity("Asm_Domain.Model.DanhMucSanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DanhMucSanPham");
                });

            modelBuilder.Entity("Asm_Domain.Model.GioHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UseId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UseId")
                        .IsUnique();

                    b.ToTable("GioHang");
                });

            modelBuilder.Entity("Asm_Domain.Model.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChiTietHoaDonID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SolDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalMoney")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("hoadonss");
                });

            modelBuilder.Entity("Asm_Domain.Model.SanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DanhMucSanPhamID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("MoTa");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Name");

                    b.Property<int>("SoLuong")
                        .HasPrecision(5)
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DanhMucSanPhamID");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("Asm_Domain.Model.Use", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(64)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("Địa chỉ");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Asm_Domain.Model.ChiTietGioHang", b =>
                {
                    b.HasOne("Asm_Domain.Model.GioHang", "GioHang")
                        .WithMany("ChiTietGioHangs")
                        .HasForeignKey("GioHangID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Chitietgiohang_giohang");

                    b.HasOne("Asm_Domain.Model.SanPham", "SanPham")
                        .WithMany("ChiTietGioHangs")
                        .HasForeignKey("SanPhamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Chitietgiohang_sanpham");

                    b.Navigation("GioHang");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("Asm_Domain.Model.ChiTietHoaDon", b =>
                {
                    b.HasOne("Asm_Domain.Model.HoaDon", "HoaDon")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("HoaDonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Hoadon_hoadonchitiet");

                    b.HasOne("Asm_Domain.Model.SanPham", "SanPham")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("SanPhamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Hoadon_sanpham");

                    b.Navigation("HoaDon");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("Asm_Domain.Model.DanhGiaSanPham", b =>
                {
                    b.HasOne("Asm_Domain.Model.SanPham", "SanPham")
                        .WithMany("DanhGiaSanPham")
                        .HasForeignKey("SanPhamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DG_SP");

                    b.HasOne("Asm_Domain.Model.Use", "Uses")
                        .WithMany("DanhGiaSanPham")
                        .HasForeignKey("UseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DG_US");

                    b.Navigation("SanPham");

                    b.Navigation("Uses");
                });

            modelBuilder.Entity("Asm_Domain.Model.GioHang", b =>
                {
                    b.HasOne("Asm_Domain.Model.Use", "Use")
                        .WithOne("GioHang")
                        .HasForeignKey("Asm_Domain.Model.GioHang", "UseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Use");
                });

            modelBuilder.Entity("Asm_Domain.Model.HoaDon", b =>
                {
                    b.HasOne("Asm_Domain.Model.Use", "Use")
                        .WithMany("HoaDons")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_User_HD");

                    b.Navigation("Use");
                });

            modelBuilder.Entity("Asm_Domain.Model.SanPham", b =>
                {
                    b.HasOne("Asm_Domain.Model.DanhMucSanPham", "DanhMucSanPham")
                        .WithMany("SanPham")
                        .HasForeignKey("DanhMucSanPhamID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DM_SP");

                    b.Navigation("DanhMucSanPham");
                });

            modelBuilder.Entity("Asm_Domain.Model.DanhMucSanPham", b =>
                {
                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("Asm_Domain.Model.GioHang", b =>
                {
                    b.Navigation("ChiTietGioHangs");
                });

            modelBuilder.Entity("Asm_Domain.Model.HoaDon", b =>
                {
                    b.Navigation("ChiTietHoaDons");
                });

            modelBuilder.Entity("Asm_Domain.Model.SanPham", b =>
                {
                    b.Navigation("ChiTietGioHangs");

                    b.Navigation("ChiTietHoaDons");

                    b.Navigation("DanhGiaSanPham");
                });

            modelBuilder.Entity("Asm_Domain.Model.Use", b =>
                {
                    b.Navigation("DanhGiaSanPham");

                    b.Navigation("GioHang")
                        .IsRequired();

                    b.Navigation("HoaDons");
                });
#pragma warning restore 612, 618
        }
    }
}
