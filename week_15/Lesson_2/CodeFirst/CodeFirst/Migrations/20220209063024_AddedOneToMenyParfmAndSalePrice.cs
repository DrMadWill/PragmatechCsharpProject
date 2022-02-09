using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class AddedOneToMenyParfmAndSalePrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_SalePrices_ParfumId",
                table: "SalePrices",
                column: "ParfumId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalePrices_Parfums_ParfumId",
                table: "SalePrices",
                column: "ParfumId",
                principalTable: "Parfums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalePrices_Parfums_ParfumId",
                table: "SalePrices");

            migrationBuilder.DropIndex(
                name: "IX_SalePrices_ParfumId",
                table: "SalePrices");
        }
    }
}
