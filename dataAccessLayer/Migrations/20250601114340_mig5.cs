using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "kitapId",
                table: "Odüncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "uyeId",
                table: "Odüncs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "kitapId",
                table: "Odüncs");

            migrationBuilder.DropColumn(
                name: "uyeId",
                table: "Odüncs");
        }
    }
}
