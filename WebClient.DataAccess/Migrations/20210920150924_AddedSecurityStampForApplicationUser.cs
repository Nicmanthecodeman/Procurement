using Microsoft.EntityFrameworkCore.Migrations;

namespace WebClient.DataAccess.Migrations
{
    public partial class AddedSecurityStampForApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SecurityStamp",
                schema: "proc",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SecurityStamp",
                schema: "proc",
                table: "Users");
        }
    }
}
