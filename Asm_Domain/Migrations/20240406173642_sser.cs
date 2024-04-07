using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Asm_Domain.Migrations
{
    /// <inheritdoc />
    public partial class sser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "GioHangs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "GioHangs");
        }
    }
}
