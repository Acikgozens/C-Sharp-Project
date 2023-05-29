using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ETicaret.DataAccesLayer.Migrations
{
    public partial class firstCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CategoryStatus = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    SortKey = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerLastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CustomerEmail = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CustomerUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BirthDay = table.Column<DateTime>(type: "date", nullable: false),
                    datetime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    CustomerStatus = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    varchar = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CustomerPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TokenExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmployeeLastname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmployeeUserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmployeeStatu = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    datetime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    SortKey = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RoleStatu = table.Column<bool>(type: "bit", nullable: false),
                    RoleDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "SubCategoryBrands",
                columns: table => new
                {
                    SubCategoryBrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    SubCategoryBrandStatus = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    SortKey = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    SubCategoryBrandName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoryBrands", x => x.SubCategoryBrandId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CategoryStatus", "SortKey" },
                values: new object[] { 1, "Elektronik", true, (short)1 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "BirthDay", "datetime", "CustomerEmail", "CustomerLastName", "CustomerName", "CustomerPassword", "CustomerStatus", "CustomerUserName", "varchar", "Token", "TokenExpireDate" },
                values: new object[] { 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 23, 13, 20, 25, 355, DateTimeKind.Local).AddTicks(3610), "tt@gmail.com", "Tanin", "Tuncay", null, true, "tt", "+905327411235", null, null });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "EmployeeEmail", "EmployeeLastname", "EmployeeName", "EmployeeStatu", "EmployeeUserName", "SortKey" },
                values: new object[] { 1, "enesefea@gmail.com", "Acikgoz", "Enes", true, "acikgozens", (short)1 });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleDescription", "RoleName", "RoleStatu" },
                values: new object[] { 1, "Admin kullanıcıları için oluşturuğumuz role", "Admin", true });

            migrationBuilder.InsertData(
                table: "SubCategoryBrands",
                columns: new[] { "SubCategoryBrandId", "BrandId", "SortKey", "SubCategoryBrandName", "SubCategoryBrandStatus", "SubCategoryId" },
                values: new object[] { 1, 0, (short)1, "Puma", true, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SubCategoryBrands");
        }
    }
}
