using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asm_Domain.Migrations
{
    /// <inheritdoc />
    public partial class ssiso : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ChiTietGioHang",
                table: "ChiTietGioHang");

            migrationBuilder.RenameTable(
                name: "ChiTietGioHang",
                newName: "chiTietGioHangs");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietGioHang_SanPhamID",
                table: "chiTietGioHangs",
                newName: "IX_chiTietGioHangs_SanPhamID");

            migrationBuilder.RenameIndex(
                name: "IX_ChiTietGioHang_GioHangID",
                table: "chiTietGioHangs",
                newName: "IX_chiTietGioHangs_GioHangID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_chiTietGioHangs",
                table: "chiTietGioHangs",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_chiTietGioHangs",
                table: "chiTietGioHangs");

            migrationBuilder.RenameTable(
                name: "chiTietGioHangs",
                newName: "ChiTietGioHang");

            migrationBuilder.RenameIndex(
                name: "IX_chiTietGioHangs_SanPhamID",
                table: "ChiTietGioHang",
                newName: "IX_ChiTietGioHang_SanPhamID");

            migrationBuilder.RenameIndex(
                name: "IX_chiTietGioHangs_GioHangID",
                table: "ChiTietGioHang",
                newName: "IX_ChiTietGioHang_GioHangID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChiTietGioHang",
                table: "ChiTietGioHang",
                column: "Id");
        }
    }
}
