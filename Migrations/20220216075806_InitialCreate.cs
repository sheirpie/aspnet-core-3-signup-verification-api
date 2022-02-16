using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    HouseNumber = table.Column<string>(nullable: true),
                    LocalNumber = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    PostCode = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Region = table.Column<string>(nullable: true),
                    CampaignCode = table.Column<int>(nullable: false),
                    Source = table.Column<string>(nullable: true),
                    OfferType = table.Column<string>(nullable: true),
                    Language = table.Column<string>(nullable: true),
                    Creations = table.Column<string>(nullable: true),
                    Device = table.Column<string>(nullable: true),
                    Partner = table.Column<int>(nullable: false),
                    Referer = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Product = table.Column<string>(nullable: true),
                    Quantity = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leads", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leads");
        }
    }
}
