using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRMSystem.Presentation.Core.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserCreated = table.Column<int>(nullable: false),
                    UserModified = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserCreated = table.Column<int>(nullable: false),
                    UserModified = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    CostPrice = table.Column<decimal>(nullable: false),
                    SalePrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    PriceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserCreated = table.Column<int>(nullable: false),
                    UserModified = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Amount = table.Column<decimal>(nullable: false),
                    InvoiceNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserCreated = table.Column<int>(nullable: false),
                    UserModified = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Post = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
