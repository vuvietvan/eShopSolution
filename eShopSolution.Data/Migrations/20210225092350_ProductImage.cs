using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class ProductImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 2, 25, 11, 20, 43, 798, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false),
                    FileSize = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("d862b555-6f83-4ff6-9a79-2a2eabbe4166"),
                column: "ConcurrencyStamp",
                value: "623360b8-08cc-46a2-af1c-0e8a45f34147");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("62a9878d-aa18-47c8-85cc-71e5f7a81dee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7ae1b5e4-7301-40b8-b6ff-fa377669a2a8", "AQAAAAEAACcQAAAAEOtDkbx2DapyXpe38SoNKfLFKM5WLMxjfGa0UqRcCTZs/5VD53pka90VQzfT6YEv0g==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 2, 25, 16, 23, 48, 873, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 25, 11, 20, 43, 798, DateTimeKind.Local).AddTicks(8375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("d862b555-6f83-4ff6-9a79-2a2eabbe4166"),
                column: "ConcurrencyStamp",
                value: "79eb0ca8-468b-46e7-84d6-c349b3402044");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("62a9878d-aa18-47c8-85cc-71e5f7a81dee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a1dd49e3-f537-42c2-acf6-8104a50f6252", "AQAAAAEAACcQAAAAEP08HZsJ20QaC7Zr3S2DPVittdU9bIxajjBQqCbolFpBBI+IdbillCF45S8a9nF2FA==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 2, 25, 11, 20, 43, 826, DateTimeKind.Local).AddTicks(5953));
        }
    }
}
