using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternetShopClothes.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddClothTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ClothModel",
                table: "ClothModel");

            migrationBuilder.RenameTable(
                name: "ClothModel",
                newName: "Cloths");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cloths",
                table: "Cloths",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Cloths",
                table: "Cloths");

            migrationBuilder.RenameTable(
                name: "Cloths",
                newName: "ClothModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ClothModel",
                table: "ClothModel",
                column: "Id");
        }
    }
}
