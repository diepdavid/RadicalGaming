using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RadicalGaming.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeSeedDataToCategoryAndTeam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "GamingMouse");

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Rickard");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Mouse");

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Rick");
        }
    }
}
