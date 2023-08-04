using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CleanArchitec_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "Country", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { "3d490a70-94ce-4d15-9494-5248280c2ce3", "312 Forest Avenue, BF 923", "USA", new DateTime(2023, 8, 3, 17, 18, 11, 605, DateTimeKind.Utc).AddTicks(6855), new DateTime(2023, 8, 3, 17, 18, 11, 605, DateTimeKind.Utc).AddTicks(6855), "Admin_Solutions Ltd" },
                    { "c9d4c053-49b6-410c-bc78-2d54a9991870", "583 Wall Dr. Gwynn Oak, MD 21207", "USA", new DateTime(2023, 8, 3, 17, 18, 11, 605, DateTimeKind.Utc).AddTicks(6815), new DateTime(2023, 8, 3, 17, 18, 11, 605, DateTimeKind.Utc).AddTicks(6817), "IT_Solutions Ltd" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "CompanyId", "CreatedAt", "ModifiedAt", "Name", "Position" },
                values: new object[,]
                {
                    { "021ca3c1-0deb-4afd-ae94-2159a8479811", 35, "3d490a70-94ce-4d15-9494-5248280c2ce3", new DateTime(2023, 8, 3, 17, 18, 11, 605, DateTimeKind.Utc).AddTicks(7188), new DateTime(2023, 8, 3, 17, 18, 11, 605, DateTimeKind.Utc).AddTicks(7188), "Kane Miller", "Administrator" },
                    { "80abbca8-664d-4b20-b5de-024705497d4a", 26, "c9d4c053-49b6-410c-bc78-2d54a9991870", new DateTime(2023, 8, 3, 17, 18, 11, 605, DateTimeKind.Utc).AddTicks(7171), new DateTime(2023, 8, 3, 17, 18, 11, 605, DateTimeKind.Utc).AddTicks(7172), "Sam Raiden", "Software developer" },
                    { "86dba8c0-d178-41e7-938c-ed49778fb52a", 30, "c9d4c053-49b6-410c-bc78-2d54a9991870", new DateTime(2023, 8, 3, 17, 18, 11, 605, DateTimeKind.Utc).AddTicks(7182), new DateTime(2023, 8, 3, 17, 18, 11, 605, DateTimeKind.Utc).AddTicks(7183), "Jana McLeaf", "Software developer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "021ca3c1-0deb-4afd-ae94-2159a8479811");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "80abbca8-664d-4b20-b5de-024705497d4a");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "86dba8c0-d178-41e7-938c-ed49778fb52a");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: "3d490a70-94ce-4d15-9494-5248280c2ce3");

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: "c9d4c053-49b6-410c-bc78-2d54a9991870");
        }
    }
}
