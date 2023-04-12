using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChaybiShop94.Data.Migrations
{
    public partial class DbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "1ddc3777-12ae-4f2a-9439-1f8bdc456415");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02a09ead-4a0d-4d33-8d35-e77393f83aef", "AQAAAAEAACcQAAAAELz/r5hT2DZ2psTK/4ux1UXKi0cFviXz/DIlCGQDTY6RB6eAS5+vSesKssqvrtlrPw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 12, 16, 49, 51, 723, DateTimeKind.Local).AddTicks(2551));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e774ba42-18ea-485e-8b62-08a0c95f97a3");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f4df944a-e9fc-46f3-9a96-66cb76f5e881", "AQAAAAEAACcQAAAAEPA8rjECXe8GukM/MJDeDmmVUia6zi15c0E1vJgYiaeR2TIpStIeDrL7qc//UE1Lbw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2023, 4, 11, 17, 37, 16, 898, DateTimeKind.Local).AddTicks(3723));
        }
    }
}
