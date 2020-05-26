using Microsoft.EntityFrameworkCore.Migrations;

namespace Eksamen.Migrations
{
    public partial class jpgadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "Path",
                value: "/images/products/boots/MC-Støvler Course Aero, Sort 1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "Path",
                value: "/images/products/boots/MC-Støvler Course Aero, Sort 2.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "Path",
                value: "/images/products/boots/MC-Støvler Course Aero, Sort 3.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "Path",
                value: "/images/products/gloves/MC-Handsker Course Wasteland, Sort 1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "Path",
                value: "/images/products/gloves/MC-Handsker Course Wasteland, Sort 2.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "Path",
                value: "/images/products/gloves/MC-Handsker Course Wasteland, Sort 3.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "Path",
                value: "/images/products/boots/MC-Støvler Course Aero, Sort 1");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "Path",
                value: "/images/products/boots/MC-Støvler Course Aero, Sort 2");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "Path",
                value: "/images/products/boots/MC-Støvler Course Aero, Sort 3");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 16,
                column: "Path",
                value: "/images/products/gloves/MC-Handsker Course Wasteland, Sort 1");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 17,
                column: "Path",
                value: "/images/products/gloves/MC-Handsker Course Wasteland, Sort 2");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 18,
                column: "Path",
                value: "/images/products/gloves/MC-Handsker Course Wasteland, Sort 3");
        }
    }
}
