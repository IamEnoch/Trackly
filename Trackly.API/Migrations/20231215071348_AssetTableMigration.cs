using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TracklyApi.Migrations
{
    /// <inheritdoc />
    public partial class AssetTableMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BarcodeNumber",
                table: "Assets",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Assets_BarcodeNumber",
                table: "Assets",
                column: "BarcodeNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Assets_BarcodeNumber",
                table: "Assets");

            migrationBuilder.DropColumn(
                name: "BarcodeNumber",
                table: "Assets");
        }
    }
}
