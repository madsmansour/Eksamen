using Microsoft.EntityFrameworkCore.Migrations;

namespace Eksamen.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(nullable: false),
                    ImageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    Category = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ProductImageId = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Path" },
                values: new object[,]
                {
                    { 1, "/images/products/helmets/hjelm1.jpg" },
                    { 24, "/images/products/suits/Læderdragt IXS Sport RS-1000 3.jpg" },
                    { 23, "/images/products/suits/Læderdragt IXS Sport RS-1000 2.jpg" },
                    { 22, "/images/products/suits/Læderdragt IXS Sport RS-1000 1.jpg" },
                    { 21, "/images/products/suits/Læderdragt 2-delt IXS Camaro 3.jpg" },
                    { 19, "/images/products/suits/Læderdragt 2-delt IXS Camaro 1.jpg" },
                    { 18, "/images/products/gloves/MC-Handsker Course Wasteland, Sort 3.jpg" },
                    { 17, "/images/products/gloves/MC-Handsker Course Wasteland, Sort 2.jpg" },
                    { 16, "/images/products/gloves/MC-Handsker Course Wasteland, Sort 1.jpg" },
                    { 15, "/images/products/gloves/Handsker Course Alpha, Hvid 3.jpg" },
                    { 14, "/images/products/gloves/Handsker Course Alpha, Hvid 2.jpg" },
                    { 13, "/images/products/gloves/Handsker Course Alpha, Hvid 1.jpg" },
                    { 20, "/images/products/suits/Læderdragt 2-delt IXS Camaro 2.jpg" },
                    { 11, "/images/products/boots/MC-Støvler Course Aero, Sort 2.jpg" },
                    { 12, "/images/products/boots/MC-Støvler Course Aero, Sort 3.jpg" },
                    { 2, "/images/products/helmets/hjelm2.jpg" },
                    { 3, "/images/products/helmets/hjelm3.jpg" },
                    { 5, "/images/products/helmets/AGV X3000 2.jpg" },
                    { 4, "/images/products/helmets/AGV X3000 1.jpg" },
                    { 7, "/images/products/boots/MC-Sko XPD X-Zero R, Hvid 1.jpg" },
                    { 8, "/images/products/boots/MC-Sko XPD X-Zero R, Hvid 2.jpg" },
                    { 9, "/images/products/boots/MC-Sko XPD X-Zero R, Hvid 3.jpg" },
                    { 10, "/images/products/boots/MC-Støvler Course Aero, Sort 1.jpg" },
                    { 6, "/images/products/helmets/AGV X3000 2.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageId", "ProductId" },
                values: new object[,]
                {
                    { 10, 10, 4 },
                    { 14, 14, 5 },
                    { 11, 11, 4 },
                    { 12, 12, 4 },
                    { 13, 13, 5 },
                    { 15, 15, 5 },
                    { 21, 21, 7 },
                    { 17, 17, 6 },
                    { 18, 18, 6 },
                    { 19, 19, 7 },
                    { 20, 20, 7 },
                    { 22, 22, 8 },
                    { 9, 9, 3 },
                    { 16, 16, 6 },
                    { 8, 8, 3 },
                    { 24, 24, 8 },
                    { 6, 6, 2 },
                    { 5, 5, 2 },
                    { 4, 4, 2 },
                    { 3, 3, 1 },
                    { 2, 2, 1 },
                    { 1, 1, 1 },
                    { 23, 23, 8 },
                    { 7, 7, 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Image", "Name", "Price", "ProductImageId" },
                values: new object[,]
                {
                    { 8, "Suits", "IXS RS-1000 er en læderdragt lavet af kængurulæder, for dig, der kræver den højest mulige sikkerhed og komfort!", null, "Læderdragt IXS Sport RS-1000", 11199m, 8 },
                    { 7, "Suits", "Stilet, robust og slidstærkt lædertøj med utrolig god ventilation. IXS har lykkes rigtig godt når de fremstillede Camaro-lædertøjet!", null, "Læderdragt 2-delt IXS Camaro 1", 3149m, 7 },
                    { 6, "Gloves", "God streethandske med det helt rigtige retro urbanlook.", null, "MC-Handsker Course Wasteland, Sort", 139m, 6 },
                    { 5, "Gloves", "Fremstillet af blødt og smidigt læder, der giver handsken en stor fleksibilitet og slidstyrke", null, "Handsker Course Alpha, Hvid", 339m, 5 },
                    { 3, "Boots", "Den ultimative sko til racekørere på hurtige og sjove ture.", null, "MC-Sko XPD X-Zero R, Hvid", 699m, 3 },
                    { 2, "Helmet", "AGV X3000 lader dig drømme tilbage til gamle dage, da Giacomo Agostini tordnede mod sine 15 verdensmesterskabstitler!", null, "AGV X3000", 4679m, 2 },
                    { 1, "Helmet", "En god hjelm til billige penge", null, "HJC C70", 899m, 1 },
                    { 4, "Boots", "Course Aero er sportsstøvler, der tilbyder stil, komfort og høj sikkerhed!", null, "MC-Støvler Course Aero, Sort", 1149m, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
