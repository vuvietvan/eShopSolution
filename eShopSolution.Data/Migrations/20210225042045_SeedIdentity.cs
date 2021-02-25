using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 25, 11, 20, 43, 798, DateTimeKind.Local).AddTicks(8375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 2, 25, 11, 4, 6, 23, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("d862b555-6f83-4ff6-9a79-2a2eabbe4166"), "79eb0ca8-468b-46e7-84d6-c349b3402044", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("d862b555-6f83-4ff6-9a79-2a2eabbe4166"), new Guid("62a9878d-aa18-47c8-85cc-71e5f7a81dee") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("62a9878d-aa18-47c8-85cc-71e5f7a81dee"), 0, "a1dd49e3-f537-42c2-acf6-8104a50f6252", new DateTime(2021, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "vuvietvan2605@gmail.com", true, "Vu", "Viet Van", false, null, "vuvietvan2605@gmail.com", "admin", "AQAAAAEAACcQAAAAEP08HZsJ20QaC7Zr3S2DPVittdU9bIxajjBQqCbolFpBBI+IdbillCF45S8a9nF2FA==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 2, 25, 11, 20, 43, 826, DateTimeKind.Local).AddTicks(5953));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("d862b555-6f83-4ff6-9a79-2a2eabbe4166"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("d862b555-6f83-4ff6-9a79-2a2eabbe4166"), new Guid("62a9878d-aa18-47c8-85cc-71e5f7a81dee") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("62a9878d-aa18-47c8-85cc-71e5f7a81dee"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 2, 25, 11, 4, 6, 23, DateTimeKind.Local).AddTicks(8624),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 2, 25, 11, 20, 43, 798, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 2, 25, 11, 4, 6, 55, DateTimeKind.Local).AddTicks(1911));
        }
    }
}
