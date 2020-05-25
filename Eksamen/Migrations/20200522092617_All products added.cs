using Microsoft.EntityFrameworkCore.Migrations;

namespace Eksamen.Migrations
{
    public partial class Allproductsadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "Path",
                value: "/images/products/helmets/hjelm1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Path",
                value: "/images/products/helmets/hjelm2.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "Path",
                value: "/images/products/helmets/hjelm3.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "Path",
                value: "/images/products/helmets/AGV X3000 1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "Path",
                value: "/images/products/helmets/AGV X3000 2.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "Path",
                value: "/images/products/helmets/AGV X3000 2.jpg");

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Path" },
                values: new object[,]
                {
                    { 24, "/images/products/suits/Læderdragt IXS Sport RS-1000 3.jpg" },
                    { 23, "/images/products/suits/Læderdragt IXS Sport RS-1000 2.jpg" },
                    { 22, "/images/products/suits/Læderdragt IXS Sport RS-1000 1.jpg" },
                    { 21, "/images/products/suits/Læderdragt 2-delt IXS Camaro 3.jpg" },
                    { 20, "/images/products/suits/Læderdragt 2-delt IXS Camaro 2.jpg" },
                    { 19, "/images/products/suits/Læderdragt 2-delt IXS Camaro 1.jpg" },
                    { 7, "/images/products/boots/MC-Sko XPD X-Zero R, Hvid 1.jpg" },
                    { 17, "/images/products/gloves/MC-Handsker Course Wasteland, Sort 2" },
                    { 16, "/images/products/gloves/MC-Handsker Course Wasteland, Sort 1" },
                    { 15, "/images/products/gloves/Handsker Course Alpha, Hvid 3.jpg" },
                    { 14, "/images/products/gloves/Handsker Course Alpha, Hvid 2.jpg" },
                    { 13, "/images/products/gloves/Handsker Course Alpha, Hvid 1.jpg" },
                    { 8, "/images/products/boots/MC-Sko XPD X-Zero R, Hvid 2.jpg" },
                    { 9, "/images/products/boots/MC-Sko XPD X-Zero R, Hvid 3.jpg" },
                    { 10, "/images/products/boots/MC-Støvler Course Aero, Sort 1" },
                    { 11, "/images/products/boots/MC-Støvler Course Aero, Sort 2" },
                    { 18, "/images/products/gloves/MC-Handsker Course Wasteland, Sort 3" },
                    { 12, "/images/products/boots/MC-Støvler Course Aero, Sort 3" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageId", "ProductId" },
                values: new object[,]
                {
                    { 17, 17, 6 },
                    { 18, 18, 6 },
                    { 19, 19, 7 },
                    { 23, 23, 8 },
                    { 21, 21, 7 },
                    { 22, 22, 8 },
                    { 16, 16, 6 },
                    { 24, 24, 8 },
                    { 20, 20, 7 },
                    { 15, 15, 5 },
                    { 12, 12, 4 },
                    { 13, 13, 5 },
                    { 11, 11, 4 },
                    { 10, 10, 4 },
                    { 9, 9, 3 },
                    { 8, 8, 3 },
                    { 7, 7, 3 },
                    { 14, 14, 5 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "ProductImageId" },
                values: new object[,]
                {
                    { 8, "Suits", "IXS RS-1000 er en læderdragt lavet af kængurulæder, for dig, der kræver den højest mulige sikkerhed og komfort!", "Læderdragt IXS Sport RS-1000", 11199m, 8 },
                    { 6, "Gloves", "God streethandske med det helt rigtige retro urbanlook.", "MC-Handsker Course Wasteland, Sort", 139m, 6 },
                    { 5, "Gloves", "Fremstillet af blødt og smidigt læder, der giver handsken en stor fleksibilitet og slidstyrke", "Handsker Course Alpha, Hvid", 339m, 5 },
                    { 4, "Boots", "Course Aero er sportsstøvler, der tilbyder stil, komfort og høj sikkerhed!", "MC-Støvler Course Aero, Sort", 1149m, 4 },
                    { 3, "Boots", "Den ultimative sko til racekørere på hurtige og sjove ture.", "MC-Sko XPD X-Zero R, Hvid", 699m, 3 },
                    { 2, "Helmet", "AGV X3000 lader dig drømme tilbage til gamle dage, da Giacomo Agostini tordnede mod sine 15 verdensmesterskabstitler!", "AGV X3000", 4679m, 2 },
                    { 1, "Helmet", "En god hjelm til billige penge", "HJC C70", 899m, 1 },
                    { 7, "Suits", "Stilet, robust og slidstærkt lædertøj med utrolig god ventilation. IXS har lykkes rigtig godt når de fremstillede Camaro-lædertøjet!", "Læderdragt 2-delt IXS Camaro 1", 3149m, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "Path",
                value: "/images/products/hjelm1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "Path",
                value: "/images/products/hjelm2.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "Path",
                value: "/images/products/hjelm3.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "Path",
                value: "/images/products/AGV X3000 1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "Path",
                value: "/images/products/AGV X3000 2.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "Path",
                value: "/images/products/AGV X3000 2.jpg");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price", "ProductImageId" },
                values: new object[,]
                {
                    { -1, "Helmet", "En god hjelm til billige penge", "HJC C70", 899m, 1 },
                    { -2, "Helmet", "AGV X3000 lader dig drømme tilbage til gamle dage, da Giacomo Agostini tordnede mod sine 15 verdensmesterskabstitler!", "AGV X3000", 4679m, 2 }
                });
        }
    }
}
