using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRM.Data.Migrations
{
    public partial class offertablegenerate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OfferName = table.Column<string>(nullable: true),
                    OfferCost = table.Column<decimal>(nullable: false),
                    OfferStartDate = table.Column<DateTime>(nullable: false),
                    OfferValidDate = table.Column<DateTime>(nullable: false),
                    ServeNoOfPeople = table.Column<int>(nullable: false),
                    OfferImage = table.Column<byte[]>(nullable: true),
                    OfferCondition = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offers");
        }
    }
}
