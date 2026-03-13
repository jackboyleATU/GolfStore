using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GolfStore.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class clubs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clubs",
                columns: new[] { "ClubId", "BrandId", "Forgiveness", "ImgUrl", "Name", "Price", "Stock", "TypeId" },
                values: new object[,]
                {
                    { 1, 1, 1, "/images/clubs/elyte.png", "Elyte", 500, 12, 1 },
                    { 2, 1, 2, "/images/clubs/elyte-x.png", "Elyte X", 500, 12, 1 },
                    { 3, 1, 0, "/images/clubs/elyte-triple-diamond.png", "Elyte Triple Diamond", 500, 12, 1 },
                    { 4, 1, 1, "/images/clubs/elyte.png", "Elyte", 500, 12, 1 },
                    { 5, 2, 1, "/images/clubs/Qi4D.png", "Qi4D", 500, 12, 1 },
                    { 6, 2, 2, "/images/clubs/Qi4D-Max.png", "Qi4D Max", 500, 12, 1 },
                    { 7, 2, 0, "/images/clubs/Qi4D-LS.png", "Qi4D LS", 500, 12, 1 },
                    { 8, 3, 2, "/images/clubs/GT1.png", "GT1", 500, 12, 1 },
                    { 9, 3, 0, "/images/clubs/GT4.png", "GT4", 500, 12, 1 },
                    { 10, 3, 1, "/images/clubs/GT3.png", "GT3", 500, 12, 1 },
                    { 11, 4, 1, "/images/clubs/G440-K.png", "G440 K", 500, 12, 1 },
                    { 12, 4, 2, "/images/clubs/G440-Max.png", "G440 Max", 500, 12, 1 },
                    { 13, 4, 0, "/images/clubs/G440-LST.png", "G440 LST", 500, 12, 1 },
                    { 14, 5, 1, "/images/clubs/OPTM-X.png", "OPTM X", 500, 12, 1 },
                    { 15, 5, 2, "/images/clubs/OPTM-Max-K.png", "OPTM Max-K", 500, 12, 1 },
                    { 16, 5, 0, "/images/clubs/OPTM-LS.png", "OPTM LS", 500, 12, 1 },
                    { 17, 6, 2, "/images/clubs/JPX-ONE.png", "JPX ONE", 500, 12, 1 },
                    { 18, 6, 0, "/images/clubs/JPX-ONE-Select.png", "JPX ONE Select", 500, 12, 1 },
                    { 19, 1, 2, "/images/clubs/X-Forged-Max.png", "X Forged Max", 1300, 12, 4 },
                    { 20, 1, 1, "/images/clubs/X-Forged.png", "X Forged", 1300, 12, 4 },
                    { 21, 2, 2, "/images/clubs/P790.png", "P790", 1300, 12, 4 },
                    { 22, 2, 1, "/images/clubs/P770.png", "P770", 1300, 12, 4 },
                    { 23, 2, 0, "/images/clubs/P7MB.png", "P7MB", 1300, 12, 4 },
                    { 24, 3, 2, "/images/clubs/T100.png", "T100", 1300, 12, 4 },
                    { 25, 3, 0, "/images/clubs/T250.png", "T250", 1300, 12, 4 },
                    { 26, 4, 1, "/images/clubs/G440-Irons.png", "G440", 1300, 12, 4 },
                    { 27, 4, 2, "/images/clubs/G440-HL-Irons.png", "G440 HL", 1300, 12, 4 },
                    { 28, 5, 1, "/images/clubs/King-Irons.png", "King", 1300, 12, 4 },
                    { 29, 5, 0, "/images/clubs/King-Tec-Irons.png", "King Tec", 1300, 12, 4 },
                    { 30, 6, 2, "/images/clubs/Pro-M13.png", "Pro M13", 1300, 12, 4 },
                    { 31, 6, 0, "/images/clubs/Pro-M15.png", "Pro M15", 1300, 12, 4 },
                    { 32, 1, 2, "/images/clubs/Elyte-Wood.png", "Elyte Fairway", 300, 12, 2 },
                    { 33, 1, 1, "/images/clubs/Elyte-X-Wood.png", "Elyte X Fairway", 300, 12, 2 },
                    { 34, 1, 0, "/images/clubs/Elyte-Triple-Diamond-Wood.png", "Elyte Triple Diamond Fairway", 300, 12, 2 },
                    { 35, 2, 1, "/images/clubs/Qi4D-Wood.png", "Qi4D Fairway", 300, 12, 2 },
                    { 36, 2, 2, "/images/clubs/Qi4D-Max-Wood.png", "Qi4D Max Fairway", 300, 12, 2 },
                    { 37, 2, 0, "/images/clubs/Qi4D-Tour-Wood.png", "Qi4D Tour Fairway", 300, 12, 2 },
                    { 38, 3, 2, "/images/clubs/GT1-Wood.png", "GT1 Fairway", 300, 12, 2 },
                    { 39, 3, 1, "/images/clubs/GT2-Wood.png", "GT2 Fairway", 300, 12, 2 },
                    { 40, 3, 0, "/images/clubs/GT3-Wood.png", "GT3 Fairway", 300, 12, 2 },
                    { 41, 4, 1, "/images/clubs/G440-SFT-Wood.png", "G440 SFT Fairway", 300, 12, 2 },
                    { 42, 4, 2, "/images/clubs/G440-Max-Wood.png", "G440 Max Fairway", 300, 12, 2 },
                    { 43, 4, 0, "/images/clubs/G440-LST-Wood.png", "G440 LST Fairway", 300, 12, 2 },
                    { 44, 5, 1, "/images/clubs/OPTM-X-Wood.png", "OPTM X Fairway", 300, 12, 2 },
                    { 45, 5, 2, "/images/clubs/OPTM-Max-Wood.png", "OPTM Max Fairway", 300, 12, 2 },
                    { 46, 5, 0, "/images/clubs/OPTM-LS-Wood.png", "OPTM LS Fairway", 300, 12, 2 },
                    { 47, 6, 1, "/images/clubs/JPX-ONE-Wood.png", "JPX ONE Fairway", 300, 12, 2 },
                    { 48, 1, 2, "/images/clubs/Quantum-Max-Hybrid.png", "Quantum Max Hybrid", 300, 12, 3 },
                    { 49, 2, 1, "/images/clubs/Qi4D-Rescue.png", "Qi4D Rescue", 300, 12, 3 },
                    { 50, 3, 1, "/images/clubs/GT3-Hybrid.png", "GT3 Hybrid", 300, 12, 3 },
                    { 51, 4, 1, "/images/clubs/G440-Hybrid.png", "G440 Hybrid", 300, 12, 3 },
                    { 52, 5, 1, "/images/clubs/OPTM-Hybrid.png", "OPTM Hybrid", 300, 12, 3 },
                    { 53, 6, 1, "/images/clubs/JPX-ONE-Hybrid.png", "JPX ONE Hybrid", 300, 12, 3 },
                    { 54, 1, 1, "/images/clubs/Jaws.png", "Jaws", 200, 12, 5 },
                    { 55, 2, 1, "/images/clubs/MG5.png", "MG5", 200, 12, 5 },
                    { 56, 3, 1, "/images/clubs/Vokey-SM11.png", "Vokey SM11", 200, 12, 5 },
                    { 57, 4, 1, "/images/clubs/S259.png", "S259", 200, 12, 5 },
                    { 58, 5, 1, "/images/clubs/King-Wedge.png", "King Wedge", 200, 12, 5 },
                    { 59, 6, 1, "/images/clubs/Pro-T3.png", "Pro-T3", 200, 12, 5 },
                    { 60, 1, 1, "/images/clubs/Odyssey.png", "Odyssey AI Dual", 200, 12, 6 },
                    { 61, 1, 2, "/images/clubs/Odyssey.png", "Odyssey AI Dual", 500, 12, 6 },
                    { 62, 2, 2, "/images/clubs/Spyder.png", "Spyder ZT", 500, 12, 6 },
                    { 63, 3, 2, "/images/clubs/Scotty-Cameron.png", "Scotty Cameron Santa Fe", 500, 12, 6 },
                    { 64, 4, 2, "/images/clubs/PLD.png", "PLD Anser", 500, 12, 6 },
                    { 65, 5, 2, "/images/clubs/MIM.png", "MIM Nova", 300, 12, 6 },
                    { 66, 6, 2, "/images/clubs/M-Craft.png", "M Craft", 500, 12, 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Clubs",
                keyColumn: "ClubId",
                keyValue: 66);
        }
    }
}
