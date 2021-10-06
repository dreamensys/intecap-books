using Microsoft.EntityFrameworkCore.Migrations;

namespace IntecapBooks.Migrations
{
    public partial class AddMasterData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Novela" },
                    { 2, "SciFi" },
                    { 3, "Científico" }
                });

            migrationBuilder.InsertData(
                table: "CoverTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tapa Blanda" },
                    { 2, "Tapa Dura" },
                    { 3, "Digital" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CoverTypes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
