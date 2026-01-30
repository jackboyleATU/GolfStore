using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GolfStore_L00181486.Migrations
{
    /// <inheritdoc />
    public partial class intial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Clubtypes",
                columns: table => new
                {
                    TypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubtypes", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "Clubs",
                columns: table => new
                {
                    ClubId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Forgiveness = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubs", x => x.ClubId);
                    table.ForeignKey(
                        name: "FK_Clubs_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Clubs_Clubtypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Clubtypes",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "Abbreviation", "LogoUrl", "Name" },
                values: new object[,]
                {
                    { 1, "CAL", "https://upload.wikimedia.org/wikipedia/commons/8/89/Callaway_Golf_Company_logo.svg", "Callaway" },
                    { 2, "TAY", "https://upload.wikimedia.org/wikipedia/en/1/1f/Taylormade_logo.png", "TaylorMade" },
                    { 3, "TIT", "https://upload.wikimedia.org/wikipedia/commons/d/d6/Titleist_golf_logo.png", "Titleist" },
                    { 4, "PIN", "https://upload.wikimedia.org/wikipedia/commons/3/37/Ping-logo.png", "Ping" },
                    { 5, "COB", "https://www.cobragolf.com/cdn/shop/files/COBRA-logo-2022-black-shopify-checkout_1724x.png?v=1689363641", "Cobra" },
                    { 6, "MIZ", "https://upload.wikimedia.org/wikipedia/commons/3/34/Mizuno_logo.jpg", "Mizuno" }
                });

            migrationBuilder.InsertData(
                table: "Clubtypes",
                columns: new[] { "TypeId", "ImgUrl", "Type" },
                values: new object[,]
                {
                    { 1, "/images/driver.png", "Driver" },
                    { 2, "/images/fairwayWood.png", "Fairway Wood" },
                    { 3, "/images/hybrid.png", "Hybrid" },
                    { 4, "/images/iron.png", "Iron" },
                    { 5, "/images/wedge.png", "Wedge" },
                    { 6, "/images/putter.png", "Putter" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_BrandId",
                table: "Clubs",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Clubs_TypeId",
                table: "Clubs",
                column: "TypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clubs");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Clubtypes");
        }
    }
}
