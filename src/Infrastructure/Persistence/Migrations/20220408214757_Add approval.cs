using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SupplyChainManager.Infrastructure.Persistence.Migrations
{
    public partial class Addapproval : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Approved",
                table: "Suppliers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Approved",
                table: "Suppliers");
        }
    }
}
