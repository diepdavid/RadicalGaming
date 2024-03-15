using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RadicalGaming.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Description", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Achieve the next level of absolute control with the Razer Viper 8KHz, a ambidextrous e-sports mouse with a true 8000 Hz polling rate for the fastest speed and lowest latency ever achieved.", 69.0, "Viper Gamingmouse" },
                    { 2, "Mechanical gaming keyboard with Chroma RGB (Digital multifunction wheel and media keys, Ergonomic wrist rest) Black, Nordic/Swedish layout", 139.0, "BlackWidow V3 Keyboard" },
                    { 3, "Defeat all enemies with the Razer Kraken X Lite gaming headset. With lightweight design, 7.1 surround sound, reliable microphone, and versatile compatibility, you can take on any challenge.", 39.0, "Kraken X Headset" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
