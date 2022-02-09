using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Migrations
{
    public partial class AddedParfumTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parfums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    BrendId = table.Column<int>(nullable: false),
                    GenderId = table.Column<int>(nullable: false),
                    DensityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parfums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parfums_Brends_BrendId",
                        column: x => x.BrendId,
                        principalTable: "Brends",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parfums_Densities_DensityId",
                        column: x => x.DensityId,
                        principalTable: "Densities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parfums_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parfums_BrendId",
                table: "Parfums",
                column: "BrendId");

            migrationBuilder.CreateIndex(
                name: "IX_Parfums_DensityId",
                table: "Parfums",
                column: "DensityId");

            migrationBuilder.CreateIndex(
                name: "IX_Parfums_GenderId",
                table: "Parfums",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Parfums_Name",
                table: "Parfums",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parfums");
        }
    }
}
