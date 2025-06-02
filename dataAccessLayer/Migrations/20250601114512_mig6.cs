using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Odüncs_Kitaplars_Kitapsid",
                table: "Odüncs");

            migrationBuilder.DropForeignKey(
                name: "FK_Odüncs_Uyelers_uyelersid",
                table: "Odüncs");

            migrationBuilder.DropIndex(
                name: "IX_Odüncs_Kitapsid",
                table: "Odüncs");

            migrationBuilder.DropIndex(
                name: "IX_Odüncs_uyelersid",
                table: "Odüncs");

            migrationBuilder.DropColumn(
                name: "Kitapsid",
                table: "Odüncs");

            migrationBuilder.DropColumn(
                name: "uyelersid",
                table: "Odüncs");

            migrationBuilder.CreateIndex(
                name: "IX_Odüncs_kitapId",
                table: "Odüncs",
                column: "kitapId");

            migrationBuilder.CreateIndex(
                name: "IX_Odüncs_uyeId",
                table: "Odüncs",
                column: "uyeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Odüncs_Kitaplars_kitapId",
                table: "Odüncs",
                column: "kitapId",
                principalTable: "Kitaplars",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Odüncs_Uyelers_uyeId",
                table: "Odüncs",
                column: "uyeId",
                principalTable: "Uyelers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Odüncs_Kitaplars_kitapId",
                table: "Odüncs");

            migrationBuilder.DropForeignKey(
                name: "FK_Odüncs_Uyelers_uyeId",
                table: "Odüncs");

            migrationBuilder.DropIndex(
                name: "IX_Odüncs_kitapId",
                table: "Odüncs");

            migrationBuilder.DropIndex(
                name: "IX_Odüncs_uyeId",
                table: "Odüncs");

            migrationBuilder.AddColumn<int>(
                name: "Kitapsid",
                table: "Odüncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "uyelersid",
                table: "Odüncs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Odüncs_Kitapsid",
                table: "Odüncs",
                column: "Kitapsid");

            migrationBuilder.CreateIndex(
                name: "IX_Odüncs_uyelersid",
                table: "Odüncs",
                column: "uyelersid");

            migrationBuilder.AddForeignKey(
                name: "FK_Odüncs_Kitaplars_Kitapsid",
                table: "Odüncs",
                column: "Kitapsid",
                principalTable: "Kitaplars",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Odüncs_Uyelers_uyelersid",
                table: "Odüncs",
                column: "uyelersid",
                principalTable: "Uyelers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
