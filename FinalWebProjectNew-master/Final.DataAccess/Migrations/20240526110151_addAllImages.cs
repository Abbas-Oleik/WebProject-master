using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addAllImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "/images/products/product-4/8be61614-113a-4dd5-a2ff-d1eb70e16f0b.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "/images/products/product-4/6b702e26-aa2b-47b1-bab3-f885486939e3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "/images/products/product-5/1cbca164-761a-4c55-9459-82d6f2c9e0c1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "/images/products/product-5/7f0d6e2a-1a34-4c44-9596-0893338718bf.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "/images/products/product-6/3772c79c-f3dd-4f33-ba5a-e4bb6e198375.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "/images/products/product-4/6b702e26-aa2b-47b1-bab3-f885486939e3.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "/images/products/product-4/8be61614-113a-4dd5-a2ff-d1eb70e16f0b.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "/images/products/product-5/1bca164-761a-4c55-9459-82d6f2c9e0c1.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "/images/products/product-5/7f0d6e2a-1a34-4c44-9596-089338718bf.jpg");

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImageUrl",
                value: "/images/products/product-6/3772c79c-f3dd-4f33-ba5a-4eb6e198375.jpg");
        }
    }
}
