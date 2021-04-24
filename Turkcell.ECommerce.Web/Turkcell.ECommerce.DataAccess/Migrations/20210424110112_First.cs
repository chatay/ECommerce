using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Turkcell.ECommerce.DataAccess.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "test");

            migrationBuilder.CreateTable(
                name: "Account",
                schema: "test",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Desciption = table.Column<string>(nullable: true),
                    CategoryId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    Photo = table.Column<string>(nullable: true),
                    InsertedDateTime = table.Column<DateTime>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedDateTime = table.Column<DateTime>(nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UserId = table.Column<int>(nullable: false, defaultValueSql: "1")
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account",
                schema: "test");
        }
    }
}
